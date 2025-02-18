using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NVParser
{
    class OldWarhouses
    {
        [JsonPropertyName("response")]
        public List<OldWarehouse> Response { get; set; } = [];
    }

    public class OldWarehouse
    {
        public string city_ref { get; set; }
        public string city_id { get; set; }
        public string city { get; set; }
        public string cityRu { get; set; }

        [JsonPropertyName("ref")]
        public string Ref { get; set; }
        public string address { get; set; }
        public string addressRu { get; set; }
        public string number { get; set; }
        public string wareId { get; set; }
        public string phone { get; set; }
        public string weekday_work_hours { get; set; }
        public string weekday_reseiving_hours { get; set; }
        public string weekday_delivery_hours { get; set; }
        public string saturday_work_hours { get; set; }
        public string saturday_reseiving_hours { get; set; }
        public string saturday_delivery_hours { get; set; }
        public string working_monday { get; set; }
        public string working_tuesday { get; set; }
        public string working_wednesday { get; set; }
        public string working_thursday { get; set; }
        public string working_friday { get; set; }
        public string working_saturday { get; set; }
        public string working_sunday { get; set; }
        public string departure_monday { get; set; }
        public string departure_tuesday { get; set; }
        public string departure_wednesday { get; set; }
        public string departure_thursday { get; set; }
        public string departure_friday { get; set; }
        public string departure_saturday { get; set; }
        public string departure_sunday { get; set; }
        public string receipt_monday { get; set; }
        public string receipt_tuesday { get; set; }
        public string receipt_wednesday { get; set; }
        public string receipt_thursday { get; set; }
        public string receipt_friday { get; set; }
        public string receipt_saturday { get; set; }
        public string receipt_sunday { get; set; }
        public string max_weight_allowed { get; set; }
        public string y { get; set; }
        public string x { get; set; }
    }

}
