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
    public partial class frmAjouterEleve : Form
    {
        public frmAjouterEleve()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBox1.Text) && !String.IsNullOrEmpty(this.textBox2.Text))
            {
                MEleve unEleve = new MEleve(this.textBox1.Text, this.textBox2.Text);
                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.Clear();
                }
                frmPopup popup = new frmPopup("Élève");
                popup.ShowDialog();
            }
            else
            {
                throw new Exception("Veuillez renseignez tous les champs");
            }
        }
    }
}
