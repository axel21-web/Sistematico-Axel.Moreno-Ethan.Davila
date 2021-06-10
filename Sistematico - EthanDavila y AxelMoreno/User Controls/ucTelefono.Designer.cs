
namespace Sistematico___EthanDavila_y_AxelMoreno.User_Controls
{
    partial class ucTelefono
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.LblID = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblNoExistencias = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImage
            // 
            this.PBImage.Location = new System.Drawing.Point(16, 12);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(258, 133);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBImage.TabIndex = 0;
            this.PBImage.TabStop = false;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(15, 153);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(24, 13);
            this.LblID.TabIndex = 1;
            this.LblID.Text = "ID: ";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(15, 177);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre: ";
            // 
            // LblNoExistencias
            // 
            this.LblNoExistencias.AutoSize = true;
            this.LblNoExistencias.Location = new System.Drawing.Point(15, 202);
            this.LblNoExistencias.Name = "LblNoExistencias";
            this.LblNoExistencias.Size = new System.Drawing.Size(101, 13);
            this.LblNoExistencias.TabIndex = 3;
            this.LblNoExistencias.Text = "No. de Existencias: ";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(15, 229);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(43, 13);
            this.LblMarca.TabIndex = 4;
            this.LblMarca.Text = "Marca: ";
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Location = new System.Drawing.Point(15, 254);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(48, 13);
            this.LblModelo.TabIndex = 5;
            this.LblModelo.Text = "Modelo: ";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(15, 280);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.LblDescripcion.TabIndex = 6;
            this.LblDescripcion.Text = "Descripción: ";
            // 
            // ucTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblModelo);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblNoExistencias);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.PBImage);
            this.Name = "ucTelefono";
            this.Size = new System.Drawing.Size(298, 310);
            this.Load += new System.EventHandler(this.ucTelefono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImage;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblNoExistencias;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Label LblDescripcion;
    }
}