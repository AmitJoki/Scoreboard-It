using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Resources;
using Implementation;
using Microsoft.Win32;
namespace Scoreboard_It
{

    public partial class Home : Form
    {
        public bool exited = false;
        public char ShortCutForAdd, ShortCutForSubtract, ShortcutForStartTime, ShortcutForStopTime, ShortCutForElimination, ShortcutForPass;
        public int[] Score = new int[CoreInfo.NOT];
        public int DefaultScore, l = 0, elim = CoreInfo.NOT;
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter write = new StreamWriter(CoreInfo.Directory + CoreInfo.CompetitionName + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".txt", true))
                {
                    write.WriteLine("New Competition Started at :" + DateTime.Now);
                    write.WriteLine("Day: " + DateTime.Now.DayOfWeek);
                    write.WriteLine("Name of the Competition: " + CoreInfo.CompetitionName);
                    write.WriteLine("----------------------");
                }
                CoreInfo.Responded = 0;
                this.Text = "Scoreboard It! : " + CoreInfo.CompetitionName;
                Team1.Focus();
                this.BackColor = CoreInfo.BGColor;
                CompetitionName.BackColor = this.BackColor;
                this.MinimizeBox = false;
                Team1.BackColor = CoreInfo.TextBoxColor;
                Team2.BackColor = CoreInfo.TextBoxColor;
                Team3.BackColor = CoreInfo.TextBoxColor;
                Team4.BackColor = CoreInfo.TextBoxColor;
                Team5.BackColor = CoreInfo.TextBoxColor;
                Team6.BackColor = CoreInfo.TextBoxColor;
                CoreInfo.TeamScore = new int[CoreInfo.NOT];
                CompetitionName.Text = CoreInfo.CompetitionName;
                if (CoreInfo.IsLevel == true)
                {
                    Reset.Visible = true;
                }
                else
                {
                    Reset.Visible = false;
                    if (Reset.Visible == false)
                    {
                        End.Location = Reset.Location;
                    }
                }
                ShortcutForPass = Convert.ToChar(CoreInfo.PShortcut);
                ShortCutForElimination = Convert.ToChar(CoreInfo.EliminationShortcut);
                Team1.MaxLength = 1;
                Team2.MaxLength = 1;
                Team3.MaxLength = 1;
                Team4.MaxLength = 1;
                Team5.MaxLength = 1;
                Team6.MaxLength = 1;
                ShortCutForAdd = CoreInfo.increments;
                ShortCutForSubtract = CoreInfo.decrements;
                for (int i = 0; i < CoreInfo.NOT; i++)
                {
                    Score[i] = CoreInfo.IS;
                }
                DefaultScore = CoreInfo.IS;
                T1Result.Text = DefaultScore.ToString();
                T2Result.Text = DefaultScore.ToString();
                T3Result.Text = DefaultScore.ToString();
                T4Result.Text = DefaultScore.ToString();
                T5Result.Text = DefaultScore.ToString();
                T6Result.Text = DefaultScore.ToString();
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.SetToolTip(label1, "Shortcut for correct answer:\t" + CoreInfo.increments + "\nShortcuts for wrong answer:\t " + CoreInfo.decrements + "\nShortcut for team elimination:\t" + CoreInfo.EliminationShortcut);
                switch (CoreInfo.NOT)
                {
                    case 2:
                        {
                            Team1Container.Visible = true;
                            Team2Container.Visible = true;
                            label1Team.Text = CoreInfo.team1name;
                            label2Team.Text = CoreInfo.team2name; break;
                        }
                    case 3:
                        {
                            Team1Container.Visible = true;
                            Team2Container.Visible = true;
                            Team3Container.Visible = true;
                            label3Team.Text = CoreInfo.team3name;
                            label1Team.Text = CoreInfo.team1name;
                            label2Team.Text = CoreInfo.team2name; break;
                        }
                    case 4:
                        {
                            Team1Container.Visible = true;
                            Team2Container.Visible = true;
                            Team3Container.Visible = true;
                            Team4Container.Visible = true;
                            label4Team.Text = CoreInfo.team4name;
                            label3Team.Text = CoreInfo.team3name;
                            label1Team.Text = CoreInfo.team1name;
                            label2Team.Text = CoreInfo.team2name; break;
                        }
                    case 5:
                        {
                            Team1Container.Visible = true;
                            Team2Container.Visible = true;
                            Team3Container.Visible = true;
                            Team4Container.Visible = true;
                            Team5Container.Visible = true;
                            label5Team.Text = CoreInfo.team5name;
                            label4Team.Text = CoreInfo.team4name;
                            label3Team.Text = CoreInfo.team3name;
                            label1Team.Text = CoreInfo.team1name;
                            label2Team.Text = CoreInfo.team2name; break;
                        }
                    case 6:
                        {
                            Team1Container.Visible = true;
                            Team2Container.Visible = true;
                            Team3Container.Visible = true;
                            Team4Container.Visible = true;
                            Team5Container.Visible = true;
                            Team6Container.Visible = true;
                            label6Team.Text = CoreInfo.team6name;
                            label5Team.Text = CoreInfo.team5name;
                            label4Team.Text = CoreInfo.team4name;
                            label3Team.Text = CoreInfo.team3name;
                            label1Team.Text = CoreInfo.team1name;
                            label2Team.Text = CoreInfo.team2name; break;

                        }

                }
                Team1.ForeColor = Team1.BackColor;
                Team2.ForeColor = Team2.BackColor;
                Team3.ForeColor = Team3.BackColor;
                Team4.ForeColor = Team4.BackColor;
                Team5.ForeColor = Team5.BackColor;
                Team6.ForeColor = Team6.BackColor;
                MessageBox.Show("Your shortcut for correct answer is " + "'" + ShortCutForAdd.ToString() + "'" + "\n" + "Your shortcut for wrong answer is " + "'" + ShortCutForSubtract.ToString() + "'" + "\n" +
                    "Your shortcut for passing a question is " + "'" + ShortcutForPass.ToString() + "'" + ".\n" + "Your shortcut for eliminating a team is " + "'" + ShortCutForElimination.ToString() + "'" + "\n" +
                    "You can move to other team by using TAB button.\nAfter a team answers, the focus will automatically shift to the next team.\nIf a team doesn't answer, bring focus to the next team and if they answer give them pass marks (If at all required), if they don't ,continue the process", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }


