using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class SanctionType : BaseEntity
    {
        //Many to one Relationship with Vacation
      [JsonIgnore]
        public List<Sanction>? Sanctions { get; set; } 
    }
}