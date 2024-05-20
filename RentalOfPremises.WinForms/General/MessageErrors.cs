using Newtonsoft.Json;

namespace RentalOfPremises.WinForms.General
{
    public class MessageErrors
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
