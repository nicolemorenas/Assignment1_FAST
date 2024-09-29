using System.ComponentModel.DataAnnotations;

namespace Assignment1_FAST.Models
{
    public enum EquipmentType
    {
        Laptop, Phone, Tablet, Another
    }

    public enum Role
    {
        Student, Professor
    }

    public class RequestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please select your role")]
        public Role? Role { get; set; }
        [Required(ErrorMessage = "Please select your equipment type")]
        public EquipmentType? EquipmentType { get; set; }
        [Required(ErrorMessage = "Please enter request details")]
        public string? RequestDetails { get; set; }
        [Required(ErrorMessage = "Please enter duration")]

        public int? Duration { get; set; }

        public int Id { get; set; }






    }
}