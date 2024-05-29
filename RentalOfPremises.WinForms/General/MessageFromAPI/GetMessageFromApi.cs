using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.General.MessageFromValidator
{
    public static class GetMessageFromApi
    {
        public static DialogResult MessageFiltr(HttpResponseMessage response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    return DialogResult.OK;
                case HttpStatusCode.Conflict:
                    GetMessageFromValidator(response);
                    break;
                case HttpStatusCode.NotFound:
                    GetMessageException(response);
                    break;
                case HttpStatusCode.NotAcceptable:
                    GetMessageException(response);
                    break;
                case HttpStatusCode.Unauthorized:
                    MaterialMessageBox.Show("Отказано в доступе", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                    break;
                default: break;
            }
            return DialogResult.No;
        }

        public static void GetMessageFromValidator(HttpResponseMessage data)
        {
            var response = data.Content.ReadAsStringAsync().Result;
            var errors = JsonConvert.DeserializeObject<Errors>(response);
            var message = string.Empty;
            foreach (var error in errors.MessageErrors)
            {
                message += $"{error.Message}\n";
            }
            MessageBox.Show($"{message}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void GetMessageException(HttpResponseMessage data)
        {
            var response = data.Content.ReadAsStringAsync().Result;
            var error = JsonConvert.DeserializeObject<MessageErrors>(response);
            MessageBox.Show($"{error.Message}\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
