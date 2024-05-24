using Newtonsoft.Json;
using RentalOfPremises.WinForms.General.MessageFromValidator;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.BL
{
    public class HttpClient
    {
        public static async Task<List<T>> GetData<T>(string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var data = await client.GetAsync(path);
                data.EnsureSuccessStatusCode();
                var result = await data.Content.ReadAsStringAsync();
                var listResponse = JsonConvert.DeserializeObject<List<T>>(result);
                return listResponse;
            }
            catch 
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<T>();
            }
        }

        public static async Task<DialogResult> CreateData<T>(T modelRequest, string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var json = JsonConvert.SerializeObject(modelRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var data = await client.PostAsync(path, content);
                if (data.StatusCode.Equals(HttpStatusCode.Conflict))
                {
                    GetMessageFromApi.GetMessageFromValidator(data);
                    return DialogResult.No;
                }
                data.EnsureSuccessStatusCode();
                MessageBox.Show("Запись создана", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.No;
            }
        }

        public static async Task DeleteData(Guid id, string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var data = await client.DeleteAsync(path + id);
                if(data.StatusCode.Equals(HttpStatusCode.NotAcceptable))
                {
                    GetMessageFromApi.GetMessageAboutErrors(data);
                    return;
                }
                data.EnsureSuccessStatusCode();
                MessageBox.Show("Запись удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task<DialogResult> UpdateData<T>(T modelRequest, string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var json = JsonConvert.SerializeObject(modelRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var data = await client.PutAsync(path, content);
                if (data.StatusCode.Equals(HttpStatusCode.Conflict))
                {
                    GetMessageFromApi.GetMessageFromValidator(data);
                    return DialogResult.No;
                }
                if (data.StatusCode.Equals(HttpStatusCode.NotAcceptable))
                {
                    GetMessageFromApi.GetMessageAboutErrors(data);
                    return DialogResult.No;
                }
                data.EnsureSuccessStatusCode();
                MessageBox.Show("Запись обновлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.No;
            }
        }
    }
}
