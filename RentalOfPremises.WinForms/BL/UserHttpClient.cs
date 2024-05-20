using Newtonsoft.Json;
using RentalOfPremises.WinForms.General;
using RentalOfPremises.WinForms.Models;
using RentalOfPremises.WinForms.ModelsRequest.User;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.BL
{
    public class UserHttpClient
    {
        public static async Task<List<UserResponse>> GetUsers()
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var users = await client.GetAsync("User/");
                users.EnsureSuccessStatusCode();
                var s = users.StatusCode;
                var rez = await users.Content.ReadAsStringAsync();

                if (users.StatusCode == HttpStatusCode.OK)
                {
                    var usersResponse = (JsonConvert.DeserializeObject<List<UserResponse>>(rez));
                    usersResponse.ForEach(x => x.InitFio());

                    return usersResponse;
                }
                else
                {
                    return new List<UserResponse>();
                }
            }
            catch 
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<UserResponse>();
            }
        }

        public static async Task<DialogResult> CreateUser(UserRequest userRequest)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var json = JsonConvert.SerializeObject(userRequest);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var users = await client.PostAsync("User/", data);
                users.EnsureSuccessStatusCode();
                MessageBox.Show("Пользователь создан", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Cancel;
            }
        }

        public static async Task DeleteUser(Guid id)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var users = await client.DeleteAsync("User/" + id);
                users.EnsureSuccessStatusCode();
                MessageBox.Show("Пользователь удален", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task<DialogResult> UpdateUser(UserRequest userRequest)
        {
            try
            {
                var client = new GetHttpClient().GetClient();
                var json = JsonConvert.SerializeObject(userRequest);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var users = await client.PutAsync("User/", data);
                if (users.StatusCode.Equals(HttpStatusCode.Conflict))
                {
                    var rez = await users.Content.ReadAsStringAsync();
                    var errors = JsonConvert.DeserializeObject<Errors>(rez);

                    var message = "";
                    foreach ( var error in errors.MessageErrors )
                    {
                        message += error.Message + "\n";
                    }
                    MessageBox.Show($"{message}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return DialogResult.No;
                }
                
                users.EnsureSuccessStatusCode();
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
