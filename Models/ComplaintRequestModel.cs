using System.ComponentModel.DataAnnotations;

namespace ComplaintRequestSystem.Models
{
    public class ComplaintRequestModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
