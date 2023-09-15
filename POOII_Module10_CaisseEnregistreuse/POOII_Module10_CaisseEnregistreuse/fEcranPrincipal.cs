using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOII_Module10_CaisseEnregistreuse
{
    public partial class fEcranPrincipal : Form
    {
        private fEcranClient m_fEcranClient;
        public fEcranPrincipal()
        {
            InitializeComponent();
            this.m_fEcranClient = new fEcranClient();
            this.m_fEcranClient.Show();
        }

        private void fEcranPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSimuler_Click(object sender, EventArgs e)
        {

        }
    }
}
