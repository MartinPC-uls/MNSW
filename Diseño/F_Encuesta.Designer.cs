
namespace Diseño
{
    partial class F_Encuesta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.lblSintoma1 = new System.Windows.Forms.Label();
            this.lblSintoma2 = new System.Windows.Forms.Label();
            this.lblSintoma3 = new System.Windows.Forms.Label();
            this.lblSintoma4 = new System.Windows.Forms.Label();
            this.cbSintoma1 = new System.Windows.Forms.ComboBox();
            this.cbSintoma2 = new System.Windows.Forms.ComboBox();
            this.cbSintoma3 = new System.Windows.Forms.ComboBox();
            this.cbSintoma4 = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(50, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(497, 43);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consulte al sistema";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(12, 110);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(777, 94);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "En caso que (NOMBRE) presente algunos sintomas, puede especificar cuales son (has" +
    "ta un máximo de 4 síntomas)";
            // 
            // lblSintoma1
            // 
            this.lblSintoma1.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintoma1.Location = new System.Drawing.Point(12, 209);
            this.lblSintoma1.Name = "lblSintoma1";
            this.lblSintoma1.Size = new System.Drawing.Size(117, 28);
            this.lblSintoma1.TabIndex = 2;
            this.lblSintoma1.Text = "Síntoma 1";
            // 
            // lblSintoma2
            // 
            this.lblSintoma2.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintoma2.Location = new System.Drawing.Point(12, 256);
            this.lblSintoma2.Name = "lblSintoma2";
            this.lblSintoma2.Size = new System.Drawing.Size(117, 28);
            this.lblSintoma2.TabIndex = 3;
            this.lblSintoma2.Text = "Síntoma 2";
            this.lblSintoma2.Visible = false;
            // 
            // lblSintoma3
            // 
            this.lblSintoma3.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintoma3.Location = new System.Drawing.Point(12, 303);
            this.lblSintoma3.Name = "lblSintoma3";
            this.lblSintoma3.Size = new System.Drawing.Size(117, 28);
            this.lblSintoma3.TabIndex = 4;
            this.lblSintoma3.Text = "Síntoma 3";
            this.lblSintoma3.Visible = false;
            // 
            // lblSintoma4
            // 
            this.lblSintoma4.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintoma4.Location = new System.Drawing.Point(12, 350);
            this.lblSintoma4.Name = "lblSintoma4";
            this.lblSintoma4.Size = new System.Drawing.Size(117, 28);
            this.lblSintoma4.TabIndex = 5;
            this.lblSintoma4.Text = "Síntoma 4";
            this.lblSintoma4.Visible = false;
            // 
            // cbSintoma1
            // 
            this.cbSintoma1.FormattingEnabled = true;
            this.cbSintoma1.Location = new System.Drawing.Point(146, 216);
            this.cbSintoma1.Name = "cbSintoma1";
            this.cbSintoma1.Size = new System.Drawing.Size(121, 21);
            this.cbSintoma1.TabIndex = 6;
            this.cbSintoma1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // cbSintoma2
            // 
            this.cbSintoma2.FormattingEnabled = true;
            this.cbSintoma2.Location = new System.Drawing.Point(146, 263);
            this.cbSintoma2.Name = "cbSintoma2";
            this.cbSintoma2.Size = new System.Drawing.Size(121, 21);
            this.cbSintoma2.TabIndex = 7;
            this.cbSintoma2.Visible = false;
            this.cbSintoma2.SelectionChangeCommitted += new System.EventHandler(this.cbSintoma2_SelectionChangeCommitted);
            // 
            // cbSintoma3
            // 
            this.cbSintoma3.FormattingEnabled = true;
            this.cbSintoma3.Location = new System.Drawing.Point(146, 310);
            this.cbSintoma3.Name = "cbSintoma3";
            this.cbSintoma3.Size = new System.Drawing.Size(121, 21);
            this.cbSintoma3.TabIndex = 8;
            this.cbSintoma3.Visible = false;
            this.cbSintoma3.SelectionChangeCommitted += new System.EventHandler(this.cbSintoma3_SelectionChangeCommitted);
            // 
            // cbSintoma4
            // 
            this.cbSintoma4.FormattingEnabled = true;
            this.cbSintoma4.Location = new System.Drawing.Point(146, 357);
            this.cbSintoma4.Name = "cbSintoma4";
            this.cbSintoma4.Size = new System.Drawing.Size(121, 21);
            this.cbSintoma4.TabIndex = 9;
            this.cbSintoma4.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(495, 409);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(168, 63);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // F_Encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 513);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbSintoma4);
            this.Controls.Add(this.cbSintoma3);
            this.Controls.Add(this.cbSintoma2);
            this.Controls.Add(this.cbSintoma1);
            this.Controls.Add(this.lblSintoma4);
            this.Controls.Add(this.lblSintoma3);
            this.Controls.Add(this.lblSintoma2);
            this.Controls.Add(this.lblSintoma1);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Encuesta";
            this.Text = "F_Encuesta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label lblSintoma1;
        private System.Windows.Forms.Label lblSintoma2;
        private System.Windows.Forms.Label lblSintoma3;
        private System.Windows.Forms.Label lblSintoma4;
        private System.Windows.Forms.ComboBox cbSintoma1;
        private System.Windows.Forms.ComboBox cbSintoma2;
        private System.Windows.Forms.ComboBox cbSintoma3;
        private System.Windows.Forms.ComboBox cbSintoma4;
        private System.Windows.Forms.Button btnConsultar;
    }
}