using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required] //Campo Requerido
        [MaxLength(30)] //Tamaño Máximo del campo
        public string Document { get; set; }

        [Required]
        [MaxLength(50)]
        [Display (Name = "First Name")]//Como la va a ver el usuario
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        //Campos calculados
        //1 forma
        //public string FullName
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}

        //2 forma
        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Owner")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
