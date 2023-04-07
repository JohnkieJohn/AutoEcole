using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcole
{
    public partial class frmAjouterVehicule : Form
    {
        public frmAjouterVehicule()
        {
            InitializeComponent();
            if (MModele.Modeles_.Count == 0)
            {
                MModele defautModele = new MModele("Autre");
            }
            this.listBox1.DataSource = MModele.Modeles_;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(this.textBox2.Text))
            {
                MVehicule unVehicule = new MVehicule(this.textBox1.Text, this.textBox2.Text);
                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.Clear();
                }
                frmPopup popup = new frmPopup("Véhicule");
                popup.ShowDialog();
            }
            else
            {
                throw new Exception("Veuillez renseignez tous les champs");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedItem = listBox1.SelectedItem.ToString();

            if (selectedItem == "Autre")
            {
                this.textBox1.Enabled = true;
                this.textBox1.Focus();
            }
            else
            {
                this.textBox1.Enabled = false;
            }
        }
    }
}
