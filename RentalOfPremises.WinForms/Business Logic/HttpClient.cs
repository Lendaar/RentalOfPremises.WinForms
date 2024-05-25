using Newtonsoft.Json;
using RentalOfPremises.WinForms.General.MessageFromValidator;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.BL
{
    public class HttpClient
    {
        public static List<T> GetData<T>(string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var data = client.GetAsync(path).Result;
                data.EnsureSuccessStatusCode();
                var result = data.Content.ReadAsStringAsync().Result;
                var listResponse = JsonConvert.DeserializeObject<List<T>>(result);
                return listResponse;
            }
            catch 
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<T>();
            }
        }

        public static DialogResult CreateData<T>(T modelRequest, string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var json = JsonConvert.SerializeObject(modelRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var data = client.PostAsync(path, content).Result;
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

        public static void DeleteData(Guid id, string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var data = client.DeleteAsync(path + id).Result;
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

        public static DialogResult UpdateData<T>(T modelRequest, string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var json = JsonConvert.SerializeObject(modelRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var data = client.PutAsync(path, content).Result;
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

        public static byte[] GetDocument(string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var dataBytes = client.GetByteArrayAsync(path).Result;
                return dataBytes;
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static int GetNumber(string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var data = client.GetAsync(path).Result;
                data.EnsureSuccessStatusCode();
                var result = data.Content.ReadAsStringAsync().Result;
                var listResponse = JsonConvert.DeserializeObject<int>(result);
                return listResponse;
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
