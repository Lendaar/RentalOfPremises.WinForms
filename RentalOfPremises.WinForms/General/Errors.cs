using Newtonsoft.Json;
using System.Collections.Generic;

namespace RentalOfPremises.WinForms.General
{
    public class Errors
    {
        [JsonProperty("errors")]
        public List<MessageErrors> MessageErrors { get; set; }
    }
}
