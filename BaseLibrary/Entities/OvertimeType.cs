using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class OvertimeType:BaseEntity
    {
        //Many to one Relationship with Vacation
       [JsonIgnore]
        public List<Overtime>? Overtimes { get; set; }
    }
}