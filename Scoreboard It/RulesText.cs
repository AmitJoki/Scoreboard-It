using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Implementation;
namespace Scoreboard_It
{
    public partial class RulesText : Form
    {
        public RulesText()
        {
            InitializeComponent();
        }

        private void RulesText_Load(object sender, EventArgs e)
        {
            try
            {
                CenterToScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CoreInfo.RulesText = richTextBox1.Text;
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        
    }
}
