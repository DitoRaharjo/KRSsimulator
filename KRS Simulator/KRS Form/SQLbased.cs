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
    public class SQLbased
    {
        static MySqlConnection mcon = new MySqlConnection("SERVER=localhost;DATABASE=simulatorkrs;UID=root;PWD=;");
        MySqlCommand mcd;

        public static void openCon()
        {
            try
            {
                if (mcon.State == ConnectionState.Closed)
                {
                    mcon.Open();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Tampil()
        {
            mcon.Open();
            MessageBox.Show("hai");
        }

        public void closeCon()
        {
            try
            {
                if (mcon.State == ConnectionState.Open)
                {
                    mcon.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void executeCommand(string s)
        {
            try
            {
                mcd = new MySqlCommand(s, mcon);
                if(mcd.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Failed Executed Query");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }

        }
    }
}
