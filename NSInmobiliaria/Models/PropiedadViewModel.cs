using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NSInmobiliaria.Models
{
    public class PropiedadViewModel
    {
        public PropiedadViewModel(string direccion, double precio)
        {
            Direccion = direccion;
            Precio = precio;
        }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Direccion { get; private set; }
        public double Precio { get; private set; }
        public int Id { get; private set; }
    }
}