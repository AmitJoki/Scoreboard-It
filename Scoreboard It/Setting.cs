using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Scoreboard_It;
using Implementation;
using System.IO;
using Microsoft.Win32;

namespace Scoreboard_It
{
    public partial class Setting : Form
    {
        public static Color TextBoxColor = new Color();
        public static Color BackGColor = new Color();
        public Setting()
        {
            InitializeComponent();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (UseDefault.Checked == true)
                {
                    Subtract.Text = 's'.ToString();
                    Add.Text = 'a'.ToString();
                    textBox2.Text = 0.ToString();
                    PassShortcut.Text = 'p'.ToString();
                    Preview.BackColor = Color.Gray;
                    textBox1.BackColor = Color.Red;
                    TES.Text = 'e'.ToString();
                }
                if (Add.Text == Subtract.Text || Subtract.Text == Add.Text || PassShortcut.Text == Add.Text || PassShortcut.Text == Subtract.Text || TES.Text == PassShortcut.Text || TES.Text == Add.Text | TES.Text == Subtract.Text)
                {
                    if (MessageBox.Show("Shortcuts cannot be same", "Same Shortcuts", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        Add.Focus();
                    }
                }
                else
                {
                    if ((string.IsNullOrWhiteSpace(ID.Text) == false && string.IsNullOrWhiteSpace(NM.Text) == false && string.IsNullOrWhiteSpace(textBox3.Text) == false && string.IsNullOrWhiteSpace(TES.Text) == false && string.IsNullOrWhiteSpace(Subtract.Text) == false && string.IsNullOrWhiteSpace(Add.Text) == false && string.IsNullOrWhiteSpace(NoOfTeam.Text) == false && string.IsNullOrWhiteSpace(textBox2.Text) == false && string.IsNullOrWhiteSpace(PassScore.Text) == false && string.IsNullOrWhiteSpace(PassShortcut.Text) == false))
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
                        if (UseDefault.Checked != true)
                        {
                            CoreInfo.PShortcut = PassShortcut.Text;
                            CoreInfo.decrements = Convert.ToChar(Subtract.Text);
                            CoreInfo.increments = Convert.ToChar(Add.Text);
                            CoreInfo.IS = Convert.ToInt32(textBox2.Text);
                            CoreInfo.EliminationShortcut = TES.Text;
                        }
                        bool level;
                        if (LevelNo.Checked)
                            level = false;
                        else level = true;
                        CoreInfo.IsLevel = level;
                        CoreInfo.CompetitionName = textBox3.Text;
                        CoreInfo.HTID = Convert.ToInt32(ID.Text);
                        CoreInfo.NOT = Convert.ToInt32(NoOfTeam.Text);
                        CoreInfo.NM = Convert.ToInt32(NM.Text);

                        if (Preview.BackColor == Color.White || textBox1.BackColor == Color.White)
                        {
                            if (MessageBox.Show("Please select textbox and background color",
                                "Color Not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                this.Activate();
                            }
                        }
                        else
                        {
                            if (UseDefault.Checked == false)
                            {
                                CoreInfo.BGColor = BackGColor;
                                CoreInfo.TextBoxColor = TextBoxColor;
                            }
                        }
                        CoreInfo.TeamScore = new int[CoreInfo.NOT];
                        CoreInfo.PScore = Convert.ToInt32(PassScore.Text);
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
                        Home hm = new Home();
                        this.Visible = false;
                        hm.Show();


                    }
                    else
                    {
                        if (MessageBox.Show("Please enter all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            ID.Focus();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                ID.MaxLength = 4;
                textBox2.MaxLength = 4;
                PassScore.MaxLength = 4;
                toolTip1.IsBalloon = true;
                toolTip1.SetToolTip(UseDefault, "Use this option to use a set of pre-defined shortcuts and values");
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip2.IsBalloon = true;
                toolTip2.SetToolTip(NoOfTeam, "Note:If you dont mention any of team names, default values will be taken.");
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;

                if (Directory.Exists("D:/") == true && Directory.Exists("D:/Results") == true)
                {
                    Directory.CreateDirectory("D:/Scoreboard It!/Results");
                    CoreInfo.Directory = "D:/Scoreboard It!/Results/";
                }
                else if (Directory.Exists("E:/") == true && Directory.Exists("E:/Results") == true)
                {
                    Directory.CreateDirectory("E:/Scoreboard It!/Results");
                    CoreInfo.Directory = "E:/Scoreboard It!/Results/";
                }
                else if (Directory.Exists("F:/") == true && Directory.Exists("F:/Results") == true)
                {
                    Directory.CreateDirectory("F:/Scoreboard It!/Results");
                    CoreInfo.Directory = "F:/Scoreboard It!/Results/";
                }
                else if (Directory.Exists("C:/") == true)
                {
                    Directory.CreateDirectory("C:/Scoreboard It!/Results");
                    CoreInfo.Directory = "C:/Scoreboard It!/Results/";
                }

                CenterToScreen();
                this.MaximizeBox = false;
                Preview.BackColor = Color.White;
                textBox1.BackColor = Color.White;
                Preview.ReadOnly = true;
                textBox1.ReadOnly = true;
                label5.Visible = false;
                Team1_Name.Visible = false;
                Team1Box.Visible = false;
                Team2Box.Visible = false;
                Team3Box.Visible = false;
                Team4Box.Visible = false;
                Team5Box.Visible = false;
                Team6Box.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
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

        private void ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int o;
                if ((int.TryParse(ID.Text, out o) == false && ID.Text != "") || ID.Text == "0") { MessageBox.Show("Please type a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); ID.Text = ""; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Add_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Add.TextLength > 1 && Add.Text != "")
                {
                    MessageBox.Show("Please type a single letter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); Add.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Subtract_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Subtract.TextLength > 1 && Subtract.Text != "")
                {
                    MessageBox.Show("Please type a single letter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); Subtract.Text = "";
                }
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
                int CC;
                if (int.TryParse(textBox2.Text, out CC) == false && textBox2.Text != "")
                {
                    MessageBox.Show("Please type a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); textBox2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void PassScore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int CC;
                if ((int.TryParse(PassScore.Text, out CC) == false && PassScore.Text != "") || PassScore.Text == "0")
                {
                    MessageBox.Show("Please type a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); PassScore.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void PassShortcut_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PassShortcut.TextLength > 1 && PassShortcut.Text != "")
                {
                    MessageBox.Show("Please type a single letter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); PassShortcut.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void TextColor_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1.AllowFullOpen = true;
                colorDialog1.ShowDialog();
                TextBoxColor = colorDialog1.Color;
                textBox1.BackColor = colorDialog1.Color;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void BGColor_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog2.AllowFullOpen = true;
                colorDialog2.ShowDialog();
                if (colorDialog2.Color.Name != "Black")
                {
                    BackGColor = colorDialog2.Color;
                    Preview.BackColor = colorDialog2.Color;
                }
                else
                {
                    MessageBox.Show("Black is not allowed! \nChoose any other color", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            try
            {
                RulesText r = new RulesText();
                r.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }


        private void NM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int o;
                if ((int.TryParse(NM.Text, out o) == false && NM.Text != "") || NM.Text == "0") { MessageBox.Show("Please type a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); NM.Text = ""; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }



        private void UseDefault_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (UseDefault.Checked == true)
                {
                    CoreInfo.BGColor = Color.Gray;
                    CoreInfo.decrements = 's';
                    CoreInfo.increments = 'a';
                    CoreInfo.IS = 0;
                    CoreInfo.PShortcut = 'p'.ToString();
                    CoreInfo.TextBoxColor = Color.Red;
                    CoreInfo.EliminationShortcut = 'e'.ToString();
                    PassShortcut.Enabled = false;
                    Add.Enabled = false;
                    Subtract.Enabled = false;
                    TextColor.Enabled = false;
                    BGColor.Enabled = false;
                    textBox2.Enabled = false;
                    TES.Enabled = false;
                    textBox1.BackColor = Color.Red;
                    Preview.BackColor = Color.Gray;
                    TextBoxColor = Color.Red;
                    BackGColor = Color.Gray;
                }
                else
                {
                    CoreInfo.BGColor = Color.Empty;
                    CoreInfo.decrements = '\0';
                    CoreInfo.increments = '\0';
                    CoreInfo.IS = 0;
                    CoreInfo.PShortcut = null;
                    CoreInfo.TextBoxColor = Color.Empty;
                    CoreInfo.EliminationShortcut = null;
                    PassShortcut.Enabled = true;
                    Add.Enabled = true;
                    Subtract.Enabled = true;
                    TextColor.Enabled = true;
                    BGColor.Enabled = true;
                    textBox2.Enabled = true;
                    TES.Enabled = true;
                    textBox1.BackColor = Color.White;
                    Preview.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }



    }


}
