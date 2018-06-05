using System.ComponentModel.DataAnnotations;

namespace FastService.prod.ViewModels
{
    public partial class ContactVm
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Phone1 { get; set; }
        [Required]
        public int Phone2 { get; set; }
        [Required]
        public string Message { get; set; }
    }
}