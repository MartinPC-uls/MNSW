
namespace Diseño
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapacidadIntelectual = new System.Windows.Forms.Button();
            this._p1 = new System.Windows.Forms.Panel();
            this.btnDatosNino = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.btnDatosNino);
            this.panel1.Controls.Add(this.btnCapacidadIntelectual);
            this.panel1.Controls.Add(this.btnInformacion);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 621);
            this.panel1.TabIndex = 0;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.Location = new System.Drawing.Point(0, 115);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(180, 38);
            this.btnInformacion.TabIndex = 2;
            this.btnInformacion.Text = "Información";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.BtnInformacion_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 38);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(186)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 59);
            this.panel2.TabIndex = 1;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btnCapacidadIntelectual
            // 
            this.btnCapacidadIntelectual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCapacidadIntelectual.FlatAppearance.BorderSize = 0;
            this.btnCapacidadIntelectual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapacidadIntelectual.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapacidadIntelectual.Location = new System.Drawing.Point(0, 153);
            this.btnCapacidadIntelectual.Name = "btnCapacidadIntelectual";
            this.btnCapacidadIntelectual.Size = new System.Drawing.Size(180, 38);
            this.btnCapacidadIntelectual.TabIndex = 3;
            this.btnCapacidadIntelectual.Text = "Capacidad Intelecual";
            this.btnCapacidadIntelectual.UseVisualStyleBackColor = true;
            this.btnCapacidadIntelectual.Click += new System.EventHandler(this.BtnCapacidadIntelectual_Click);
            // 
            // _p1
            // 
            this._p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._p1.Location = new System.Drawing.Point(180, 59);
            this._p1.Name = "_p1";
            this._p1.Size = new System.Drawing.Size(789, 562);
            this._p1.TabIndex = 2;
            // 
            // btnDatosNino
            // 
            this.btnDatosNino.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatosNino.FlatAppearance.BorderSize = 0;
            this.btnDatosNino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosNino.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosNino.Location = new System.Drawing.Point(0, 191);
            this.btnDatosNino.Name = "btnDatosNino";
            this.btnDatosNino.Size = new System.Drawing.Size(180, 38);
            this.btnDatosNino.TabIndex = 4;
            this.btnDatosNino.Text = "Datos del niño";
            this.btnDatosNino.UseVisualStyleBackColor = true;
            this.btnDatosNino.Click += new System.EventHandler(this.BtnDatosNino_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(969, 621);
            this.Controls.Add(this._p1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCapacidadIntelectual;
        private System.Windows.Forms.Panel _p1;
        private System.Windows.Forms.Button btnDatosNino;
    }
}

