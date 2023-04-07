namespace AutoEcole
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAjouterMoniteur form1 = new frmAjouterMoniteur();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAjouterEleve form2 = new frmAjouterEleve();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAjouterVehicule form3 = new frmAjouterVehicule();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmPlannifierLecon form4 = new frmPlannifierLecon();
            form4.ShowDialog();
        }
    }
}