namespace Tarea2
{
    partial class tarea2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.process1 = new System.Diagnostics.Process();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.radioBtnFabricante = new System.Windows.Forms.RadioButton();
            this.radioBtnProducto = new System.Windows.Forms.RadioButton();
            this.textResultadoBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiarResultados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEjercicio1 = new System.Windows.Forms.Label();
            this.progressBarProductos = new System.Windows.Forms.ProgressBar();
            this.labelPrecioProductos = new System.Windows.Forms.Label();
            this.labelNombreProductos = new System.Windows.Forms.Label();
            this.textPrecioProductos = new System.Windows.Forms.TextBox();
            this.textNombreProductos = new System.Windows.Forms.TextBox();
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.progressBarFabricantes = new System.Windows.Forms.ProgressBar();
            this.labelNombreFabricantes = new System.Windows.Forms.Label();
            this.textNombreFabricantes = new System.Windows.Forms.TextBox();
            this.btnListaFabricantes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelEjercicio2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelEjercicio3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelFabricantes = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listBoxFabricantes = new System.Windows.Forms.ListBox();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.labelEjercicio4 = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelEjercicio5 = new System.Windows.Forms.Label();
            this.ComboConsultorio = new System.Windows.Forms.ComboBox();
            this.listBoxConsultorio = new System.Windows.Forms.ListBox();
            this.btnAplicarConsulta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(151, 57);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(233, 22);
            this.textBusqueda.TabIndex = 12;
            // 
            // radioBtnFabricante
            // 
            this.radioBtnFabricante.AutoSize = true;
            this.radioBtnFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnFabricante.Location = new System.Drawing.Point(393, 41);
            this.radioBtnFabricante.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnFabricante.Name = "radioBtnFabricante";
            this.radioBtnFabricante.Size = new System.Drawing.Size(124, 21);
            this.radioBtnFabricante.TabIndex = 13;
            this.radioBtnFabricante.TabStop = true;
            this.radioBtnFabricante.Text = "FABRICANTE";
            this.radioBtnFabricante.UseVisualStyleBackColor = true;
            this.radioBtnFabricante.CheckedChanged += new System.EventHandler(this.radioBtnFabricante_CheckedChanged);
            // 
            // radioBtnProducto
            // 
            this.radioBtnProducto.AutoSize = true;
            this.radioBtnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnProducto.Location = new System.Drawing.Point(393, 81);
            this.radioBtnProducto.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnProducto.Name = "radioBtnProducto";
            this.radioBtnProducto.Size = new System.Drawing.Size(116, 21);
            this.radioBtnProducto.TabIndex = 14;
            this.radioBtnProducto.TabStop = true;
            this.radioBtnProducto.Text = "PRODUCTO";
            this.radioBtnProducto.UseVisualStyleBackColor = true;
            this.radioBtnProducto.CheckedChanged += new System.EventHandler(this.radioBtnProducto_CheckedChanged);
            // 
            // textResultadoBusqueda
            // 
            this.textResultadoBusqueda.Location = new System.Drawing.Point(543, 14);
            this.textResultadoBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.textResultadoBusqueda.Multiline = true;
            this.textResultadoBusqueda.Name = "textResultadoBusqueda";
            this.textResultadoBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResultadoBusqueda.Size = new System.Drawing.Size(297, 114);
            this.textResultadoBusqueda.TabIndex = 15;
            // 
            // btnLimpiarResultados
            // 
            this.btnLimpiarResultados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarResultados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarResultados.Location = new System.Drawing.Point(544, 135);
            this.btnLimpiarResultados.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarResultados.Name = "btnLimpiarResultados";
            this.btnLimpiarResultados.Size = new System.Drawing.Size(299, 33);
            this.btnLimpiarResultados.TabIndex = 17;
            this.btnLimpiarResultados.Text = "LIMPIAR RESULTADOS";
            this.btnLimpiarResultados.UseVisualStyleBackColor = false;
            this.btnLimpiarResultados.Click += new System.EventHandler(this.btnLimpiarResultados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.labelEjercicio1);
            this.panel1.Controls.Add(this.progressBarProductos);
            this.panel1.Controls.Add(this.labelPrecioProductos);
            this.panel1.Controls.Add(this.labelNombreProductos);
            this.panel1.Controls.Add(this.textPrecioProductos);
            this.panel1.Controls.Add(this.textNombreProductos);
            this.panel1.Controls.Add(this.btnListarProductos);
            this.panel1.Location = new System.Drawing.Point(28, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 410);
            this.panel1.TabIndex = 18;
            // 
            // labelEjercicio1
            // 
            this.labelEjercicio1.AutoSize = true;
            this.labelEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjercicio1.Location = new System.Drawing.Point(33, 12);
            this.labelEjercicio1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEjercicio1.Name = "labelEjercicio1";
            this.labelEjercicio1.Size = new System.Drawing.Size(133, 24);
            this.labelEjercicio1.TabIndex = 12;
            this.labelEjercicio1.Text = "EJERCICIO 1";
            // 
            // progressBarProductos
            // 
            this.progressBarProductos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarProductos.Location = new System.Drawing.Point(37, 350);
            this.progressBarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarProductos.Name = "progressBarProductos";
            this.progressBarProductos.Size = new System.Drawing.Size(408, 31);
            this.progressBarProductos.TabIndex = 11;
            this.progressBarProductos.Visible = false;
            // 
            // labelPrecioProductos
            // 
            this.labelPrecioProductos.AutoSize = true;
            this.labelPrecioProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioProductos.Location = new System.Drawing.Point(327, 46);
            this.labelPrecioProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecioProductos.Name = "labelPrecioProductos";
            this.labelPrecioProductos.Size = new System.Drawing.Size(132, 17);
            this.labelPrecioProductos.TabIndex = 10;
            this.labelPrecioProductos.Text = "Precio Productos";
            // 
            // labelNombreProductos
            // 
            this.labelNombreProductos.AutoSize = true;
            this.labelNombreProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProductos.Location = new System.Drawing.Point(33, 46);
            this.labelNombreProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreProductos.Name = "labelNombreProductos";
            this.labelNombreProductos.Size = new System.Drawing.Size(151, 18);
            this.labelNombreProductos.TabIndex = 9;
            this.labelNombreProductos.Text = "Nombre Productos";
            this.labelNombreProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPrecioProductos
            // 
            this.textPrecioProductos.Cursor = System.Windows.Forms.Cursors.No;
            this.textPrecioProductos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textPrecioProductos.Location = new System.Drawing.Point(332, 68);
            this.textPrecioProductos.Margin = new System.Windows.Forms.Padding(4);
            this.textPrecioProductos.Multiline = true;
            this.textPrecioProductos.Name = "textPrecioProductos";
            this.textPrecioProductos.ReadOnly = true;
            this.textPrecioProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPrecioProductos.Size = new System.Drawing.Size(112, 222);
            this.textPrecioProductos.TabIndex = 8;
            // 
            // textNombreProductos
            // 
            this.textNombreProductos.Cursor = System.Windows.Forms.Cursors.No;
            this.textNombreProductos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textNombreProductos.Location = new System.Drawing.Point(37, 68);
            this.textNombreProductos.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreProductos.Multiline = true;
            this.textNombreProductos.Name = "textNombreProductos";
            this.textNombreProductos.ReadOnly = true;
            this.textNombreProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textNombreProductos.Size = new System.Drawing.Size(299, 222);
            this.textNombreProductos.TabIndex = 7;
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarProductos.Location = new System.Drawing.Point(37, 299);
            this.btnListarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(408, 43);
            this.btnListarProductos.TabIndex = 6;
            this.btnListarProductos.Text = "Lista Productos";
            this.btnListarProductos.UseVisualStyleBackColor = false;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // progressBarFabricantes
            // 
            this.progressBarFabricantes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarFabricantes.Location = new System.Drawing.Point(92, 350);
            this.progressBarFabricantes.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarFabricantes.Name = "progressBarFabricantes";
            this.progressBarFabricantes.Size = new System.Drawing.Size(299, 31);
            this.progressBarFabricantes.TabIndex = 22;
            this.progressBarFabricantes.Visible = false;
            // 
            // labelNombreFabricantes
            // 
            this.labelNombreFabricantes.AutoSize = true;
            this.labelNombreFabricantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreFabricantes.Location = new System.Drawing.Point(88, 46);
            this.labelNombreFabricantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreFabricantes.Name = "labelNombreFabricantes";
            this.labelNombreFabricantes.Size = new System.Drawing.Size(161, 18);
            this.labelNombreFabricantes.TabIndex = 21;
            this.labelNombreFabricantes.Text = "Nombre Fabricantes";
            this.labelNombreFabricantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNombreFabricantes
            // 
            this.textNombreFabricantes.Cursor = System.Windows.Forms.Cursors.No;
            this.textNombreFabricantes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreFabricantes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textNombreFabricantes.Location = new System.Drawing.Point(91, 65);
            this.textNombreFabricantes.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreFabricantes.Multiline = true;
            this.textNombreFabricantes.Name = "textNombreFabricantes";
            this.textNombreFabricantes.ReadOnly = true;
            this.textNombreFabricantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textNombreFabricantes.Size = new System.Drawing.Size(299, 224);
            this.textNombreFabricantes.TabIndex = 20;
            // 
            // btnListaFabricantes
            // 
            this.btnListaFabricantes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListaFabricantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaFabricantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListaFabricantes.Location = new System.Drawing.Point(91, 297);
            this.btnListaFabricantes.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaFabricantes.Name = "btnListaFabricantes";
            this.btnListaFabricantes.Size = new System.Drawing.Size(299, 46);
            this.btnListaFabricantes.TabIndex = 19;
            this.btnListaFabricantes.Text = "Lista Fabricantes";
            this.btnListaFabricantes.UseVisualStyleBackColor = false;
            this.btnListaFabricantes.Click += new System.EventHandler(this.btnListaFabricantes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.labelEjercicio2);
            this.panel2.Controls.Add(this.labelNombreFabricantes);
            this.panel2.Controls.Add(this.progressBarFabricantes);
            this.panel2.Controls.Add(this.btnListaFabricantes);
            this.panel2.Controls.Add(this.textNombreFabricantes);
            this.panel2.Location = new System.Drawing.Point(556, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 410);
            this.panel2.TabIndex = 19;
            // 
            // labelEjercicio2
            // 
            this.labelEjercicio2.AutoSize = true;
            this.labelEjercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjercicio2.Location = new System.Drawing.Point(27, 12);
            this.labelEjercicio2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEjercicio2.Name = "labelEjercicio2";
            this.labelEjercicio2.Size = new System.Drawing.Size(133, 24);
            this.labelEjercicio2.TabIndex = 13;
            this.labelEjercicio2.Text = "EJERCICIO 2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Controls.Add(this.labelEjercicio3);
            this.panel3.Controls.Add(this.textResultadoBusqueda);
            this.panel3.Controls.Add(this.textBusqueda);
            this.panel3.Controls.Add(this.btnLimpiarResultados);
            this.panel3.Controls.Add(this.radioBtnFabricante);
            this.panel3.Controls.Add(this.radioBtnProducto);
            this.panel3.Location = new System.Drawing.Point(28, 447);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 205);
            this.panel3.TabIndex = 19;
            // 
            // labelEjercicio3
            // 
            this.labelEjercicio3.AutoSize = true;
            this.labelEjercicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjercicio3.Location = new System.Drawing.Point(33, 12);
            this.labelEjercicio3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEjercicio3.Name = "labelEjercicio3";
            this.labelEjercicio3.Size = new System.Drawing.Size(133, 24);
            this.labelEjercicio3.TabIndex = 12;
            this.labelEjercicio3.Text = "EJERCICIO 3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SandyBrown;
            this.panel4.Controls.Add(this.labelFabricantes);
            this.panel4.Controls.Add(this.btnEliminar);
            this.panel4.Controls.Add(this.listBoxFabricantes);
            this.panel4.Controls.Add(this.listBoxProductos);
            this.panel4.Controls.Add(this.labelEjercicio4);
            this.panel4.Controls.Add(this.labelProductos);
            this.panel4.Controls.Add(this.btnListar);
            this.panel4.Location = new System.Drawing.Point(1082, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(643, 410);
            this.panel4.TabIndex = 23;
            // 
            // labelFabricantes
            // 
            this.labelFabricantes.AutoSize = true;
            this.labelFabricantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFabricantes.Location = new System.Drawing.Point(354, 47);
            this.labelFabricantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFabricantes.Name = "labelFabricantes";
            this.labelFabricantes.Size = new System.Drawing.Size(96, 18);
            this.labelFabricantes.TabIndex = 26;
            this.labelFabricantes.Text = "Fabricantes";
            this.labelFabricantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(248, 350);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 45);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listBoxFabricantes
            // 
            this.listBoxFabricantes.FormattingEnabled = true;
            this.listBoxFabricantes.ItemHeight = 16;
            this.listBoxFabricantes.Location = new System.Drawing.Point(357, 68);
            this.listBoxFabricantes.Name = "listBoxFabricantes";
            this.listBoxFabricantes.Size = new System.Drawing.Size(256, 212);
            this.listBoxFabricantes.TabIndex = 24;
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.ItemHeight = 16;
            this.listBoxProductos.Location = new System.Drawing.Point(43, 68);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(299, 212);
            this.listBoxProductos.TabIndex = 23;
            // 
            // labelEjercicio4
            // 
            this.labelEjercicio4.AutoSize = true;
            this.labelEjercicio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjercicio4.Location = new System.Drawing.Point(27, 12);
            this.labelEjercicio4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEjercicio4.Name = "labelEjercicio4";
            this.labelEjercicio4.Size = new System.Drawing.Size(133, 24);
            this.labelEjercicio4.TabIndex = 13;
            this.labelEjercicio4.Text = "EJERCICIO 4";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.Location = new System.Drawing.Point(40, 47);
            this.labelProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(86, 18);
            this.labelProductos.TabIndex = 21;
            this.labelProductos.Text = "Productos";
            this.labelProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListar.Location = new System.Drawing.Point(248, 297);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(190, 46);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SandyBrown;
            this.panel5.Controls.Add(this.btnAplicarConsulta);
            this.panel5.Controls.Add(this.listBoxConsultorio);
            this.panel5.Controls.Add(this.ComboConsultorio);
            this.panel5.Controls.Add(this.labelEjercicio5);
            this.panel5.Location = new System.Drawing.Point(1082, 447);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(643, 205);
            this.panel5.TabIndex = 20;
            // 
            // labelEjercicio5
            // 
            this.labelEjercicio5.AutoSize = true;
            this.labelEjercicio5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjercicio5.Location = new System.Drawing.Point(254, 0);
            this.labelEjercicio5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEjercicio5.Name = "labelEjercicio5";
            this.labelEjercicio5.Size = new System.Drawing.Size(133, 24);
            this.labelEjercicio5.TabIndex = 12;
            this.labelEjercicio5.Text = "EJERCICIO 5";
            // 
            // ComboConsultorio
            // 
            this.ComboConsultorio.FormattingEnabled = true;
            this.ComboConsultorio.Items.AddRange(new object[] {
            "Consulta 1",
            "Consulta 2",
            "Consulta 3",
            "Consulta 4",
            "Consulta 5",
            "Consulta 6",
            "Consulta 7",
            "Consulta 8",
            "Consulta 9",
            "Consulta 10"});
            this.ComboConsultorio.Location = new System.Drawing.Point(16, 27);
            this.ComboConsultorio.Name = "ComboConsultorio";
            this.ComboConsultorio.Size = new System.Drawing.Size(624, 24);
            this.ComboConsultorio.TabIndex = 13;
            // 
            // listBoxConsultorio
            // 
            this.listBoxConsultorio.FormattingEnabled = true;
            this.listBoxConsultorio.ItemHeight = 16;
            this.listBoxConsultorio.Location = new System.Drawing.Point(16, 81);
            this.listBoxConsultorio.Name = "listBoxConsultorio";
            this.listBoxConsultorio.Size = new System.Drawing.Size(624, 116);
            this.listBoxConsultorio.TabIndex = 27;
            // 
            // btnAplicarConsulta
            // 
            this.btnAplicarConsulta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAplicarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAplicarConsulta.Location = new System.Drawing.Point(16, 50);
            this.btnAplicarConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicarConsulta.Name = "btnAplicarConsulta";
            this.btnAplicarConsulta.Size = new System.Drawing.Size(623, 29);
            this.btnAplicarConsulta.TabIndex = 27;
            this.btnAplicarConsulta.Text = "Aplicar Consulta";
            this.btnAplicarConsulta.UseVisualStyleBackColor = false;
            this.btnAplicarConsulta.Click += new System.EventHandler(this.btnAplicarConsulta_Click);
            // 
            // tarea2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1754, 686);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tarea2";
            this.Text = "TAREA 2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TextBox textResultadoBusqueda;
        private System.Windows.Forms.RadioButton radioBtnProducto;
        private System.Windows.Forms.RadioButton radioBtnFabricante;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Button btnLimpiarResultados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelEjercicio2;
        private System.Windows.Forms.Label labelNombreFabricantes;
        private System.Windows.Forms.ProgressBar progressBarFabricantes;
        private System.Windows.Forms.Button btnListaFabricantes;
        private System.Windows.Forms.TextBox textNombreFabricantes;
        private System.Windows.Forms.Label labelEjercicio1;
        private System.Windows.Forms.ProgressBar progressBarProductos;
        private System.Windows.Forms.Label labelPrecioProductos;
        private System.Windows.Forms.Label labelNombreProductos;
        private System.Windows.Forms.TextBox textPrecioProductos;
        private System.Windows.Forms.TextBox textNombreProductos;
        private System.Windows.Forms.Button btnListarProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelEjercicio3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelEjercicio4;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox listBoxFabricantes;
        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.Label labelFabricantes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelEjercicio5;
        private System.Windows.Forms.ComboBox ComboConsultorio;
        private System.Windows.Forms.ListBox listBoxConsultorio;
        private System.Windows.Forms.Button btnAplicarConsulta;
    }
}

