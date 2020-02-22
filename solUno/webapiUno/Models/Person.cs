

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapiUno.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre completo")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string Name { get; set; }

        [Display(Name = "Carnet de identidad")]
        public string Document { get; set; }

    }
}