using System;
using System.ComponentModel.DataAnnotations;


namespace DojoModels.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "FirstName")]
       public string FirstName { get ; set;}

       [Required]
       public string Location { get; set ;}
       
       [Required]
       public string Language { get; set;}

       [MaxLength(20)]
       public string Comment { get; set;}
    }
}