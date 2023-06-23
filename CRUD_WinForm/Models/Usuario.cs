namespace CRUD_WinForm.Models
{
    public class Usuario
    {
        //Modelo
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
        public string mail { get; set; }


        //Constructor
        public Usuario()
        {
            id = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            nombreUsuario = string.Empty;
            contrasena = string.Empty;
            mail = string.Empty;
        }
    }
}
