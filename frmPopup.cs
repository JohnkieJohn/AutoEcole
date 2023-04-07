using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcole
{
    public partial class frmPopup : Form
    {
        public String message;
        public frmPopup(string Message)
        {
            InitializeComponent();
            this.message = Message;
            this.label1.Text = message + " ajouté !";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
