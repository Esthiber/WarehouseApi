using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApi.Core.Entities
{
    public class Categorias
    {
        [Key]
        public int CategoriasId { get; set; }

        [Required(ErrorMessage = "Se debe espesificar el nombre de la categoria.")]
        public string Nombre { get; set; } = null!;
    }
}
