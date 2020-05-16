using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Document { set; get; }
        [Required]
        [MaxLength(50)]
        [Display (Name = "First Name")]
        public string FirstName { set; get; }
        [Required]
        [MaxLength(50)]
        [Display (Name = "Last Name")]
        public string LastName { set; get; }
        [Display(Name ="Fixed Phone")]
        public string FixedPhone { set; get; }
        [Required]
        [MaxLength(20)]
        [Display(Name ="Cell Phone")]
        public string CellPhone { set; get; }
        [MaxLength(100)]
        public string Address { set; get; }
        [Display(Name ="Owner")]
        public string FullName => $"{FirstName} {LastName}";
        [Display(Name = "Owner")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
