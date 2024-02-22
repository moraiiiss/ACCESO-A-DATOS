using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class tarea2 : Form
    {
        // Crea una conexión con la base de datos
        SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=tienda;Integrated Security=True");
        public tarea2()
        {
            InitializeComponent();

        }

        //Ejericio 1
        private void btnListarProductos_Click(object sender, EventArgs e)
        {

            textNombreProductos.Clear(); // Limpia el cuadro de texto
            textPrecioProductos.Clear();

            conexion.Open(); // Abre la conexión con la base de datos
            string NombreProducto = textNombreProductos.Text;
            string PrecioProducto = textPrecioProductos.Text;
            string cadena = "SELECT nombre,precio FROM producto";

            SqlCommand comando = new SqlCommand(cadena, conexion); // Crea un comando SQL
            SqlDataReader registros = comando.ExecuteReader(); // Ejecuta el comando SQL

            progressBarProductos.Visible = true; // Muestra la barra de progreso

            for (int i = 0; registros.Read(); i++)
            {
                NombreProducto = registros["nombre"].ToString(); // Obtiene el nombre del producto
                PrecioProducto = registros["precio"].ToString(); // Obtiene el precio del producto
                textNombreProductos.Text += NombreProducto + "\r\n"; // Agrega el nombre del producto al cuadro de texto
                textPrecioProductos.Text += PrecioProducto + "\r\n"; // Agrega el precio del producto al cuadro de texto

                progressBarProductos.PerformStep(); // Incrementa el valor de la barra de progreso
            }
            Thread.Sleep(2000); // Simula un proceso de carga

            progressBarProductos.Visible = false; // Oculta la barra de progreso

            conexion.Close();



        }

        //Ejercicio 2
        private void btnListaFabricantes_Click(object sender, EventArgs e)
        {
            textNombreFabricantes.Clear(); // Limpia el cuadro de texto
            conexion.Open(); // Abre la conexión con la base de datos

            string nombreFabricante = textNombreFabricantes.Text;
            string cadena = "SELECT nombre FROM fabricante";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();

            progressBarFabricantes.Visible = true;

            for (int i = 0; registros.Read(); i++)
            {
                nombreFabricante = registros["nombre"].ToString();
                textNombreFabricantes.Text += nombreFabricante + "\r\n";
                progressBarFabricantes.PerformStep();
            }
            Thread.Sleep(2000);

            progressBarFabricantes.Visible = false; // Oculta la barra de progreso
            conexion.Close(); // Cierra la conexión con la base de datos
        }


        //Ejercicio 3
        private void radioBtnFabricante_CheckedChanged(object sender, EventArgs e)
        {

            
            if (radioBtnFabricante.Checked )
            {
                conexion.Open();
                string busqueda = textBusqueda.Text;
                string resultadoBusqueda = textResultadoBusqueda.Text;
                string cadena = $"SELECT producto.nombre FROM producto INNER JOIN fabricante ON producto.codigo_fabricante = fabricante.codigo WHERE fabricante.nombre = '{busqueda}'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                string fabricante = $"Fabricante: {busqueda}";
                textResultadoBusqueda.Text += fabricante + "\r\n";

                while (registros.Read())
                {
                    
                    busqueda = registros["nombre"].ToString();
                    textResultadoBusqueda.Text += busqueda + "\r\n";

                }

                string espacio = "\r\n";
                textResultadoBusqueda.Text += espacio;

                conexion.Close();
                
                textBusqueda.Clear();
                radioBtnFabricante.Checked = false;


            }
            
            

        }

        private void btnLimpiarResultados_Click(object sender, EventArgs e)
        {
            textResultadoBusqueda.Clear();
        }

        private void radioBtnProducto_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnProducto.Checked)
            {
                conexion.Open();
                string busqueda = textBusqueda.Text;
                string resultadoBusqueda = textResultadoBusqueda.Text;
                string cadena = $"SELECT F.* FROM fabricante F INNER JOIN producto P ON P.codigo_fabricante = F.codigo WHERE P.nombre = '{busqueda}'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                string productoBuscado = $"Producto: {busqueda}";
                string informacionProducto = "Información del Fabricante: ";
                string nombreFabricante = "Nombre Fabricante: ";
                string codigoFabricante = "Código Fabricante: ";

                textResultadoBusqueda.Text += productoBuscado + "\r\n";
                textResultadoBusqueda.Text += informacionProducto + "\r\n";

                while (registros.Read())
                {
                    textResultadoBusqueda.Text += nombreFabricante;
                    busqueda = registros["nombre"].ToString();
                    textResultadoBusqueda.Text += busqueda + "\r\n";

                    textResultadoBusqueda.Text += codigoFabricante ;
                    busqueda = registros["codigo"].ToString();
                    textResultadoBusqueda.Text += busqueda + "\r\n";
                }

                string espacio = "\r\n";
                textResultadoBusqueda.Text += espacio;

                conexion.Close();

                textBusqueda.Clear();
                radioBtnProducto.Checked = false;
            }
            
        }
    }
}
