using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NVParser
{
    public class Cities
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("data")]
        public City[] Data { get; set; } = [];
    }

    public class City
    {
        public string? Description { get; set; }
        public string? DescriptionRu { get; set; }
        public string Ref { get; set; } = string.Empty;
        public string? Delivery1 { get; set; }
        public string? Delivery2 { get; set; }
        public string? Delivery3 { get; set; }
        public string? Delivery4 { get; set; }
        public string? Delivery5 { get; set; }
        public string? Delivery6 { get; set; }
        public string? Delivery7 { get; set; }
        public string? Area { get; set; }
        public string? SettlementType { get; set; }
        public string? IsBranch { get; set; }
        public string? PreventEntryNewStreetsUser { get; set; }
        public string CityID { get; set; } = string.Empty;
        public string? SettlementTypeDescription { get; set; }
        public string? SettlementTypeDescriptionRu { get; set; }
        public int SpecialCashCheck { get; set; }
        public string? AreaDescription { get; set; }
        public string? AreaDescriptionRu { get; set; }
    }

}
