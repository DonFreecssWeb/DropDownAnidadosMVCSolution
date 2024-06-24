namespace DropDownsAnidadosMVC.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        //uno a muchos con categoria
        public ICollection<Categoria> Categorias { get; set; }

    }
}
