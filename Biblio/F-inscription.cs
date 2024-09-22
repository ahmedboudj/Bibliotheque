using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
    public partial class F_inscription : Form
    {
        public F_inscription()
        {
            InitializeComponent();
        }

        

        private void Nouveau_Click(object sender, EventArgs e)
        {
            tbxID.Clear();
            tbxNom.Clear();
            tbxPrénom.Clear();
            tbxAdresse.Clear();
            rdbMasculin.Checked = false;
            rdbFéminin.Checked = false;
            tbxAge.Clear();
        }
    }
}
