using System.ComponentModel.DataAnnotations.Schema;

namespace DropDownsAnidadosMVC.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public double Precio { get; set; }

        public int CategoriaID { get; set; }

        [ForeignKey(nameof(CategoriaID))]
       Categoria Categoria { get; set; }


    }
}
