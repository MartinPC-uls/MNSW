﻿namespace Diseño
{
    partial class PanelBienvenida
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
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.bienvenido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foto = new System.Windows.Forms.PictureBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.BackColor = System.Drawing.Color.Transparent;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(163, 183);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(472, 44);
            this.lblPresentacion.TabIndex = 3;
            this.lblPresentacion.Text = "Esta aplicación te permite recibir recomendaciones personalizadas sobre la educac" +
    "ión y el cuidado de su niño con sindrome de Down. ";
            this.lblPresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPresentacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // bienvenido
            // 
            this.bienvenido.AutoSize = true;
            this.bienvenido.BackColor = System.Drawing.Color.Transparent;
            this.bienvenido.CausesValidation = false;
            this.bienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenido.ForeColor = System.Drawing.Color.White;
            this.bienvenido.Location = new System.Drawing.Point(221, 48);
            this.bienvenido.Name = "bienvenido";
            this.bienvenido.Size = new System.Drawing.Size(362, 76);
            this.bienvenido.TabIndex = 4;
            this.bienvenido.Text = "Bienvenido";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Paso 1: Ingrese los datos físicos del niño";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 54);
            this.label2.TabIndex = 9;
            this.label2.Text = "Paso 2: El niño realiza el test de coeficiente intelectual";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 54);
            this.label3.TabIndex = 10;
            this.label3.Text = "Paso 3: Reciba recomendaciones en base a la condición del niño";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Diseño.Properties.Resources.recomendation;
            this.pictureBox3.Location = new System.Drawing.Point(582, 257);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Diseño.Properties.Resources.test;
            this.pictureBox2.Location = new System.Drawing.Point(337, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diseño.Properties.Resources.altura;
            this.pictureBox1.Location = new System.Drawing.Point(85, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // foto
            // 
            this.foto.Image = global::Diseño.Properties.Resources.image__1_;
            this.foto.Location = new System.Drawing.Point(-1, -5);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(802, 185);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto.TabIndex = 1;
            this.foto.TabStop = false;
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(223, 462);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(349, 28);
            this.btnComenzar.TabIndex = 11;
            this.btnComenzar.Text = "COMENZAR";
            this.btnComenzar.UseVisualStyleBackColor = true;
            // 
            // PanelBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 513);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bienvenido);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.foto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelBienvenida";
            this.Text = "PanelBienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label bienvenido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnComenzar;
    }
}