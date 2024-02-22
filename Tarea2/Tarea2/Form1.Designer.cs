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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.textBusqueda.Location = new System.Drawing.Point(113, 46);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(176, 20);
            this.textBusqueda.TabIndex = 12;
            // 
            // radioBtnFabricante
            // 
            this.radioBtnFabricante.AutoSize = true;
            this.radioBtnFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnFabricante.Location = new System.Drawing.Point(295, 33);
            this.radioBtnFabricante.Name = "radioBtnFabricante";
            this.radioBtnFabricante.Size = new System.Drawing.Size(102, 17);
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
            this.radioBtnProducto.Location = new System.Drawing.Point(295, 66);
            this.radioBtnProducto.Name = "radioBtnProducto";
            this.radioBtnProducto.Size = new System.Drawing.Size(94, 17);
            this.radioBtnProducto.TabIndex = 14;
            this.radioBtnProducto.TabStop = true;
            this.radioBtnProducto.Text = "PRODUCTO";
            this.radioBtnProducto.UseVisualStyleBackColor = true;
            this.radioBtnProducto.CheckedChanged += new System.EventHandler(this.radioBtnProducto_CheckedChanged);
            // 
            // textResultadoBusqueda
            // 
            this.textResultadoBusqueda.Location = new System.Drawing.Point(407, 11);
            this.textResultadoBusqueda.Multiline = true;
            this.textResultadoBusqueda.Name = "textResultadoBusqueda";
            this.textResultadoBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResultadoBusqueda.Size = new System.Drawing.Size(224, 93);
            this.textResultadoBusqueda.TabIndex = 15;
            // 
            // btnLimpiarResultados
            // 
            this.btnLimpiarResultados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarResultados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarResultados.Location = new System.Drawing.Point(408, 110);
            this.btnLimpiarResultados.Name = "btnLimpiarResultados";
            this.btnLimpiarResultados.Size = new System.Drawing.Size(224, 27);
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
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 333);
            this.panel1.TabIndex = 18;
            // 
            // labelEjercicio1
            // 
            this.labelEjercicio1.AutoSize = true;
            this.labelEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjercicio1.Location = new System.Drawing.Point(25, 10);
            this.labelEjercicio1.Name = "labelEjercicio1";
            this.labelEjercicio1.Size = new System.Drawing.Size(110, 18);
            this.labelEjercicio1.TabIndex = 12;
            this.labelEjercicio1.Text = "EJERCICIO 1";
            // 
            // progressBarProductos
            // 
            this.progressBarProductos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarProductos.Location = new System.Drawing.Point(28, 284);
            this.progressBarProductos.Name = "progressBarProductos";
            this.progressBarProductos.Size = new System.Drawing.Size(306, 25);
            this.progressBarProductos.TabIndex = 11;
            this.progressBarProductos.Visible = false;
            // 
            // labelPrecioProductos
            // 
            this.labelPrecioProductos.AutoSize = true;
            this.labelPrecioProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioProductos.Location = new System.Drawing.Point(245, 37);
            this.labelPrecioProductos.Name = "labelPrecioProductos";
            this.labelPrecioProductos.Size = new System.Drawing.Size(104, 13);
            this.labelPrecioProductos.TabIndex = 10;
            this.labelPrecioProductos.Text = "Precio Productos";
            // 
            // labelNombreProductos
            // 
            this.labelNombreProductos.AutoSize = true;
            this.labelNombreProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProductos.Location = new System.Drawing.Point(25, 37);
            this.labelNombreProductos.Name = "labelNombreProductos";
            this.labelNombreProductos.Size = new System.Drawing.Size(126, 15);
            this.labelNombreProductos.TabIndex = 9;
            this.labelNombreProductos.Text = "Nombre Productos";
            this.labelNombreProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPrecioProductos
            // 
            this.textPrecioProductos.Cursor = System.Windows.Forms.Cursors.No;
            this.textPrecioProductos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textPrecioProductos.Location = new System.Drawing.Point(249, 55);
            this.textPrecioProductos.Multiline = true;
            this.textPrecioProductos.Name = "textPrecioProductos";
            this.textPrecioProductos.ReadOnly = true;
            this.textPrecioProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPrecioProductos.Size = new System.Drawing.Size(85, 181);
            this.textPrecioProductos.TabIndex = 8;
            // 
            // textNombreProductos
            // 
            this.textNombreProductos.Cursor = System.Windows.Forms.Cursors.No;
            this.textNombreProductos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textNombreProductos.Location = new System.Drawing.Point(28, 55);
            this.textNombreProductos.Multiline = true;
            this.textNombreProductos.Name = "textNombreProductos";
            this.textNombreProductos.ReadOnly = true;
            this.textNombreProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textNombreProductos.Size = new System.Drawing.Size(225, 181);
            this.textNombreProductos.TabIndex = 7;
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarProductos.Location = new System.Drawing.Point(28, 243);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(306, 35);
            this.btnListarProductos.TabIndex = 6;
            this.btnListarProductos.Text = "Lista Productos";
            this.btnListarProductos.UseVisualStyleBackColor = false;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // progressBarFabricantes
            // 
            this.progressBarFabricantes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarFabricantes.Location = new System.Drawing.Point(69, 284);
            this.progressBarFabricantes.Name = "progressBarFabricantes";
            this.progressBarFabricantes.Size = new System.Drawing.Size(224, 25);
            this.progressBarFabricantes.TabIndex = 22;
            this.progressBarFabricantes.Visible = false;
            // 
            // labelNombreFabricantes
            // 
            this.labelNombreFabricantes.AutoSize = true;
            this.labelNombreFabricantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreFabricantes.Location = new System.Drawing.Point(66, 37);
            this.labelNombreFabricantes.Name = "labelNombreFabricantes";
            this.labelNombreFabricantes.Size = new System.Drawing.Size(137, 15);
            this.labelNombreFabricantes.TabIndex = 21;
            this.labelNombreFabricantes.Text = "Nombre Fabricantes";
            this.labelNombreFabricantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNombreFabricantes
            // 
            this.textNombreFabricantes.Cursor = System.Windows.Forms.Cursors.No;
            this.textNombreFabricantes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreFabricantes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textNombreFabricantes.Location = new System.Drawing.Point(68, 53);
            this.textNombreFabricantes.Multiline = true;
            this.textNombreFabricantes.Name = "textNombreFabricantes";
            this.textNombreFabricantes.ReadOnly = true;
            this.textNombreFabricantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textNombreFabricantes.Size = new System.Drawing.Size(225, 183);
            this.textNombreFabricantes.TabIndex = 20;
            // 
            // btnListaFabricantes
            // 
            this.btnListaFabricantes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListaFabricantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaFabricantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListaFabricantes.Location = new System.Drawing.Point(68, 241);
            this.btnListaFabricantes.Name = "btnListaFabricantes";
            this.btnListaFabricantes.Size = new System.Drawing.Size(224, 37);
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
            this.panel2.Location = new System.Drawing.Point(417, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 333);
            this.panel2.TabIndex = 19;
            // 
            // labelEjercicio2
            // 
            this.labelEjercicio2.AutoSize = true;
            this.labelEjercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjercicio2.Location = new System.Drawing.Point(20, 10);
            this.labelEjercicio2.Name = "labelEjercicio2";
            this.labelEjercicio2.Size = new System.Drawing.Size(110, 18);
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
            this.panel3.Location = new System.Drawing.Point(21, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 145);
            this.panel3.TabIndex = 19;
            // 
            // labelEjercicio3
            // 
            this.labelEjercicio3.AutoSize = true;
            this.labelEjercicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjercicio3.Location = new System.Drawing.Point(25, 10);
            this.labelEjercicio3.Name = "labelEjercicio3";
            this.labelEjercicio3.Size = new System.Drawing.Size(110, 18);
            this.labelEjercicio3.TabIndex = 12;
            this.labelEjercicio3.Text = "EJERCICIO 3";
            // 
            // tarea2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(803, 745);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "tarea2";
            this.Text = "TAREA 2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
    }
}

