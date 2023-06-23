using CRUD_WinForm.Models;
using CRUD_WinForm.Repository;

namespace CRUD_WinForm

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            List<Producto> productos = ADO_Metodos.ObtenerProductos();
            dataGridView.DataSource = productos;
        }

        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            List<ProductoVendido> productosVendidos = ADO_Metodos.ObtenerProductosVendidos();
            dataGridView.DataSource = productosVendidos;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = ADO_Metodos.ObtenerUsuarios();
            dataGridView.DataSource = usuarios;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            List<Venta> ventas = ADO_Metodos.ObtenerVentas();
            dataGridView.DataSource = ventas;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            Usuario usuario = ADO_Metodos.IniciarSesion(nombreUsuario, contraseña);

            if (usuario != null)
            {
                MessageBox.Show("Usuario Correcto");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}