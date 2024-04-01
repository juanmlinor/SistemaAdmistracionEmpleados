using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Country: BaseEntity
    {
        //Many to one relationship with City
        [JsonIgnore]
        public List<City>? Cities { get; set; }
    }
}