
namespace Diseño
{
    partial class F_InfoBienvenida
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Roboto Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(12, 24);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(777, 167);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenidx (NOMBRE)";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTexto1
            // 
            this.lblTexto1.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto1.Location = new System.Drawing.Point(21, 327);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(251, 177);
            this.lblTexto1.TabIndex = 1;
            this.lblTexto1.Text = "¡Podrás monitorear el desarrollo del niño y recibir recomendaciones semanalmente!" +
    "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 153);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podrás realizar tests de coeficiente intelectual, consultar en caso de posibles e" +
    "nfermedades y seguir una guía de progreso en caso de que tengas dudas.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 177);
            this.label2.TabIndex = 3;
            this.label2.Text = "¡No permitas que la salud de tu hijo empeore sin que te des cuenta!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Monitorea";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // F_InfoBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.lblBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_InfoBienvenida";
            this.Text = "F_InfoBienvenida";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}