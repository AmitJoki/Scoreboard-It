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
    public partial class LevelSettings : Form
    {
        public LevelSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Please enter all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CoreInfo.NM = Convert.ToInt32(textBox2.Text);
                    CoreInfo.HTID = Convert.ToInt32(textBox1.Text);
                    CoreInfo.PScore = Convert.ToInt32(textBox3.Text);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int o;
                if ((int.TryParse(textBox1.Text, out o) == false && textBox1.Text != "") || textBox1.Text == "0") { MessageBox.Show("Please type a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); textBox1.Text = ""; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int o;
                if ((int.TryParse(textBox2.Text, out o) == false && textBox2.Text != "") || textBox2.Text == "0") { MessageBox.Show("Please type a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); textBox2.Text = ""; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int o;
                if ((int.TryParse(textBox3.Text, out o) == false && textBox3.Text != "") || textBox3.Text == "0") { MessageBox.Show("Please type a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); textBox3.Text = ""; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void LevelSettings_Load(object sender, EventArgs e)
        {
            try
            {
                CenterToParent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }
    }
}
