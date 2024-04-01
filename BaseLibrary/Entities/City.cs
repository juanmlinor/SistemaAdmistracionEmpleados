using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class City : BaseEntity
    {
        //Many to one relationship with Country
        public Country? Country { get; set; }
        public int CountryId { get; set; }

        //Many to one relationship with Team
       [JsonIgnore]
        public List<Town>? Towns { get; set; } 


    }
}