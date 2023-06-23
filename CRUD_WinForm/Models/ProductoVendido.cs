namespace CRUD_WinForm.Models
{
    public class ProductoVendido
    {
        //Modelo
        public int id { get; set; }
        public int idProducto { get; set; }
        public int stock { get; set; }
        public int idVenta { get; set; }


        //Constructor
        public ProductoVendido()
        {
            id = 0;
            idProducto = 0;
            stock = 0;
            idVenta = 0;
        }
    }
}
