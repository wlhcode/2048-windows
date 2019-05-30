using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class TitleScr : Form
    {
        public TitleScr()
        {
            InitializeComponent();
        }

        private void btnclassic_Click(object sender, EventArgs e)
        {
            Classic cf;
            this.Hide();
            cf = new Classic();
            cf.Show();
        }
    }
}
