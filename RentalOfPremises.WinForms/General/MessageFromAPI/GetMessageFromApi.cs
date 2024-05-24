using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.General.MessageFromValidator
{
    public static class GetMessageFromApi
    {
        public static async void GetMessageFromValidator(HttpResponseMessage data)
        {
            var response = await data.Content.ReadAsStringAsync();
            var errors = JsonConvert.DeserializeObject<Errors>(response);
            var message = "";
            foreach (var error in errors.MessageErrors)
            {
                message += $"{error.Message}\n";
            }
            MessageBox.Show($"{message}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static async void GetMessageAboutErrors(HttpResponseMessage data)
        {
            var response = await data.Content.ReadAsStringAsync();
            var error = JsonConvert.DeserializeObject<MessageErrors>(response);
            var message = $"{error.Message}\n";
            MessageBox.Show($"{message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
