using System.ComponentModel.DataAnnotations.Schema;

namespace DropDownsAnidadosMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int SucursalID { get; set; }

        [ForeignKey(nameof(SucursalID))]
        public Sucursal Sucursal { get; set; }

        //Relacion uno a muchos con productos
        public ICollection<Producto> Productos { get; set; }

    }
}
