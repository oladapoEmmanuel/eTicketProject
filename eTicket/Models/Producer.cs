using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eTicket.Data.Base;

namespace eTicket.Models
{
    public class Producer : IEntityBase
    {
        [Key] 
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required (ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")]
        [Required (ErrorMessage = "Full name is required")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required (ErrorMessage = "Biography is required")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        
        // Relationships
        public List<Movie> Movies { get; set; }
    }
}