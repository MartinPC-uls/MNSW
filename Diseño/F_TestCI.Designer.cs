
namespace Diseño
{
    partial class F_TestCI
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
            this.panel_control = new System.Windows.Forms.Panel();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblPreguntasRespondidas = new System.Windows.Forms.Label();
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.gbAlternativas = new System.Windows.Forms.GroupBox();
            this.h = new System.Windows.Forms.RadioButton();
            this.g = new System.Windows.Forms.RadioButton();
            this.f = new System.Windows.Forms.RadioButton();
            this.e = new System.Windows.Forms.RadioButton();
            this.d = new System.Windows.Forms.RadioButton();
            this.c = new System.Windows.Forms.RadioButton();
            this.b = new System.Windows.Forms.RadioButton();
            this.a = new System.Windows.Forms.RadioButton();
            this.panel_control.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.gbAlternativas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.btnTerminar);
            this.panel_control.Controls.Add(this.btnAnterior);
            this.panel_control.Controls.Add(this.btnSiguiente);
            this.panel_control.Controls.Add(this.lblPreguntasRespondidas);
            this.panel_control.Controls.Add(this.lblPreguntas);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(773, 132);
            this.panel_control.TabIndex = 0;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(336, 29);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(82, 23);
            this.btnTerminar.TabIndex = 5;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(181, 103);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(486, 103);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblPreguntasRespondidas
            // 
            this.lblPreguntasRespondidas.Font = new System.Drawing.Font("Roboto Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntasRespondidas.Location = new System.Drawing.Point(512, 29);
            this.lblPreguntasRespondidas.Name = "lblPreguntasRespondidas";
            this.lblPreguntasRespondidas.Size = new System.Drawing.Size(222, 39);
            this.lblPreguntasRespondidas.TabIndex = 3;
            this.lblPreguntasRespondidas.Text = "Respondidas: 0";
            // 
            // lblPreguntas
            // 
            this.lblPreguntas.Font = new System.Drawing.Font("Roboto Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntas.Location = new System.Drawing.Point(34, 29);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(303, 39);
            this.lblPreguntas.TabIndex = 2;
            this.lblPreguntas.Text = "Preguntas: 0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPregunta);
            this.panel1.Controls.Add(this.pbImagen);
            this.panel1.Controls.Add(this.gbAlternativas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 388);
            this.panel1.TabIndex = 2;
            // 
            // lblPregunta
            // 
            this.lblPregunta.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(40, 27);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(675, 57);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = "label1";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(40, 87);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(294, 268);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // gbAlternativas
            // 
            this.gbAlternativas.Controls.Add(this.h);
            this.gbAlternativas.Controls.Add(this.g);
            this.gbAlternativas.Controls.Add(this.f);
            this.gbAlternativas.Controls.Add(this.e);
            this.gbAlternativas.Controls.Add(this.d);
            this.gbAlternativas.Controls.Add(this.c);
            this.gbAlternativas.Controls.Add(this.b);
            this.gbAlternativas.Controls.Add(this.a);
            this.gbAlternativas.Location = new System.Drawing.Point(462, 146);
            this.gbAlternativas.Name = "gbAlternativas";
            this.gbAlternativas.Size = new System.Drawing.Size(232, 233);
            this.gbAlternativas.TabIndex = 0;
            this.gbAlternativas.TabStop = false;
            this.gbAlternativas.Text = "alternativas";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Location = new System.Drawing.Point(6, 192);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(31, 17);
            this.h.TabIndex = 7;
            this.h.TabStop = true;
            this.h.Text = "h";
            this.h.UseVisualStyleBackColor = true;
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(6, 169);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(31, 17);
            this.g.TabIndex = 6;
            this.g.TabStop = true;
            this.g.Text = "g";
            this.g.UseVisualStyleBackColor = true;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(6, 146);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(28, 17);
            this.f.TabIndex = 5;
            this.f.TabStop = true;
            this.f.Text = "f";
            this.f.UseVisualStyleBackColor = true;
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(6, 123);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(31, 17);
            this.e.TabIndex = 4;
            this.e.TabStop = true;
            this.e.Text = "e";
            this.e.UseVisualStyleBackColor = true;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(6, 100);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(31, 17);
            this.d.TabIndex = 3;
            this.d.TabStop = true;
            this.d.Text = "d";
            this.d.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(6, 77);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(31, 17);
            this.c.TabIndex = 2;
            this.c.TabStop = true;
            this.c.Text = "c";
            this.c.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(6, 54);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(31, 17);
            this.b.TabIndex = 1;
            this.b.TabStop = true;
            this.b.Text = "b";
            this.b.UseVisualStyleBackColor = true;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(6, 31);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(31, 17);
            this.a.TabIndex = 0;
            this.a.TabStop = true;
            this.a.Text = "a";
            this.a.UseVisualStyleBackColor = true;
            // 
            // F_TestCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(773, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_TestCI";
            this.Text = "Form3";
            this.panel_control.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.gbAlternativas.ResumeLayout(false);
            this.gbAlternativas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Label lblPreguntas;
        private System.Windows.Forms.Label lblPreguntasRespondidas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.GroupBox gbAlternativas;
        private System.Windows.Forms.RadioButton h;
        private System.Windows.Forms.RadioButton g;
        private System.Windows.Forms.RadioButton f;
        private System.Windows.Forms.RadioButton e;
        private System.Windows.Forms.RadioButton d;
        private System.Windows.Forms.RadioButton c;
        private System.Windows.Forms.RadioButton b;
        private System.Windows.Forms.RadioButton a;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnTerminar;
    }
}