using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.General.MessageFromValidator
{
    public static class GetMessageFromValidator
    {
        public static async void GetMessage(HttpResponseMessage data)
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
    }
}
