using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.DTOs
{
    public class EmployeeGrouping1
    {
        [Required]
        public string CivilId { get; set; } = string.Empty;
        [Required]
        public string FileNumber { get; set; } = string.Empty;
        
        [Required]
        public string? Name { get; set; } = string.Empty;
        [Required]
        public string? Address { get; set; } = string.Empty;

        [Required, DataType(DataType.PhoneNumber)]
        public string? TelephoneNumber { get; set; } = string.Empty;
        [Required]
        public string? Photo { get; set; } = string.Empty;
    }
}