        private void Team1_KeyPress(object sender, EventArgs e)
        {
            try
            {
                ScoreBoard_It_Functions Process = new ScoreBoard_It_Functions();
                if (Team1.TextLength > 1)
                {
                    Team1.ResetText();
                    MessageBox.Show("Maximum Character allowed is 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Team1.Text == ShortCutForAdd.ToString())
                {
                    if (Convert.ToInt32(T1Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[0]);
                        Score[0] = ShowScore;
                        T1Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[0] = Score[0];
                        SelectNextControl(Team1, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team1.Text == ShortCutForSubtract.ToString())
                {
                    if (Convert.ToInt32(T1Result.Text) > -99999)
                    {

                        int ShowScore = Process.Subtract(Score[0]);
                        Score[0] = ShowScore;
                        T1Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[0] = Score[0];
                        SelectNextControl(Team1, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't subtract further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team1.Text == ShortCutForElimination.ToString())
                {
                    if (elim != 1)
                    {
                        if (MessageBox.Show("Do you really want to eliminate this team?", "Opinion", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            Team1.Enabled = false;
                            T1Result.BackColor = Color.Red;
                            T1Result.Text = "X";
                            if (elim != 1)
                            {
                                elim -= 1;
                            }
                        }
                        else { Team1.Focus(); }
                    }
                    else
                    {
                        MessageBox.Show("Can't eliminate the winner!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Team1.Text == ShortcutForPass.ToString())
                {
                    if (Convert.ToInt32(T1Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[0], true);
                        Score[0] = ShowScore;
                        T1Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[0] = Score[0];
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }

                Team1.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team2_KeyPress(object sender, EventArgs e)
        {
            try
            {
                ScoreBoard_It_Functions Process = new ScoreBoard_It_Functions();
                if (Team2.TextLength > 1)
                {
                    Team2.ResetText();
                    MessageBox.Show("Maximum Character allowed is 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Team2.Text == ShortCutForAdd.ToString())
                {
                    if (Convert.ToInt32(T2Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[1]);
                        Score[1] = ShowScore;
                        T2Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[1] = Score[1];
                        SelectNextControl(Team2, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team2.Text == ShortCutForSubtract.ToString())
                {
                    if (Convert.ToInt32(T2Result.Text) > -99999)
                    {
                        int ShowScore = Process.Subtract(Score[1]);
                        Score[1] = ShowScore;
                        T2Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[1] = Score[1];
                        SelectNextControl(Team2, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't subtract further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team2.Text == ShortCutForElimination.ToString())
                {
                    if (elim != 1)
                    {

                        if (MessageBox.Show("Do you really want to eliminate this team?", "Opinion", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            Team2.Enabled = false;
                            T2Result.BackColor = Color.Red;
                            T2Result.Text = "X";
                            if (elim != 1)
                            {
                                elim -= 1;
                            }
                        }
                        else { Team2.Focus(); }
                    }
                    else
                    {
                        MessageBox.Show("Can't eliminate the winner!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Team2.Text == ShortcutForPass.ToString())
                {
                    if (Convert.ToInt32(T2Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[1], true);
                        Score[1] = ShowScore;
                        T2Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[1] = Score[1];
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                Team2.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team3_KeyPress(object sender, EventArgs e)
        {
            try
            {
                ScoreBoard_It_Functions Process = new ScoreBoard_It_Functions();
                if (Team3.TextLength > 1)
                {
                    Team3.ResetText();
                    MessageBox.Show("Maximum Character allowed is 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Team3.Text == ShortCutForAdd.ToString())
                {
                    if (Convert.ToInt32(T3Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[2]);
                        Score[2] = ShowScore;
                        T3Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[2] = Score[2];
                        SelectNextControl(Team3, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team3.Text == ShortCutForSubtract.ToString())
                {
                    if (Convert.ToInt32(T3Result.Text) > -99999)
                    {
                        int ShowScore = Process.Subtract(Score[2]);
                        Score[2] = ShowScore;
                        T3Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[2] = Score[2];
                        SelectNextControl(Team3, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't subtract further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team3.Text == ShortCutForElimination.ToString())
                {
                    if (elim != 1)
                    {
                        if (MessageBox.Show("Do you really want to eliminate this team?", "Opinion", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            Team3.Enabled = false;
                            T3Result.BackColor = Color.Red;
                            T3Result.Text = "X";
                            if (elim != 1)
                            {
                                elim -= 1;
                            }
                        }
                        else { Team3.Focus(); }
                    }
                    else
                    {
                        MessageBox.Show("Can't eliminate the winner!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Team3.Text == ShortcutForPass.ToString())
                {
                    if (Convert.ToInt32(T3Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[2], true);
                        Score[2] = ShowScore;
                        T3Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[2] = Score[2];
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                Team3.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team4_KeyPress(object sender, EventArgs e)
        {
            try
            {
                ScoreBoard_It_Functions Process = new ScoreBoard_It_Functions();
                if (Team4.TextLength > 1)
                {
                    Team4.ResetText();
                    MessageBox.Show("Maximum Character allowed is 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Team4.Text == ShortCutForAdd.ToString())
                {
                    if (Convert.ToInt32(T4Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[3]);
                        Score[3] = ShowScore;
                        T4Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[3] = Score[3];
                        SelectNextControl(Team4, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team4.Text == ShortCutForSubtract.ToString())
                {
                    if (Convert.ToInt32(T4Result.Text) > -99999)
                    {
                        int ShowScore = Process.Subtract(Score[3]);
                        Score[3] = ShowScore;
                        T4Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[3] = Score[3];
                        SelectNextControl(Team4, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't subtract further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team4.Text == ShortCutForElimination.ToString())
                {
                    if (elim != 1)
                    {
                        if (MessageBox.Show("Do you really want to eliminate this team?", "Opinion", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            Team4.Enabled = false;
                            T4Result.BackColor = Color.Red;
                            T4Result.Text = "X";
                            if (elim != 1)
                            {
                                elim -= 1;
                            }
                        }
                        else { Team4.Focus(); }
                    }
                    else
                    {
                        MessageBox.Show("Can't eliminate the winner!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Team4.Text == ShortcutForPass.ToString())
                {
                    if (Convert.ToInt32(T4Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[3], true);
                        Score[3] = ShowScore;
                        T4Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[3] = Score[3];
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                Team4.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team5_KeyPress(object sender, EventArgs e)
        {
            try
            {
                ScoreBoard_It_Functions Process = new ScoreBoard_It_Functions();
                if (Team5.TextLength > 1)
                {
                    Team5.ResetText();
                    MessageBox.Show("Maximum Character allowed is 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Team5.Text == ShortCutForAdd.ToString())
                {
                    if (Convert.ToInt32(T5Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[4]);
                        Score[4] = ShowScore;
                        T5Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[4] = Score[4];
                        SelectNextControl(Team5, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team5.Text == ShortCutForSubtract.ToString())
                {
                    if (Convert.ToInt32(T5Result.Text) > -99999)
                    {
                        int ShowScore = Process.Subtract(Score[4]);
                        Score[4] = ShowScore;
                        T5Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[4] = Score[4];
                        SelectNextControl(Team5, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team5.Text == ShortCutForElimination.ToString())
                {
                    if (elim != 1)
                    {
                        if (MessageBox.Show("Do you really want to eliminate this team?", "Opinion", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            Team5.Enabled = false;
                            T5Result.BackColor = Color.Red;
                            T5Result.Text = "X";
                            if (elim != 1)
                            {
                                elim -= 1;
                            }
                        }
                        else { Team5.Focus(); }
                    }
                    else
                    {
                        MessageBox.Show("Can't eliminate the winner!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Team5.Text == ShortcutForPass.ToString())
                {
                    if (Convert.ToInt32(T5Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[4], true);
                        Score[4] = ShowScore;
                        T5Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[4] = Score[4];
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                Team5.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team6_KeyPress(object sender, EventArgs e)
        {
            try
            {
                ScoreBoard_It_Functions Process = new ScoreBoard_It_Functions();
                if (Team6.TextLength > 1)
                {
                    Team6.ResetText();
                    MessageBox.Show("Maximum Character allowed is 1", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                if (Team6.Text == ShortCutForAdd.ToString())
                {
                    if (Convert.ToInt32(T6Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[5]);
                        Score[5] = ShowScore;
                        T6Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[5] = Score[5];
                        SelectNextControl(Team6, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team6.Text == ShortCutForSubtract.ToString())
                {
                    if (Convert.ToInt32(T6Result.Text) > -99999)
                    {
                        int ShowScore = Process.Subtract(Score[5]);
                        Score[5] = ShowScore;
                        T6Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[5] = Score[5];
                        SelectNextControl(Team6, true, true, true, true);
                    }
                    else
                    {
                        MessageBox.Show("Can't subtract further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (Team6.Text == ShortCutForElimination.ToString())
                {
                    if (elim != 1)
                    {
                        if (MessageBox.Show("Do you really want to eliminate this team?", "Opinion", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            Team6.Enabled = false;
                            T6Result.BackColor = Color.Red;
                            T6Result.Text = "X";
                            if (elim != 1)
                            {
                                elim -= 1;
                            }
                        }
                        else
                        {
                            Team6.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can't eliminate the winner!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Team6.Text == ShortcutForPass.ToString())
                {
                    if (Convert.ToInt32(T6Result.Text) < 99999)
                    {
                        int ShowScore = Process.Add(Score[5], true);
                        Score[5] = ShowScore;
                        T6Result.Text = ShowScore.ToString();
                        CoreInfo.TeamScore[5] = Score[5];
                    }
                    else
                    {
                        MessageBox.Show("Can't add further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                Team6.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            try
            {
                l++; bool somwthing = false;
                CoreInfo.Responded++;
                if (elim != 1)
                {
                    if (MessageBox.Show("Moving to next level will reset the score to Initial score\nDo you want to continue", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        try
                        {
                            using (StreamWriter s = new StreamWriter(CoreInfo.Directory + CoreInfo.CompetitionName + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".txt", true))
                            {
                                switch (CoreInfo.NOT)
                                {
                                    case 2:
                                        {
                                            if (T1Result.Text != "0" || T2Result.Text != "0")
                                            {
                                                s.WriteLine("At the end of level " + l.ToString());
                                                s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                                s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                                s.WriteLine("----------------------");
                                                T1Result.Text = DefaultScore.ToString();
                                                T2Result.Text = DefaultScore.ToString();
                                                for (int i = 0; i < 2; i++)
                                                {
                                                    Score[i] = DefaultScore;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                if (MessageBox.Show("Cannot move to next level when all teams have their score as 0", "Next Level", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                                {
                                                    somwthing = true;
                                                    this.Focus(); break;
                                                }
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (T1Result.Text != "0" || T2Result.Text != "0" || T3Result.Text != "0")
                                            {
                                                s.WriteLine("At the end of level " + l.ToString());
                                                s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                                s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                                s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                                s.WriteLine("----------------------");
                                                T1Result.Text = DefaultScore.ToString();
                                                T2Result.Text = DefaultScore.ToString();
                                                T3Result.Text = DefaultScore.ToString();
                                                for (int i = 0; i < 3; i++)
                                                {
                                                    Score[i] = DefaultScore;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                if (MessageBox.Show("Cannot move to next level when all teams have their score as 0", "Next Level", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                                {
                                                    somwthing = true;
                                                    this.Focus(); break;
                                                }
                                            }
                                            break;
                                        }
                                    case 4:
                                        {
                                            if (T1Result.Text != "0" || T2Result.Text != "0" || T3Result.Text != "0" || T4Result.Text != "0")
                                            {
                                                s.WriteLine("At the end of level " + l.ToString());
                                                s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                                s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                                s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                                s.WriteLine(label4Team.Text + "=" + T4Result.Text);
                                                s.WriteLine("----------------------");
                                                T1Result.Text = DefaultScore.ToString();
                                                T2Result.Text = DefaultScore.ToString();
                                                T3Result.Text = DefaultScore.ToString();
                                                T4Result.Text = DefaultScore.ToString();
                                                for (int i = 0; i < 4; i++)
                                                {
                                                    Score[i] = DefaultScore;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                if (MessageBox.Show("Cannot move to next level when all teams have their score as 0", "Next Level", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                                {
                                                    somwthing = true;
                                                    this.Focus(); break;
                                                }
                                            }
                                            break;
                                        }
                                    case 5:
                                        {
                                            if (T1Result.Text != "0" || T2Result.Text != "0" || T3Result.Text != "0" || T4Result.Text != "0" || T5Result.Text != "0")
                                            {
                                                s.WriteLine("At the end of level " + l.ToString());
                                                s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                                s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                                s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                                s.WriteLine(label4Team.Text + "=" + T4Result.Text);
                                                s.WriteLine(label5Team.Text + "=" + T5Result.Text);
                                                s.WriteLine("----------------------");
                                                T1Result.Text = DefaultScore.ToString();
                                                T2Result.Text = DefaultScore.ToString();
                                                T3Result.Text = DefaultScore.ToString();
                                                T4Result.Text = DefaultScore.ToString();
                                                T5Result.Text = DefaultScore.ToString();
                                                for (int i = 0; i < 5; i++)
                                                {
                                                    Score[i] = DefaultScore;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                if (MessageBox.Show("Cannot move to next level when all teams have their score as 0", "Next Level", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                                {
                                                    somwthing = true;
                                                    this.Focus(); break;
                                                }
                                            }
                                            break;

                                        }
                                    case 6:
                                        {
                                            if (T1Result.Text != "0" || T2Result.Text != "0" || T3Result.Text != "0" || T4Result.Text != "0" || T5Result.Text != "0" || T6Result.Text != "0")
                                            {
                                                s.WriteLine("At the end of level " + l.ToString());
                                                s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                                s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                                s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                                s.WriteLine(label4Team.Text + "=" + T4Result.Text);
                                                s.WriteLine(label5Team.Text + "=" + T5Result.Text);
                                                s.WriteLine(label6Team.Text + "=" + T6Result.Text);
                                                s.WriteLine("----------------------");
                                                T1Result.Text = DefaultScore.ToString();
                                                T2Result.Text = DefaultScore.ToString();
                                                T3Result.Text = DefaultScore.ToString();
                                                T4Result.Text = DefaultScore.ToString();
                                                T5Result.Text = DefaultScore.ToString();
                                                T6Result.Text = DefaultScore.ToString();
                                                for (int i = 0; i < 6; i++)
                                                {
                                                    Score[i] = DefaultScore;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                if (MessageBox.Show("Cannot move to next level when all teams have their score as 0", "Next Level", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                                                {
                                                    somwthing = true;
                                                    this.Focus(); break;
                                                }
                                            }
                                            break;
                                        }
                                }
                                s.Close();
                            }
                            if (somwthing == false)
                            {
                                if (MessageBox.Show("Do you want to change the scoring system for the next level?", "Opinion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    LevelSettings set = new LevelSettings();
                                    set.ShowDialog();
                                    if (Team1.Enabled == false)
                                        SelectNextControl(Team1, true, true, true, true);
                                    else
                                    {
                                        Team1.Focus();
                                    }
                                }
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
                        }
                    }
                    else
                    {
                        this.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("At least 2 teams should remain uneliminated to continue for the next level");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }


        private void ShowResult_Click(object sender, EventArgs e)
        {

        }


        private void ShowRules_Click(object sender, EventArgs e)
        {
            try
            {
                RulesPage rp = new RulesPage();
                rp.ShowDialog();
                if (Team1.Enabled == false)
                    SelectNextControl(Team1, true, true, true, true);
                else
                {
                    Team1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (exited == false)
                {
                    if (MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }

                if (Reset.Visible == false || CoreInfo.Responded == 0)
                {
                    using (StreamWriter s = new StreamWriter(CoreInfo.Directory + CoreInfo.CompetitionName + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".txt", true))
                    {
                        switch (CoreInfo.NOT)
                        {
                            case 2:
                                {
                                    s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                    s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                    s.WriteLine("----------------------");
                                    T1Result.Text = DefaultScore.ToString();
                                    T2Result.Text = DefaultScore.ToString();
                                    for (int i = 0; i < 2; i++)
                                    {
                                        Score[i] = DefaultScore;
                                    }

                                    break;
                                }
                            case 3:
                                {
                                    s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                    s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                    s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                    s.WriteLine("----------------------");
                                    T1Result.Text = DefaultScore.ToString();
                                    T2Result.Text = DefaultScore.ToString();
                                    T3Result.Text = DefaultScore.ToString();
                                    for (int i = 0; i < 3; i++)
                                    {
                                        Score[i] = DefaultScore;
                                    }

                                    break;
                                }
                            case 4:
                                {
                                    s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                    s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                    s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                    s.WriteLine(label4Team.Text + "=" + T4Result.Text);
                                    s.WriteLine("----------------------");
                                    T1Result.Text = DefaultScore.ToString();
                                    T2Result.Text = DefaultScore.ToString();
                                    T3Result.Text = DefaultScore.ToString();
                                    T4Result.Text = DefaultScore.ToString();
                                    for (int i = 0; i < 4; i++)
                                    {
                                        Score[i] = DefaultScore;
                                    }

                                    break;
                                }
                            case 5:
                                {
                                    s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                    s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                    s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                    s.WriteLine(label4Team.Text + "=" + T4Result.Text);
                                    s.WriteLine(label5Team.Text + "=" + T5Result.Text);
                                    s.WriteLine("----------------------");
                                    T1Result.Text = DefaultScore.ToString();
                                    T2Result.Text = DefaultScore.ToString();
                                    T3Result.Text = DefaultScore.ToString();
                                    T4Result.Text = DefaultScore.ToString();
                                    T5Result.Text = DefaultScore.ToString();
                                    for (int i = 0; i < 5; i++)
                                    {
                                        Score[i] = DefaultScore;
                                    }
                                    break;

                                }
                            case 6:
                                {

                                    s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                    s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                    s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                    s.WriteLine(label4Team.Text + "=" + T4Result.Text);
                                    s.WriteLine(label5Team.Text + "=" + T5Result.Text);
                                    s.WriteLine(label6Team.Text + "=" + T6Result.Text);
                                    s.WriteLine("----------------------");
                                    T1Result.Text = DefaultScore.ToString();
                                    T2Result.Text = DefaultScore.ToString();
                                    T3Result.Text = DefaultScore.ToString();
                                    T4Result.Text = DefaultScore.ToString();
                                    T5Result.Text = DefaultScore.ToString();
                                    T6Result.Text = DefaultScore.ToString();
                                    for (int i = 0; i < 6; i++)
                                    {
                                        Score[i] = DefaultScore;
                                    }
                                    break;

                                }

                        }
                        s.Close();
                    }
                    if (Team1.Enabled == false)
                        SelectNextControl(Team1, true, true, true, true);
                    else
                    {
                        Team1.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Resetting the score will delete the current values, which cannot be restored.\nWe recommend you not to reset the score, as it results in a loss of work done. \nDo you still want to continue?", "Not Recommended", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    switch (CoreInfo.NOT)
                    {
                        case 2:
                            {
                                T1Result.Text = DefaultScore.ToString();
                                T2Result.Text = DefaultScore.ToString();
                                for (int i = 0; i < 2; i++)
                                {
                                    Score[i] = DefaultScore;
                                }
                                break;
                            }
                        case 3:
                            {
                                T1Result.Text = DefaultScore.ToString();
                                T2Result.Text = DefaultScore.ToString();
                                T3Result.Text = DefaultScore.ToString();
                                for (int i = 0; i < 3; i++)
                                {
                                    Score[i] = DefaultScore;
                                }
                                break;
                            }
                        case 4:
                            {
                                T1Result.Text = DefaultScore.ToString();
                                T2Result.Text = DefaultScore.ToString();
                                T3Result.Text = DefaultScore.ToString();
                                T4Result.Text = DefaultScore.ToString();
                                for (int i = 0; i < 4; i++)
                                {
                                    Score[i] = DefaultScore;
                                }
                                break;
                            }
                        case 5:
                            {
                                T1Result.Text = DefaultScore.ToString();
                                T2Result.Text = DefaultScore.ToString();
                                T3Result.Text = DefaultScore.ToString();
                                T4Result.Text = DefaultScore.ToString();
                                T5Result.Text = DefaultScore.ToString();
                                for (int i = 0; i < 5; i++)
                                {
                                    Score[i] = DefaultScore;
                                }
                                break;

                            }
                        case 6:
                            {
                                T1Result.Text = DefaultScore.ToString();
                                T2Result.Text = DefaultScore.ToString();
                                T3Result.Text = DefaultScore.ToString();
                                T4Result.Text = DefaultScore.ToString();
                                T5Result.Text = DefaultScore.ToString();
                                T6Result.Text = DefaultScore.ToString();
                                for (int i = 0; i < 6; i++)
                                {
                                    Score[i] = DefaultScore;
                                }
                                break;

                            }
                    }
                    Team1.Focus();
                }
                else
                {
                    Team1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void newCompetitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Current Competition will be closed.Do you want to continue?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    exited = true;
                    this.Close();

                    if (MessageBox.Show("Do you want to use previous competition's value?", "Use Values?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        Setting s = new Setting();
                        CoreInfo.BGColor = Color.White;
                        CoreInfo.CompetitionName = null;
                        CoreInfo.decrements = '\0';
                        CoreInfo.EliminationShortcut = null;
                        CoreInfo.HTID = 0;
                        CoreInfo.increments = '\0';
                        CoreInfo.IS = 0;
                        CoreInfo.IsLevel = false;
                        CoreInfo.NOT = 0;
                        CoreInfo.NOV = 0;
                        CoreInfo.PrizeList = null;
                        CoreInfo.PScore = 0;
                        CoreInfo.PShortcut = null;
                        CoreInfo.RulesText = null;
                        CoreInfo.team1name = null;
                        CoreInfo.team2name = null;
                        CoreInfo.team3name = null;
                        CoreInfo.team4name = null;
                        CoreInfo.team5name = null;
                        CoreInfo.team6name = null;
                        CoreInfo.TeamScore = null;
                        CoreInfo.TextBoxColor = Color.White;
                        s.ShowDialog();
                        if (Team1.Enabled == false)
                            SelectNextControl(Team1, true, true, true, true);
                        else
                        {
                            Team1.Focus();
                        }
                    }
                    else
                    {
                        DValues v = new DValues();
                        v.ShowDialog();
                        if (Team1.Enabled == false)
                            SelectNextControl(Team1, true, true, true, true);
                        else
                        {
                            Team1.Focus();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void End_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you really want to end this comptition?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    exited = true;
                    using (StreamWriter s = new StreamWriter(CoreInfo.Directory + CoreInfo.CompetitionName + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".txt", true))
                    {
                        switch (CoreInfo.NOT)
                        {
                            case 2:
                                {
                                    s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                    s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                    s.WriteLine("----------------------");
                                    T1Result.Text = DefaultScore.ToString();
                                    T2Result.Text = DefaultScore.ToString();
                                    for (int i = 0; i < 2; i++)
                                    {
                                        Score[i] = DefaultScore;
                                    }

                                    break;
                                }
                            case 3:
                                {
                                    s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                    s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                    s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                    s.WriteLine("----------------------");
                                    T1Result.Text = DefaultScore.ToString();
                                    T2Result.Text = DefaultScore.ToString();
                                    T3Result.Text = DefaultScore.ToString();
                                    for (int i = 0; i < 3; i++)
                                    {
                                        Score[i] = DefaultScore;
                                    }

                                    break;
                                }
                            case 4:
                                {
                                    s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                    s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                    s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                    s.WriteLine(label4Team.Text + "=" + T4Result.Text);
                                    s.WriteLine("----------------------");
                                    T1Result.Text = DefaultScore.ToString();
                                    T2Result.Text = DefaultScore.ToString();
                                    T3Result.Text = DefaultScore.ToString();
                                    T4Result.Text = DefaultScore.ToString();
                                    for (int i = 0; i < 4; i++)
                                    {
                                        Score[i] = DefaultScore;
                                    }

                                    break;
                                }
                            case 5:
                                {
                                    s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                    s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                    s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                    s.WriteLine(label4Team.Text + "=" + T4Result.Text);
                                    s.WriteLine(label5Team.Text + "=" + T5Result.Text);
                                    s.WriteLine("----------------------");
                                    T1Result.Text = DefaultScore.ToString();
                                    T2Result.Text = DefaultScore.ToString();
                                    T3Result.Text = DefaultScore.ToString();
                                    T4Result.Text = DefaultScore.ToString();
                                    T5Result.Text = DefaultScore.ToString();
                                    for (int i = 0; i < 5; i++)
                                    {
                                        Score[i] = DefaultScore;
                                    }
                                    break;

                                }
                            case 6:
                                {

                                    s.WriteLine(label1Team.Text + "=" + T1Result.Text);
                                    s.WriteLine(label2Team.Text + "=" + T2Result.Text);
                                    s.WriteLine(label3Team.Text + "=" + T3Result.Text);
                                    s.WriteLine(label4Team.Text + "=" + T4Result.Text);
                                    s.WriteLine(label5Team.Text + "=" + T5Result.Text);
                                    s.WriteLine(label6Team.Text + "=" + T6Result.Text);
                                    s.WriteLine("----------------------");
                                    T1Result.Text = DefaultScore.ToString();
                                    T2Result.Text = DefaultScore.ToString();
                                    T3Result.Text = DefaultScore.ToString();
                                    T4Result.Text = DefaultScore.ToString();
                                    T5Result.Text = DefaultScore.ToString();
                                    T6Result.Text = DefaultScore.ToString();
                                    for (int i = 0; i < 6; i++)
                                    {
                                        Score[i] = DefaultScore;
                                    }
                                    break;

                                }

                        }
                        s.Close();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AboutBox ab = new AboutBox();
                ab.ShowDialog();
                if (Team1.Enabled == false)
                    SelectNextControl(Team1, true, true, true, true);
                else
                {
                    Team1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team1_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Team1.BackColor != Color.Red && Team1.BackColor != Color.DarkRed && Team1.BackColor != Color.IndianRed && Team1.BackColor != Color.MediumVioletRed && Team1.BackColor != Color.OrangeRed && Team1.BackColor != Color.PaleVioletRed)
                    Team1.BackColor = Color.Red;
                else
                {
                    Team1.BackColor = Color.BlueViolet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team1_Leave(object sender, EventArgs e)
        {
            try
            {
                Team1.BackColor = CoreInfo.TextBoxColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team2_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Team2.BackColor != Color.Red && Team2.BackColor != Color.DarkRed && Team2.BackColor != Color.IndianRed && Team2.BackColor != Color.MediumVioletRed && Team2.BackColor != Color.OrangeRed && Team2.BackColor != Color.PaleVioletRed)
                    Team2.BackColor = Color.Red;
                else
                {
                    Team2.BackColor = Color.BlueViolet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }

        }

        private void Team2_Leave(object sender, EventArgs e)
        {
            try
            {
                Team2.BackColor = CoreInfo.TextBoxColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team3_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Team3.BackColor != Color.Red && Team3.BackColor != Color.DarkRed && Team3.BackColor != Color.IndianRed && Team3.BackColor != Color.MediumVioletRed && Team3.BackColor != Color.OrangeRed && Team3.BackColor != Color.PaleVioletRed)
                    Team3.BackColor = Color.Red;
                else
                {
                    Team3.BackColor = Color.BlueViolet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }

        }

        private void Team3_Leave(object sender, EventArgs e)
        {
            try
            {
                Team3.BackColor = CoreInfo.TextBoxColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team4_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Team4.BackColor != Color.Red && Team4.BackColor != Color.DarkRed && Team4.BackColor != Color.IndianRed && Team4.BackColor != Color.MediumVioletRed && Team4.BackColor != Color.OrangeRed && Team4.BackColor != Color.PaleVioletRed)
                    Team4.BackColor = Color.Red;
                else
                {
                    Team4.BackColor = Color.BlueViolet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }

        }

        private void Team4_Leave(object sender, EventArgs e)
        {
            try
            {
                Team4.BackColor = CoreInfo.TextBoxColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team5_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Team5.BackColor != Color.Red && Team5.BackColor != Color.DarkRed && Team5.BackColor != Color.IndianRed && Team5.BackColor != Color.MediumVioletRed && Team5.BackColor != Color.OrangeRed && Team5.BackColor != Color.PaleVioletRed)
                    Team5.BackColor = Color.Red;
                else
                {
                    Team5.BackColor = Color.BlueViolet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team5_Leave(object sender, EventArgs e)
        {
            try
            {
                Team5.BackColor = CoreInfo.TextBoxColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Team6_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Team6.BackColor != Color.Red && Team6.BackColor != Color.DarkRed && Team6.BackColor != Color.IndianRed && Team6.BackColor != Color.MediumVioletRed && Team6.BackColor != Color.OrangeRed && Team6.BackColor != Color.PaleVioletRed)
                    Team6.BackColor = Color.Red;
                else
                {
                    Team6.BackColor = Color.BlueViolet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }

        }

        private void Team6_Leave(object sender, EventArgs e)
        {
            try
            {
                Team6.BackColor = CoreInfo.TextBoxColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }



        private void changeBackGroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1.FullOpen = true;
                colorDialog1.AllowFullOpen = true;
                colorDialog1.ShowDialog();
                if (colorDialog1.Color.Name != "Black")
                {
                    Color cb = colorDialog1.Color;
                    this.BackColor = cb;
                }
                else
                {
                    MessageBox.Show("Black is not allowed! \nChoose any other color", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CompetitionName.BackColor = this.BackColor;
                if (Team1.Enabled == false)
                    SelectNextControl(Team1, true, true, true, true);
                else
                {
                    Team1.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void changeTextBoxColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1.FullOpen = true;
                colorDialog1.AllowFullOpen = true;
                colorDialog1.ShowDialog();
                CoreInfo.TextBoxColor = colorDialog1.Color;
                Team1.BackColor = CoreInfo.TextBoxColor;
                Team2.BackColor = CoreInfo.TextBoxColor;
                Team3.BackColor = CoreInfo.TextBoxColor;
                Team4.BackColor = CoreInfo.TextBoxColor;
                Team5.BackColor = CoreInfo.TextBoxColor;
                Team6.BackColor = CoreInfo.TextBoxColor;
                if (Team1.Enabled == false)
                    SelectNextControl(Team1, true, true, true, true);
                else
                {
                    Team1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                using (System.IO.StreamWriter s = new StreamWriter(CoreInfo.Directory + CoreInfo.CompetitionName + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".txt", true))
                {
                    s.WriteLine("Competition ended on " + DateTime.Now);
                    s.WriteLine("--------------------------Competition Ended-----------------------------");
                    s.Close();
                }
                if (MessageBox.Show("The Summary of this competition is recorded in the following link" + "\n" + CoreInfo.Directory + CoreInfo.CompetitionName + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".txt" + "\n" + "Do you want to open it now?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ProcessStartInfo s = new ProcessStartInfo(CoreInfo.Directory + CoreInfo.CompetitionName + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".txt");
                    s.CreateNoWindow = false;
                    Process.Start(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1.ShowDialog();
                if (colorDialog1.Color != null)
                {
                    label1Team.ForeColor = colorDialog1.Color;
                    label2Team.ForeColor = colorDialog1.Color;
                    label3Team.ForeColor = colorDialog1.Color;
                    label4Team.ForeColor = colorDialog1.Color;
                    label5Team.ForeColor = colorDialog1.Color;
                    label6Team.ForeColor = colorDialog1.Color;
                    if (Team1.Enabled == false)
                        SelectNextControl(Team1, true, true, true, true);
                    else
                    {
                        Team1.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry we have encountered a problem \nStats for nerds: " + ex.Message);
            }
        }

        private void changeScoringSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelSettings l = new LevelSettings();
            l.ShowDialog(); if (Team1.Enabled == false)
                SelectNextControl(Team1, true, true, true, true);
            else
            {
                Team1.Focus();
            }
        }

    }
}

