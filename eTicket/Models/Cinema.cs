using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eTicket.Data.Base;

namespace eTicket.Models
{
    public class Cinema : IEntityBase
    {
        [Key] 
        public int Id { get; set; }
        
        [Required (ErrorMessage = "Cinema Logo is Required")]
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Cinema Name must be between 3 and 50 characters")]
        [Required (ErrorMessage = "Cinema Name is Required")]
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Cinema Description is Required")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        
        //Relationships
        public List<Movie> Movies { get; set; }
    }
}