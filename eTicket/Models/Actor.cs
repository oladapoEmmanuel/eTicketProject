using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eTicket.Data.Base;

namespace eTicket.Models
{
    public class Actor : IEntityBase

    {
    [Key] 
    public int Id { get; set; }

    [Display(Name = "Profile Picture URL")]
    [Required(ErrorMessage = "Profile Picture is Required")]
    public string ProfilePictureURL { get; set; }

    [Display(Name = "Full Name")]
    [Required(ErrorMessage = "Full Name is Required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")]
    public string FullName { get; set; }

    [Display(Name = "Biography")]
    [Required(ErrorMessage = "Biography is Required")]
    public string Bio { get; set; }

    //Relationships

    public List<Actor_Movie> Actors_Movies { get; set; }

    }
}