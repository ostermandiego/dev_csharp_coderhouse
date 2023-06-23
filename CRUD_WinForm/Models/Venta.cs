namespace CRUD_WinForm.Models
{
    public class Venta
    {
        //Modelo
        public int id { get; set; }
        public string comentarios { get; set; }


        //Constructor
        public Venta()
        {
            id = 0;
            comentarios = string.Empty;
        }
    }
}
