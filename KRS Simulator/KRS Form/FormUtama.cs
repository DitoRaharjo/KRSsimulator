using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRS_Form
{
    public partial class FormUtama : Form
    {
        string user = "";

        public FormUtama()
        {
            InitializeComponent();
        }

        public void userTrans(string tempUser)
        {
            user = tempUser;
            //label2.Text = user;
        }
    }
}
