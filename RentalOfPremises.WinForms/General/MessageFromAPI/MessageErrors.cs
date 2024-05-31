using Newtonsoft.Json;

namespace RentalOfPremises.WinForms.General.MessageFromAPI
{
    public class MessageErrors
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
