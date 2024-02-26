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


            if (radioBtnFabricante.Checked)
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
            if (radioBtnProducto.Checked)
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

                    textResultadoBusqueda.Text += codigoFabricante;
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



        private void btnListar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            listBoxProductos.Items.Clear();
            listBoxFabricantes.Items.Clear();

            // Consulta para obtener los productos y agregarlos al ListBox de productos
            string cadenaProducto = "SELECT nombre FROM producto";
            SqlCommand comandoProducto = new SqlCommand(cadenaProducto, conexion);
            SqlDataReader registrosProducto = comandoProducto.ExecuteReader();

            while (registrosProducto.Read())
            {
                string producto = registrosProducto["nombre"].ToString();
                listBoxProductos.Items.Add(producto);
            }
            registrosProducto.Close(); // Cierra el lector de registros de productos

            // Consulta para obtener los fabricantes y agregarlos al ListBox de fabricantes
            string cadenaFabricante = "SELECT nombre FROM fabricante";
            SqlCommand comandoFabricante = new SqlCommand(cadenaFabricante, conexion);
            SqlDataReader registrosFabricante = comandoFabricante.ExecuteReader();

            while (registrosFabricante.Read())
            {
                string fabricante = registrosFabricante["nombre"].ToString();
                listBoxFabricantes.Items.Add(fabricante);
            }
            registrosFabricante.Close();


            conexion.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //eliminamos el producto seleccionado o el fabricante seleccionado
            conexion.Open();
            string productoSeleccionado = listBoxProductos.GetItemText(listBoxProductos.SelectedItem);
            string fabricanteSeleccionado = listBoxFabricantes.GetItemText(listBoxFabricantes.SelectedItem);

            if (productoSeleccionado != "")
            {
                string cadena = $"DELETE FROM producto WHERE nombre = '{productoSeleccionado}'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                listBoxProductos.Items.Remove(productoSeleccionado);
            }
            else if (fabricanteSeleccionado != "")
            {
                string cadena = $"DELETE FROM fabricante WHERE nombre = '{fabricanteSeleccionado}'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                listBoxFabricantes.Items.Remove(fabricanteSeleccionado);
            }
            conexion.Close();
        }

        

        private void btnAplicarConsulta_Click(object sender, EventArgs e)
        {
            //comprobamos que consulta se ha seleccionado y la aplicamos
            conexion.Open();
            listBoxConsultorio.Items.Clear();
            string consultorioSeleccionado = ComboConsultorio.GetItemText(ComboConsultorio.SelectedItem);
            // lista los nombres de los productos ordenador en primer lugar por el nombre de forma ascendente y en segundo lugar por el precio de forma descendente
            if (consultorioSeleccionado == "Consulta 1")
            {
                string cadena = "SELECT nombre, precio FROM producto ORDER BY nombre ASC, precio DESC";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string nombre = registros["nombre"].ToString();
                    string precio = registros["precio"].ToString();
                    listBoxConsultorio.Items.Add(nombre + " - " + precio);
                }
            }

            // lista todos los productos que tengan un precio entre 60€ y 200€
            else if (consultorioSeleccionado == "Consulta 2")
            {
                string cadena = "SELECT nombre, precio FROM producto WHERE precio BETWEEN 60 AND 200";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string nombre = registros["nombre"].ToString();
                    string precio = registros["precio"].ToString();
                    listBoxConsultorio.Items.Add(nombre + " - " + precio);
                }
            }

            //Lista los nombres de los fabricantes cuyo nombre sea de 4 caracteres.
            else if (consultorioSeleccionado == "Consulta 3")
            {
                string cadena = "SELECT nombre FROM fabricante WHERE LEN(nombre) = 4";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string nombre = registros["nombre"].ToString();
                    listBoxConsultorio.Items.Add(nombre);
                }
            }

            //Devuelve una lista con el nombre del producto, precio y nombre de fabricante de todos los productos de la base de datos.

            else if (consultorioSeleccionado == "Consulta 4")
            {
                string cadena = "SELECT P.nombre, P.precio, F.nombre AS 'Nombre Fabricante' FROM producto P INNER JOIN fabricante F ON P.codigo_fabricante = F.codigo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string nombre = registros["nombre"].ToString();
                    string precio = registros["precio"].ToString();
                    string nombreFabricante = registros["Nombre Fabricante"].ToString();
                    listBoxConsultorio.Items.Add(nombre + " - " + precio + " - " + nombreFabricante);
                }
            }

            // Devuelve un listado con todos los productos de los fabricantes Asus, Hewlett - Packard y Seagate

            else if (consultorioSeleccionado == "Consulta 5")
            {
                string cadena = "SELECT P.nombre, F.nombre AS 'Nombre Fabricante' FROM producto P INNER JOIN fabricante F ON P.codigo_fabricante = F.codigo WHERE F.nombre = 'Asus' OR F.nombre = 'Hewlett-Packard' OR F.nombre = 'Seagate'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string nombre = registros["nombre"].ToString();
                    string nombreFabricante = registros["Nombre Fabricante"].ToString();
                    listBoxConsultorio.Items.Add(nombre + " - " + nombreFabricante);
                }
            }

            //Lista los nombres de los fabricantes ordenados de forma ascendente



            else if (consultorioSeleccionado == "Consulta 6")
            {
                string cadena = "SELECT nombre, codigo FROM fabricante ORDER BY nombre ASC";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string nombre = registros["nombre"].ToString();
                    string codigo = registros["codigo"].ToString();
                    listBoxConsultorio.Items.Add(nombre + " - " + codigo);
                }
            }

            //Calcula el número total de productos que hay en la tabla productos.

            else if (consultorioSeleccionado == "Consulta 7")
            {
                string cadena = "SELECT COUNT(*) AS 'Número de Productos' FROM producto";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string numeroProductos = registros["Número de Productos"].ToString();
                    listBoxConsultorio.Items.Add(numeroProductos);
                }
            }

            //Devuelve un listado con los nombres de los fabricantes donde la suma del precio de todos sus productos es superior a 1000 €.

            else if (consultorioSeleccionado == "Consulta 8")
            {
                string cadena = "SELECT F.nombre FROM fabricante F INNER JOIN producto P ON P.codigo_fabricante = F.codigo GROUP BY F.nombre HAVING SUM(P.precio) > 1000";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string nombreFabricante = registros["nombre"].ToString();
                    listBoxConsultorio.Items.Add(nombreFabricante);
                }
            }

            //Devuelve un listado donde sólo aparezcan aquellos fabricantes que no tienen ningún producto asociado.
            else if (consultorioSeleccionado == "Consulta 9")
            {
                string cadena = "SELECT F.nombre FROM fabricante F LEFT JOIN producto P ON P.codigo_fabricante = F.codigo WHERE P.codigo_fabricante IS NULL";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string nombreFabricante = registros["nombre"].ToString();
                    listBoxConsultorio.Items.Add(nombreFabricante);
                }
            }

            //Devuelve un listado con los nombres de los fabricantes y el número de
            //productos que tiene cada uno con un precio superior o igual a 220 €. El
            //listado debe mostrar el nombre de todos los fabricantes, es decir, si hay
            //algún fabricante que no tiene productos con un precio superior o igual a
            //220€ deberá aparecer en el listado con un valor igual a 0 en el número de
            //productos.

            else if (consultorioSeleccionado == "Consulta 10")
            {
                string cadena = "SELECT F.nombre, COUNT(P.precio) AS 'Número de Productos' FROM fabricante F LEFT JOIN producto P ON P.codigo_fabricante = F.codigo WHERE P.precio >= 220 GROUP BY F.nombre";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string nombreFabricante = registros["nombre"].ToString();
                    string numeroProductos = registros["Número de Productos"].ToString();
                    listBoxConsultorio.Items.Add(nombreFabricante + " - " + numeroProductos);
                }
            }

            conexion.Close();

        }
    }
}
