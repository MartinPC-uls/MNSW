
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
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.panel_pregunta = new System.Windows.Forms.Panel();
            this.d = new System.Windows.Forms.CheckBox();
            this.c = new System.Windows.Forms.CheckBox();
            this.b = new System.Windows.Forms.CheckBox();
            this.a = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_pregunta = new System.Windows.Forms.Label();
            this.panel_control2 = new System.Windows.Forms.Panel();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.lblPreguntasRespondidas = new System.Windows.Forms.Label();
            this.panel_control.SuspendLayout();
            this.panel_pregunta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_control2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.lblPreguntasRespondidas);
            this.panel_control.Controls.Add(this.lblPreguntas);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(773, 132);
            this.panel_control.TabIndex = 0;
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
            // panel_pregunta
            // 
            this.panel_pregunta.Controls.Add(this.d);
            this.panel_pregunta.Controls.Add(this.c);
            this.panel_pregunta.Controls.Add(this.b);
            this.panel_pregunta.Controls.Add(this.a);
            this.panel_pregunta.Controls.Add(this.pictureBox1);
            this.panel_pregunta.Controls.Add(this.label_pregunta);
            this.panel_pregunta.Controls.Add(this.panel_control2);
            this.panel_pregunta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pregunta.Location = new System.Drawing.Point(0, 132);
            this.panel_pregunta.Name = "panel_pregunta";
            this.panel_pregunta.Size = new System.Drawing.Size(773, 391);
            this.panel_pregunta.TabIndex = 1;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(319, 165);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(32, 17);
            this.d.TabIndex = 6;
            this.d.Text = "d";
            this.d.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(319, 142);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(32, 17);
            this.c.TabIndex = 5;
            this.c.Text = "c";
            this.c.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(319, 119);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(32, 17);
            this.b.TabIndex = 4;
            this.b.Text = "b";
            this.b.UseVisualStyleBackColor = true;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(319, 96);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(32, 17);
            this.a.TabIndex = 3;
            this.a.Text = "a";
            this.a.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 167);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_pregunta
            // 
            this.label_pregunta.Font = new System.Drawing.Font("Roboto Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pregunta.Location = new System.Drawing.Point(24, 15);
            this.label_pregunta.Name = "label_pregunta";
            this.label_pregunta.Size = new System.Drawing.Size(685, 39);
            this.label_pregunta.TabIndex = 1;
            this.label_pregunta.Text = "¿Aquí va la pregunta?";
            // 
            // panel_control2
            // 
            this.panel_control2.Controls.Add(this.btnAvanzar);
            this.panel_control2.Controls.Add(this.btnRetroceder);
            this.panel_control2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_control2.Location = new System.Drawing.Point(0, 291);
            this.panel_control2.Name = "panel_control2";
            this.panel_control2.Size = new System.Drawing.Size(773, 100);
            this.panel_control2.TabIndex = 0;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(659, 45);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzar.TabIndex = 1;
            this.btnAvanzar.Text = ">";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(40, 45);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(75, 23);
            this.btnRetroceder.TabIndex = 0;
            this.btnRetroceder.Text = "<";
            this.btnRetroceder.UseVisualStyleBackColor = true;
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
            // F_TestCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(773, 523);
            this.Controls.Add(this.panel_pregunta);
            this.Controls.Add(this.panel_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_TestCI";
            this.Text = "Form3";
            this.panel_control.ResumeLayout(false);
            this.panel_pregunta.ResumeLayout(false);
            this.panel_pregunta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_control2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Panel panel_pregunta;
        private System.Windows.Forms.CheckBox b;
        private System.Windows.Forms.CheckBox a;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_pregunta;
        private System.Windows.Forms.Panel panel_control2;
        private System.Windows.Forms.CheckBox d;
        private System.Windows.Forms.CheckBox c;
        private System.Windows.Forms.Label lblPreguntas;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Label lblPreguntasRespondidas;
    }
}