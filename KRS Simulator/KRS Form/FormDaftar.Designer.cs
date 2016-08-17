namespace KRS_Form
{
    partial class FormDaftar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtKonPassword = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.txtIPSemester = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pendaftaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Konfirmasi Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Semester (1 - 8)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "IP Semester (0 - 4)";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(129, 71);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 20);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(129, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(170, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtKonPassword
            // 
            this.txtKonPassword.Location = new System.Drawing.Point(129, 132);
            this.txtKonPassword.Name = "txtKonPassword";
            this.txtKonPassword.PasswordChar = '●';
            this.txtKonPassword.Size = new System.Drawing.Size(170, 20);
            this.txtKonPassword.TabIndex = 8;
            this.txtKonPassword.TextChanged += new System.EventHandler(this.txtKonPassword_TextChanged);
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(129, 181);
            this.txtSemester.MaxLength = 1;
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(170, 20);
            this.txtSemester.TabIndex = 9;
            this.txtSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSemester_KeyPress);
            // 
            // txtIPSemester
            // 
            this.txtIPSemester.Location = new System.Drawing.Point(129, 213);
            this.txtIPSemester.MaxLength = 5;
            this.txtIPSemester.Name = "txtIPSemester";
            this.txtIPSemester.Size = new System.Drawing.Size(170, 20);
            this.txtIPSemester.TabIndex = 10;
            this.txtIPSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIPSemester_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sudah punya akun?";
            // 
            // btnDaftar
            // 
            this.btnDaftar.Location = new System.Drawing.Point(129, 252);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(75, 23);
            this.btnDaftar.TabIndex = 12;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(224, 252);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 13;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(221, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Silahkan Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 326);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 33);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 16;
            this.label8.UseMnemonic = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(301, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 24);
            this.label9.TabIndex = 17;
            this.label9.UseMnemonic = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(321, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 18;
            // 
            // FormDaftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 371);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIPSemester);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.txtKonPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDaftar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDaftar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtKonPassword;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.TextBox txtIPSemester;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}