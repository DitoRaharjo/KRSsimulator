using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace KRS_Form
{
    public partial class FormLogin : Form
    {
        FormUtama fu = new FormUtama();
        MySqlDataAdapter mda;
        MySqlCommand mcd;
        MySqlConnection mcon = new MySqlConnection("SERVER=localhost;DATABASE=simulatorkrs;UID=root;PWD=;");


        SQLbased sb = new SQLbased();

        //string connectionString = "SERVER=http://himaforka-uajy.org;DATABASE=himafork_app;UID=himafork_ditorah;PWD=dito161;";

        //SQLbased sbclass = new SQLbased();

        public FormLogin()
        {
            InitializeComponent();

            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mcon.Open();
                if (mcon.State == ConnectionState.Open)
                {
                    MessageBox.Show("Koneksi Berhasil");
                }
                else
                {
                    MessageBox.Show("Koneksi Gagal");
                }
                mcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                mcon.Open();
                string username1 = "";
                string password1 = "";
                string username2 = "";
                string password2 = "";

                //Ambil data username-password berdasarkan inputan username
                string command1 = "select username,password from simulatorkrs.user where username='" + txtUsername.Text + "' ";
                mcd = new MySqlCommand(command1, mcon);
                MySqlDataReader mdr = mcd.ExecuteReader();

                while(mdr.Read()!= false)
                {
                    username1 = mdr.GetString(0);
                    password1 = mdr.GetString(1);
                }
                mdr.Close();
                ////////////////////////////////////////////////////////////

                //Ambil data username-password berdasarkan inputan password
                string command2 = "select username,password from simulatorkrs.user where password='" + txtPassword.Text + "'";
                mcd = new MySqlCommand(command2, mcon);
                MySqlDataReader mdr2 = mcd.ExecuteReader();

                while (mdr2.Read() != false)
                {
                    username2 = mdr2.GetString(0);
                    password2 = mdr2.GetString(1);
                }
                mdr2.Close();
                ////////////////////////////////////////////////////////////

                if (username1 == "" && username2 == "" && password1 == "" && password2 == "")
                {
                    MessageBox.Show("Maaf akun anda belum terdaftar");
                }
                else if (username1 == txtUsername.Text && password1 != txtPassword.Text)
                {
                    MessageBox.Show("Maaf password anda salah");
                }
                else if (username1 == "" && password1 == "")
                {
                    MessageBox.Show("Username dan Password anda salah, atau mungkin anda belum terdaftar");
                }
                else
                {
                    this.Hide();
                    fu.userTrans(txtUsername.Text);
                    fu.ShowDialog();
                    this.Close();
                }
                mcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Terimakasih telah menggunakan aplikasi ini :D");
            Application.Exit();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void linklblDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormDaftar fd = new FormDaftar();
            fd.ShowDialog();
            this.Dispose();
        }
    }
}
