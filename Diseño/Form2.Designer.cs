
namespace Diseño
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.healthIcon_green = new System.Windows.Forms.PictureBox();
            this.healthIcon_red = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errorMessage = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barPassword = new System.Windows.Forms.Panel();
            this.barUser = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthIcon_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthIcon_red)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 164);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO DE SESIÓN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 379);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.healthIcon_green);
            this.panel3.Controls.Add(this.healthIcon_red);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(106, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 379);
            this.panel3.TabIndex = 3;
            // 
            // healthIcon_green
            // 
            this.healthIcon_green.Image = ((System.Drawing.Image)(resources.GetObject("healthIcon_green.Image")));
            this.healthIcon_green.Location = new System.Drawing.Point(342, 70);
            this.healthIcon_green.Name = "healthIcon_green";
            this.healthIcon_green.Size = new System.Drawing.Size(267, 270);
            this.healthIcon_green.TabIndex = 2;
            this.healthIcon_green.TabStop = false;
            // 
            // healthIcon_red
            // 
            this.healthIcon_red.Image = global::Diseño.Properties.Resources.health;
            this.healthIcon_red.Location = new System.Drawing.Point(342, 70);
            this.healthIcon_red.Name = "healthIcon_red";
            this.healthIcon_red.Size = new System.Drawing.Size(267, 270);
            this.healthIcon_red.TabIndex = 1;
            this.healthIcon_red.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.errorMessage);
            this.panel4.Controls.Add(this.btnRegistro);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.barPassword);
            this.panel4.Controls.Add(this.barUser);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Controls.Add(this.txtUser);
            this.panel4.Controls.Add(this.btnLogin);
            this.panel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(106, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 379);
            this.panel4.TabIndex = 4;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorMessage.Location = new System.Drawing.Point(60, 259);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(52, 19);
            this.errorMessage.TabIndex = 8;
            this.errorMessage.Text = "label2";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(123)))));
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(170, 330);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(112, 49);
            this.btnRegistro.TabIndex = 7;
            this.btnRegistro.Text = "REGISTRARSE";
            this.btnRegistro.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Diseño.Properties.Resources.Very_Basic_Lock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 15);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diseño.Properties.Resources.Users_User_Male_4_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 17);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // barPassword
            // 
            this.barPassword.BackColor = System.Drawing.Color.Red;
            this.barPassword.Location = new System.Drawing.Point(1, 233);
            this.barPassword.Name = "barPassword";
            this.barPassword.Size = new System.Drawing.Size(281, 2);
            this.barPassword.TabIndex = 4;
            // 
            // barUser
            // 
            this.barUser.BackColor = System.Drawing.Color.Red;
            this.barUser.Location = new System.Drawing.Point(0, 138);
            this.barUser.Name = "barUser";
            this.barUser.Size = new System.Drawing.Size(281, 2);
            this.barUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteCustomSource.AddRange(new string[] {
            "martin.pizarro@userena.cl"});
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(28, 214);
            this.txtPassword.MaxLength = 60;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(254, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(28, 120);
            this.txtUser.MaxLength = 60;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(254, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(123)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(0, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 49);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "INICIAR SESIÓN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 543);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "111";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.healthIcon_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthIcon_red)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel barUser;
        private System.Windows.Forms.Panel barPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.PictureBox healthIcon_red;
        private System.Windows.Forms.PictureBox healthIcon_green;
        private System.Windows.Forms.Label errorMessage;
    }
}