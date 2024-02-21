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
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.textNombreProductos = new System.Windows.Forms.TextBox();
            this.textPrecioProductos = new System.Windows.Forms.TextBox();
            this.labelNombreProductos = new System.Windows.Forms.Label();
            this.labelPrecioProductos = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.progressBarProductos = new System.Windows.Forms.ProgressBar();
            this.progressBarFabricantes = new System.Windows.Forms.ProgressBar();
            this.labelNombreFabricantes = new System.Windows.Forms.Label();
            this.textNombreFabricantes = new System.Windows.Forms.TextBox();
            this.btnListaFabricantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarProductos.Location = new System.Drawing.Point(111, 234);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(306, 35);
            this.btnListarProductos.TabIndex = 0;
            this.btnListarProductos.Text = "Lista Productos";
            this.btnListarProductos.UseVisualStyleBackColor = false;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // textNombreProductos
            // 
            this.textNombreProductos.Cursor = System.Windows.Forms.Cursors.No;
            this.textNombreProductos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textNombreProductos.Location = new System.Drawing.Point(111, 46);
            this.textNombreProductos.Multiline = true;
            this.textNombreProductos.Name = "textNombreProductos";
            this.textNombreProductos.ReadOnly = true;
            this.textNombreProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textNombreProductos.Size = new System.Drawing.Size(225, 181);
            this.textNombreProductos.TabIndex = 1;
            // 
            // textPrecioProductos
            // 
            this.textPrecioProductos.Cursor = System.Windows.Forms.Cursors.No;
            this.textPrecioProductos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textPrecioProductos.Location = new System.Drawing.Point(332, 46);
            this.textPrecioProductos.Multiline = true;
            this.textPrecioProductos.Name = "textPrecioProductos";
            this.textPrecioProductos.ReadOnly = true;
            this.textPrecioProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPrecioProductos.Size = new System.Drawing.Size(85, 181);
            this.textPrecioProductos.TabIndex = 2;
            // 
            // labelNombreProductos
            // 
            this.labelNombreProductos.AutoSize = true;
            this.labelNombreProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProductos.Location = new System.Drawing.Point(108, 28);
            this.labelNombreProductos.Name = "labelNombreProductos";
            this.labelNombreProductos.Size = new System.Drawing.Size(126, 15);
            this.labelNombreProductos.TabIndex = 3;
            this.labelNombreProductos.Text = "Nombre Productos";
            this.labelNombreProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrecioProductos
            // 
            this.labelPrecioProductos.AutoSize = true;
            this.labelPrecioProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioProductos.Location = new System.Drawing.Point(328, 28);
            this.labelPrecioProductos.Name = "labelPrecioProductos";
            this.labelPrecioProductos.Size = new System.Drawing.Size(104, 13);
            this.labelPrecioProductos.TabIndex = 4;
            this.labelPrecioProductos.Text = "Precio Productos";
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
            // progressBarProductos
            // 
            this.progressBarProductos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarProductos.Location = new System.Drawing.Point(111, 275);
            this.progressBarProductos.Name = "progressBarProductos";
            this.progressBarProductos.Size = new System.Drawing.Size(306, 25);
            this.progressBarProductos.TabIndex = 5;
            this.progressBarProductos.Visible = false;
            // 
            // progressBarFabricantes
            // 
            this.progressBarFabricantes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarFabricantes.Location = new System.Drawing.Point(454, 275);
            this.progressBarFabricantes.Name = "progressBarFabricantes";
            this.progressBarFabricantes.Size = new System.Drawing.Size(224, 25);
            this.progressBarFabricantes.TabIndex = 11;
            this.progressBarFabricantes.Visible = false;
            // 
            // labelNombreFabricantes
            // 
            this.labelNombreFabricantes.AutoSize = true;
            this.labelNombreFabricantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreFabricantes.Location = new System.Drawing.Point(452, 28);
            this.labelNombreFabricantes.Name = "labelNombreFabricantes";
            this.labelNombreFabricantes.Size = new System.Drawing.Size(137, 15);
            this.labelNombreFabricantes.TabIndex = 9;
            this.labelNombreFabricantes.Text = "Nombre Fabricantes";
            this.labelNombreFabricantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNombreFabricantes
            // 
            this.textNombreFabricantes.Cursor = System.Windows.Forms.Cursors.No;
            this.textNombreFabricantes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreFabricantes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textNombreFabricantes.Location = new System.Drawing.Point(454, 46);
            this.textNombreFabricantes.Multiline = true;
            this.textNombreFabricantes.Name = "textNombreFabricantes";
            this.textNombreFabricantes.ReadOnly = true;
            this.textNombreFabricantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textNombreFabricantes.Size = new System.Drawing.Size(225, 181);
            this.textNombreFabricantes.TabIndex = 7;
            // 
            // btnListaFabricantes
            // 
            this.btnListaFabricantes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListaFabricantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaFabricantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListaFabricantes.Location = new System.Drawing.Point(454, 234);
            this.btnListaFabricantes.Name = "btnListaFabricantes";
            this.btnListaFabricantes.Size = new System.Drawing.Size(224, 35);
            this.btnListaFabricantes.TabIndex = 6;
            this.btnListaFabricantes.Text = "Lista Fabricantes";
            this.btnListaFabricantes.UseVisualStyleBackColor = false;
            this.btnListaFabricantes.Click += new System.EventHandler(this.btnListaFabricantes_Click);
            // 
            // tarea2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarFabricantes);
            this.Controls.Add(this.labelNombreFabricantes);
            this.Controls.Add(this.textNombreFabricantes);
            this.Controls.Add(this.btnListaFabricantes);
            this.Controls.Add(this.progressBarProductos);
            this.Controls.Add(this.labelPrecioProductos);
            this.Controls.Add(this.labelNombreProductos);
            this.Controls.Add(this.textPrecioProductos);
            this.Controls.Add(this.textNombreProductos);
            this.Controls.Add(this.btnListarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "tarea2";
            this.Text = "TAREA 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarProductos;
        private System.Windows.Forms.TextBox textNombreProductos;
        private System.Windows.Forms.TextBox textPrecioProductos;
        private System.Windows.Forms.Label labelNombreProductos;
        private System.Windows.Forms.Label labelPrecioProductos;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ProgressBar progressBarProductos;
        private System.Windows.Forms.ProgressBar progressBarFabricantes;
        private System.Windows.Forms.Label labelNombreFabricantes;
        private System.Windows.Forms.TextBox textNombreFabricantes;
        private System.Windows.Forms.Button btnListaFabricantes;
    }
}

