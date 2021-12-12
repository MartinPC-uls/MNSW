
namespace Diseño
{
    partial class F_Informacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Informacion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQueEs = new System.Windows.Forms.Button();
            this.btnRecomendaciones = new System.Windows.Forms.Button();
            this.btnCentrosDeAyuda = new System.Windows.Forms.Button();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.btnCreditos);
            this.panel2.Controls.Add(this.btnCentrosDeAyuda);
            this.panel2.Controls.Add(this.btnRecomendaciones);
            this.panel2.Controls.Add(this.btnQueEs);
            this.panel2.Location = new System.Drawing.Point(-2, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 372);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(150, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 362);
            this.panel1.TabIndex = 3;
            // 
            // btnQueEs
            // 
            this.btnQueEs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQueEs.FlatAppearance.BorderSize = 0;
            this.btnQueEs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueEs.ForeColor = System.Drawing.Color.White;
            this.btnQueEs.Location = new System.Drawing.Point(0, 0);
            this.btnQueEs.Name = "btnQueEs";
            this.btnQueEs.Size = new System.Drawing.Size(145, 38);
            this.btnQueEs.TabIndex = 8;
            this.btnQueEs.Text = "¿Qué es?";
            this.btnQueEs.UseVisualStyleBackColor = true;
            this.btnQueEs.Click += new System.EventHandler(this.btnQueEs_Click);
            // 
            // btnRecomendaciones
            // 
            this.btnRecomendaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecomendaciones.FlatAppearance.BorderSize = 0;
            this.btnRecomendaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecomendaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecomendaciones.ForeColor = System.Drawing.Color.White;
            this.btnRecomendaciones.Location = new System.Drawing.Point(0, 38);
            this.btnRecomendaciones.Name = "btnRecomendaciones";
            this.btnRecomendaciones.Size = new System.Drawing.Size(145, 38);
            this.btnRecomendaciones.TabIndex = 9;
            this.btnRecomendaciones.Text = "Recomendaciones";
            this.btnRecomendaciones.UseVisualStyleBackColor = true;
            this.btnRecomendaciones.Click += new System.EventHandler(this.btnRecomendaciones_Click);
            // 
            // btnCentrosDeAyuda
            // 
            this.btnCentrosDeAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCentrosDeAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCentrosDeAyuda.FlatAppearance.BorderSize = 0;
            this.btnCentrosDeAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentrosDeAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentrosDeAyuda.ForeColor = System.Drawing.Color.White;
            this.btnCentrosDeAyuda.Location = new System.Drawing.Point(0, 76);
            this.btnCentrosDeAyuda.Name = "btnCentrosDeAyuda";
            this.btnCentrosDeAyuda.Size = new System.Drawing.Size(145, 38);
            this.btnCentrosDeAyuda.TabIndex = 10;
            this.btnCentrosDeAyuda.Text = "Centros de ayuda";
            this.btnCentrosDeAyuda.UseVisualStyleBackColor = false;
            this.btnCentrosDeAyuda.Click += new System.EventHandler(this.btnCentrosDeAyuda_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreditos.FlatAppearance.BorderSize = 0;
            this.btnCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.ForeColor = System.Drawing.Color.White;
            this.btnCreditos.Location = new System.Drawing.Point(0, 114);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(145, 38);
            this.btnCreditos.TabIndex = 11;
            this.btnCreditos.Text = "Créditos";
            this.btnCreditos.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(4, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(620, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "¿Qué es?";
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(7, 43);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(617, 306);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = resources.GetString("lblTexto.Text");
            // 
            // F_Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Informacion";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.Button btnCentrosDeAyuda;
        private System.Windows.Forms.Button btnRecomendaciones;
        private System.Windows.Forms.Button btnQueEs;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTitulo;
    }
}