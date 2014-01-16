using Implementation;
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
    public partial class DValues : Form
    {
        public DValues()
        {
            InitializeComponent();
        }

        private void Team2Box_Enter(object sender, EventArgs e)
        {

        }
        private void NoOfTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (Convert.ToInt32(NoOfTeam.Text))
                {
                    case 0:
                        {
                            break;
                        }
                    case 2:
                        {
                            Team1Box.Visible = true;
                            label5.Visible = true;
                            Team1_Name.Visible = true;
                            Team2Box.Visible = true;
                            Team3Box.Visible = false;
                            Team4Box.Visible = false;
                            Team5Box.Visible = false;
                            Team6Box.Visible = false;
                            break;
                        }
                    case 3:
                        {
                            label5.Visible = true;
                            Team1_Name.Visible = true;
                            Team1Box.Visible = true;
                            Team2Box.Visible = true;
                            Team3Box.Visible = true;
                            Team4Box.Visible = false;
                            Team5Box.Visible = false;
                            Team6Box.Visible = false;
                            break;
                        }
                    case 4:
                        {
                            label5.Visible = true;
                            Team1_Name.Visible = true;
                            Team1Box.Visible = true;
                            Team2Box.Visible = true;
                            Team3Box.Visible = true;
                            Team4Box.Visible = true;
                            Team5Box.Visible = false;
                            Team6Box.Visible = false;
                            break;
                        }
                    case 5:
                        {
                            label5.Visible = true;
                            Team1_Name.Visible = true;
                            Team1Box.Visible = true;
                            Team2Box.Visible = true;
                            Team3Box.Visible = true;
                            Team4Box.Visible = true;
                            Team5Box.Visible = true;
                            Team6Box.Visible = false;
                            break;
                        }
                    case 6:
                        {
                            label5.Visible = true;
                            Team1_Name.Visible = true;
                            Team1Box.Visible = true;
                            Team2Box.Visible = true;
                            Team3Box.Visible = true;
                            Team4Box.Visible = true;
                            Team5Box.Visible = true;
                            Team6Box.Visible = true;
                            break;
                        }
                }
                NoOfTeam.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) == false&&NoOfTeam.Text!="")
            {
                if (Team1_Name.Text == "")
                {
                    Team1_Name.Text = "Team A";
                }
                if (Team2_Name.Text == "")
                {
                    Team2_Name.Text = "Team B";
                }
                if (Team3_Name.Text == "" && Team3Box.Visible == true)
                {
                    Team3_Name.Text = "Team C";
                }
                if (Team4_Name.Text == "" && Team4Box.Visible == true)
                {
                    Team4_Name.Text = "Team D";
                }
                if (Team5_Name.Text == "" && Team5Box.Visible == true)
                {
                    Team5_Name.Text = "Team E";
                }
                if (Team6_Name.Text == "" && Team6Box.Visible == true)
                {
                    Team6_Name.Text = "Team F";
                }
                CoreInfo.CompetitionName = textBox1.Text; ;
                CoreInfo.NOT = Convert.ToInt32(NoOfTeam.Text);
                switch (CoreInfo.NOT)
                {
                    case 2:
                        {
                            CoreInfo.team1name = Team1_Name.Text;
                            CoreInfo.team2name = Team2_Name.Text; break;
                        }
                    case 3:
                        {
                            CoreInfo.team1name = Team1_Name.Text;
                            CoreInfo.team3name = Team3_Name.Text;
                            CoreInfo.team2name = Team2_Name.Text; break;
                        }
                    case 4:
                        {
                            CoreInfo.team1name = Team1_Name.Text;
                            CoreInfo.team3name = Team3_Name.Text;
                            CoreInfo.team4name = Team4_Name.Text;
                            CoreInfo.team2name = Team2_Name.Text; break;
                        }
                    case 5:
                        {
                            CoreInfo.team1name = Team1_Name.Text;
                            CoreInfo.team3name = Team3_Name.Text;
                            CoreInfo.team5name = Team5_Name.Text;
                            CoreInfo.team4name = Team4_Name.Text;
                            CoreInfo.team2name = Team2_Name.Text; break;
                        }
                    case 6:
                        {
                            CoreInfo.team1name = Team1_Name.Text;
                            CoreInfo.team3name = Team3_Name.Text;
                            CoreInfo.team5name = Team5_Name.Text;
                            CoreInfo.team4name = Team4_Name.Text;
                            CoreInfo.team6name = Team6_Name.Text;
                            CoreInfo.team2name = Team2_Name.Text; break;
                        }
                }
                this.Visible = false;
                Home hm = new Home();
                hm.Show();
            }
            else
            {
                MessageBox.Show("Please enter all the fields");
            }
        }

        private void DValues_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

    }
}

