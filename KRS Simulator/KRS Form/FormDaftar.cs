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
    public partial class FormDaftar : Form
    {
        MySqlDataAdapter mda;
        MySqlCommand mcd;
        MySqlConnection mcon = new MySqlConnection("SERVER=localhost;DATABASE=simulatorkrs;UID=root;PWD=;");

        public FormDaftar()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "" || txtKonPassword.Text == "" || txtSemester.Text == "" || txtIPSemester.Text == "")
                {
                    MessageBox.Show("Maaf silahkan isi semua data anda terlebih dahulu");
                }
                else
                {
                    if (label9.Text == "X")
                    {
                        MessageBox.Show("Maaf username yang anda gunakan sudah terdafatar, silahkan gunakan username lainnya");
                    }
                    else
                    {
                        if (txtPassword.Text == txtKonPassword.Text)
                        {
                            mcon.Open();
                            string q = "insert into simulatorkrs.user (username,password,peran,semester,ipsemester,statusonline) values('" + txtUsername.Text + "', '" + txtPassword.Text + "', 'pengguna' , " + txtSemester.Text + ", " + txtIPSemester.Text + ", 0)";
                            executeQuery(q);

                            this.Hide();
                            MessageBox.Show("Akun anda sukses dibuat, silahkan login");
                            FormLogin fl = new FormLogin();
                            fl.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Konfirmasi password anda salah");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mcon.Close();
            }
        }

        public void executeQuery(string query)
        {
            try
            {
                mcd = new MySqlCommand(query, mcon);
                if(mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Gagal");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mcon.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Terimakasih telah menggunakan aplikasi ini :D");
            Application.Exit();
        }

        private void btnTest_Click(object sender, EventArgs e)
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

        private void txtKonPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtKonPassword.Text != txtPassword.Text)
            {
                label8.Text = "X";
                label8.ForeColor = Color.Red;
            }
            else if (txtKonPassword.Text == txtPassword.Text)
            {
                label8.Text = "\u2713";
                label8.ForeColor = Color.Green;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mcon.Open();
                string userTemp = "";
                string command = "select username from simulatorkrs.user where username='" + txtUsername.Text + "' ";
                mcd = new MySqlCommand(command, mcon);
                MySqlDataReader mdr = mcd.ExecuteReader();

                while (mdr.Read() != false)
                {
                    userTemp = mdr.GetString(0);
                }
                mdr.Close();

                if (userTemp == "")
                {
                    label9.Text = "\u2713";
                    label9.ForeColor = Color.Green;

                    label10.Text = "Username bisa dipakai";
                }
                else
                {
                    label9.Text = "X";
                    label9.ForeColor = Color.Red;

                    label10.Text = "Username sudah terpakai";
                }
                mcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtIPSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
