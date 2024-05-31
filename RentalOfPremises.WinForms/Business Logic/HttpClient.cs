using Newtonsoft.Json;
using RentalOfPremises.WinForms.Context.General;
using RentalOfPremises.WinForms.Context.Models;
using RentalOfPremises.WinForms.General;
using RentalOfPremises.WinForms.General.MessageFromAPI;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.BusinessLogic
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
                CloseForm.Close();
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
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", DataFromToken.Token);
                var data = client.PostAsync(path, content).Result;
                var dialogResult = GetMessageFromApi.MessageFiltr(data);
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Запись создана", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return DialogResult.OK;
                }
                return DialogResult.No;
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseForm.Close();
                return DialogResult.No;
            }
        }

        public static DialogResult CreateDataList<T>(List<T> modelsRequest, string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var dialogResult = DialogResult.OK;
                foreach (var model in modelsRequest )
                {
                    var json = JsonConvert.SerializeObject(model);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", DataFromToken.Token);
                    var data = client.PostAsync(path, content).Result;
                    dialogResult = GetMessageFromApi.MessageFiltr(data);
                    if(dialogResult != DialogResult.OK)
                    {
                        return DialogResult.No;
                    }
                }
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Запись создана", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return DialogResult.OK;
                }
                return DialogResult.No;
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseForm.Close();
                return DialogResult.No;
            }
        }

        public static void DeleteData(Guid id, string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var data = client.DeleteAsync(path + id).Result;
                var dialogResult = GetMessageFromApi.MessageFiltr(data);
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Запись удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseForm.Close();
            }
        }

        public static void DeleteDataList(List<Guid> records, string path)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var dialogResult = DialogResult.OK;
                foreach (var record in records)
                {
                    var data = client.DeleteAsync(path + record).Result;
                    dialogResult = GetMessageFromApi.MessageFiltr(data);
                }
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Запись удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseForm.Close();
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
                var dialogResult = GetMessageFromApi.MessageFiltr(data);
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Запись обновлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return DialogResult.OK;
                }
                return DialogResult.No;
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseForm.Close();
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
                CloseForm.Close();
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
                var response = JsonConvert.DeserializeObject<int>(result);
                return response;
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseForm.Close();
                return 0;
            }
        }

        public static bool SignIn(string login, string password)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var data = client.PostAsync($"Authorization/SignIn?login={login}&password={password}", null).Result;
                var dialogResult = GetMessageFromApi.MessageFiltr(data);
                if (dialogResult == DialogResult.OK)
                {
                    var result = data.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<TokenResponse>(result);
                    DataFromToken.RoleUser = response.RoleUser;
                    DataFromToken.Token = response.Token;
                    MessageBox.Show("Успешный вход в приложение", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseForm.Close();
                return false;
            }
        }
    }
}
