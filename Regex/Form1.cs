using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = txtHaystack.Text;
            System.Text.RegularExpressions.Regex r =
                new System.Text.RegularExpressions.Regex(txtNeedle.Text);
            Match m = r.Match(s);
            while (m.Success)
            {
                MessageBox.Show("Found at: " + m.Index);
                m = m.NextMatch();
            }
        }
    }
}
