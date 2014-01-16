using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoreboard_It
{
    public partial class RulesPage : Form
    {
        public RulesPage()
        {
            InitializeComponent();
        }

        private void RulesPage_Load(object sender, EventArgs e)
        {
            try
            {
                CenterToScreen();
                richTextBox1.ReadOnly = true;
                richTextBox1.Text = Implementation.CoreInfo.RulesText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }
    }
}
