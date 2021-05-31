using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.MODELS.Entities
{
    public class UsersEntity
    {
        [Key]
        public int IDUSER { get; set; }
        [Required(ErrorMessage = "Nombre Obligatorio")]
        public string NOMBRE { get; set; }
        [Required(ErrorMessage = " Apellido Obligatorio")]
        public string APELLIDO { get; set; }
        [Required(ErrorMessage = "Tipo de identificación obligatorio")]
        public int TIPOIDENTIFICACION { get; set; }
        [Required(ErrorMessage = "Correo electrónico obligatorio")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Formato incorrecto")]
        public string EMAIL{ get; set; }
        [Required(ErrorMessage = "Número de identificación obligatorio")]
        public string IDENTIFICACION { get; set; }
        [Required(ErrorMessage = "Obligatorio"), MaxLength(15, ErrorMessage = "No más de 15 carácteres"),MinLength(8, ErrorMessage = "Mínimo 8 carácteres")]
        public string PASS { get; set; }
    






}
}
