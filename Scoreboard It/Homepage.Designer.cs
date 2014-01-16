namespace Scoreboard_It
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Team2 = new System.Windows.Forms.TextBox();
            this.Team4 = new System.Windows.Forms.TextBox();
            this.Team5 = new System.Windows.Forms.TextBox();
            this.Team6 = new System.Windows.Forms.TextBox();
            this.T2Result = new System.Windows.Forms.TextBox();
            this.T4Result = new System.Windows.Forms.TextBox();
            this.T5Result = new System.Windows.Forms.TextBox();
            this.T6Result = new System.Windows.Forms.TextBox();
            this.label2Team = new System.Windows.Forms.Label();
            this.label4Team = new System.Windows.Forms.Label();
            this.label5Team = new System.Windows.Forms.Label();
            this.label6Team = new System.Windows.Forms.Label();
            this.Team4Container = new System.Windows.Forms.GroupBox();
            this.Team5Container = new System.Windows.Forms.GroupBox();
            this.Team2Container = new System.Windows.Forms.GroupBox();
            this.Team6Container = new System.Windows.Forms.GroupBox();
            this.Team3Container = new System.Windows.Forms.GroupBox();
            this.label3Team = new System.Windows.Forms.Label();
            this.T3Result = new System.Windows.Forms.TextBox();
            this.Team3 = new System.Windows.Forms.TextBox();
            this.Team1Container = new System.Windows.Forms.GroupBox();
            this.label1Team = new System.Windows.Forms.Label();
            this.T1Result = new System.Windows.Forms.TextBox();
            this.Team1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCompetionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackGroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextBoxColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScoringSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RulesShow = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CompetitionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Team4Container.SuspendLayout();
            this.Team5Container.SuspendLayout();
            this.Team2Container.SuspendLayout();
            this.Team6Container.SuspendLayout();
            this.Team3Container.SuspendLayout();
            this.Team1Container.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Team2
            // 
            this.Team2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Team2.Location = new System.Drawing.Point(13, 33);
            this.Team2.Multiline = true;
            this.Team2.Name = "Team2";
            this.Team2.Size = new System.Drawing.Size(377, 74);
            this.Team2.TabIndex = 2;
            this.Team2.TextChanged += new System.EventHandler(this.Team2_KeyPress);
            this.Team2.Enter += new System.EventHandler(this.Team2_Enter);
            this.Team2.Leave += new System.EventHandler(this.Team2_Leave);
            // 
            // Team4
            // 
            this.Team4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Team4.Location = new System.Drawing.Point(17, 32);
            this.Team4.Multiline = true;
            this.Team4.Name = "Team4";
            this.Team4.Size = new System.Drawing.Size(377, 74);
            this.Team4.TabIndex = 4;
            this.Team4.TextChanged += new System.EventHandler(this.Team4_KeyPress);
            this.Team4.Enter += new System.EventHandler(this.Team4_Enter);
            this.Team4.Leave += new System.EventHandler(this.Team4_Leave);
            // 
            // Team5
            // 
            this.Team5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Team5.Location = new System.Drawing.Point(13, 36);
            this.Team5.Multiline = true;
            this.Team5.Name = "Team5";
            this.Team5.Size = new System.Drawing.Size(395, 74);
            this.Team5.TabIndex = 5;
            this.Team5.TextChanged += new System.EventHandler(this.Team5_KeyPress);
            this.Team5.Enter += new System.EventHandler(this.Team5_Enter);
            this.Team5.Leave += new System.EventHandler(this.Team5_Leave);
            // 
            // Team6
            // 
            this.Team6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Team6.Location = new System.Drawing.Point(18, 36);
            this.Team6.Multiline = true;
            this.Team6.Name = "Team6";
            this.Team6.Size = new System.Drawing.Size(377, 74);
            this.Team6.TabIndex = 6;
            this.Team6.TextChanged += new System.EventHandler(this.Team6_KeyPress);
            this.Team6.Enter += new System.EventHandler(this.Team6_Enter);
            this.Team6.Leave += new System.EventHandler(this.Team6_Leave);
            // 
            // T2Result
            // 
            this.T2Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2Result.ForeColor = System.Drawing.Color.Blue;
            this.T2Result.Location = new System.Drawing.Point(157, 33);
            this.T2Result.MaxLength = 5;
            this.T2Result.Multiline = true;
            this.T2Result.Name = "T2Result";
            this.T2Result.ReadOnly = true;
            this.T2Result.Size = new System.Drawing.Size(233, 74);
            this.T2Result.TabIndex = 2;
            this.T2Result.TabStop = false;
            this.T2Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T4Result
            // 
            this.T4Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T4Result.ForeColor = System.Drawing.Color.Blue;
            this.T4Result.Location = new System.Drawing.Point(158, 32);
            this.T4Result.MaxLength = 5;
            this.T4Result.Multiline = true;
            this.T4Result.Name = "T4Result";
            this.T4Result.ReadOnly = true;
            this.T4Result.Size = new System.Drawing.Size(236, 74);
            this.T4Result.TabIndex = 2;
            this.T4Result.TabStop = false;
            this.T4Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T5Result
            // 
            this.T5Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T5Result.ForeColor = System.Drawing.Color.Blue;
            this.T5Result.Location = new System.Drawing.Point(158, 36);
            this.T5Result.MaxLength = 5;
            this.T5Result.Multiline = true;
            this.T5Result.Name = "T5Result";
            this.T5Result.ReadOnly = true;
            this.T5Result.Size = new System.Drawing.Size(250, 74);
            this.T5Result.TabIndex = 2;
            this.T5Result.TabStop = false;
            this.T5Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T6Result
            // 
            this.T6Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T6Result.ForeColor = System.Drawing.Color.Blue;
            this.T6Result.Location = new System.Drawing.Point(158, 36);
            this.T6Result.MaxLength = 5;
            this.T6Result.Multiline = true;
            this.T6Result.Name = "T6Result";
            this.T6Result.ReadOnly = true;
            this.T6Result.Size = new System.Drawing.Size(237, 74);
            this.T6Result.TabIndex = 2;
            this.T6Result.TabStop = false;
            this.T6Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2Team
            // 
            this.label2Team.AutoSize = true;
            this.label2Team.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Team.Location = new System.Drawing.Point(9, 8);
            this.label2Team.Name = "label2Team";
            this.label2Team.Size = new System.Drawing.Size(104, 22);
            this.label2Team.TabIndex = 6;
            this.label2Team.Text = "label1Team";
            // 
            // label4Team
            // 
            this.label4Team.AutoSize = true;
            this.label4Team.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Team.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4Team.Location = new System.Drawing.Point(14, 9);
            this.label4Team.Name = "label4Team";
            this.label4Team.Size = new System.Drawing.Size(104, 22);
            this.label4Team.TabIndex = 6;
            this.label4Team.Text = "label1Team";
            // 
            // label5Team
            // 
            this.label5Team.AutoSize = true;
            this.label5Team.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5Team.Location = new System.Drawing.Point(10, 14);
            this.label5Team.Name = "label5Team";
            this.label5Team.Size = new System.Drawing.Size(104, 22);
            this.label5Team.TabIndex = 6;
            this.label5Team.Text = "label1Team";
            // 
            // label6Team
            // 
            this.label6Team.AutoSize = true;
            this.label6Team.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6Team.Location = new System.Drawing.Point(14, 11);
            this.label6Team.Name = "label6Team";
            this.label6Team.Size = new System.Drawing.Size(104, 22);
            this.label6Team.TabIndex = 6;
            this.label6Team.Text = "label1Team";
            // 
            // Team4Container
            // 
            this.Team4Container.Controls.Add(this.label4Team);
            this.Team4Container.Controls.Add(this.T4Result);
            this.Team4Container.Controls.Add(this.Team4);
            this.Team4Container.ForeColor = System.Drawing.Color.Transparent;
            this.Team4Container.Location = new System.Drawing.Point(770, 258);
            this.Team4Container.Name = "Team4Container";
            this.Team4Container.Size = new System.Drawing.Size(413, 124);
            this.Team4Container.TabIndex = 0;
            this.Team4Container.TabStop = false;
            this.Team4Container.Visible = false;
            // 
            // Team5Container
            // 
            this.Team5Container.Controls.Add(this.label5Team);
            this.Team5Container.Controls.Add(this.T5Result);
            this.Team5Container.Controls.Add(this.Team5);
            this.Team5Container.Location = new System.Drawing.Point(152, 388);
            this.Team5Container.Name = "Team5Container";
            this.Team5Container.Size = new System.Drawing.Size(415, 130);
            this.Team5Container.TabIndex = 0;
            this.Team5Container.TabStop = false;
            this.Team5Container.Visible = false;
            // 
            // Team2Container
            // 
            this.Team2Container.Controls.Add(this.label2Team);
            this.Team2Container.Controls.Add(this.T2Result);
            this.Team2Container.Controls.Add(this.Team2);
            this.Team2Container.Location = new System.Drawing.Point(771, 132);
            this.Team2Container.Name = "Team2Container";
            this.Team2Container.Size = new System.Drawing.Size(412, 126);
            this.Team2Container.TabIndex = 0;
            this.Team2Container.TabStop = false;
            this.Team2Container.Visible = false;
            // 
            // Team6Container
            // 
            this.Team6Container.Controls.Add(this.label6Team);
            this.Team6Container.Controls.Add(this.T6Result);
            this.Team6Container.Controls.Add(this.Team6);
            this.Team6Container.Location = new System.Drawing.Point(770, 388);
            this.Team6Container.Name = "Team6Container";
            this.Team6Container.Size = new System.Drawing.Size(412, 130);
            this.Team6Container.TabIndex = 0;
            this.Team6Container.TabStop = false;
            this.Team6Container.Visible = false;
            // 
            // Team3Container
            // 
            this.Team3Container.Controls.Add(this.label3Team);
            this.Team3Container.Controls.Add(this.T3Result);
            this.Team3Container.Controls.Add(this.Team3);
            this.Team3Container.Location = new System.Drawing.Point(151, 258);
            this.Team3Container.Name = "Team3Container";
            this.Team3Container.Size = new System.Drawing.Size(416, 124);
            this.Team3Container.TabIndex = 0;
            this.Team3Container.TabStop = false;
            this.Team3Container.Visible = false;
            // 
            // label3Team
            // 
            this.label3Team.AutoSize = true;
            this.label3Team.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Team.Location = new System.Drawing.Point(10, 9);
            this.label3Team.Name = "label3Team";
            this.label3Team.Size = new System.Drawing.Size(104, 22);
            this.label3Team.TabIndex = 6;
            this.label3Team.Text = "label1Team";
            // 
            // T3Result
            // 
            this.T3Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T3Result.ForeColor = System.Drawing.Color.Blue;
            this.T3Result.Location = new System.Drawing.Point(159, 32);
            this.T3Result.MaxLength = 5;
            this.T3Result.Multiline = true;
            this.T3Result.Name = "T3Result";
            this.T3Result.ReadOnly = true;
            this.T3Result.Size = new System.Drawing.Size(250, 74);
            this.T3Result.TabIndex = 2;
            this.T3Result.TabStop = false;
            this.T3Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Team3
            // 
            this.Team3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Team3.Location = new System.Drawing.Point(13, 32);
            this.Team3.Multiline = true;
            this.Team3.Name = "Team3";
            this.Team3.Size = new System.Drawing.Size(396, 74);
            this.Team3.TabIndex = 3;
            this.Team3.TextChanged += new System.EventHandler(this.Team3_KeyPress);
            this.Team3.Enter += new System.EventHandler(this.Team3_Enter);
            this.Team3.Leave += new System.EventHandler(this.Team3_Leave);
            // 
            // Team1Container
            // 
            this.Team1Container.Controls.Add(this.label1Team);
            this.Team1Container.Controls.Add(this.T1Result);
            this.Team1Container.Controls.Add(this.Team1);
            this.Team1Container.Location = new System.Drawing.Point(152, 132);
            this.Team1Container.Name = "Team1Container";
            this.Team1Container.Size = new System.Drawing.Size(414, 126);
            this.Team1Container.TabIndex = 0;
            this.Team1Container.TabStop = false;
            this.Team1Container.Visible = false;
            // 
            // label1Team
            // 
            this.label1Team.AutoSize = true;
            this.label1Team.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Team.Location = new System.Drawing.Point(12, 11);
            this.label1Team.Name = "label1Team";
            this.label1Team.Size = new System.Drawing.Size(104, 22);
            this.label1Team.TabIndex = 6;
            this.label1Team.Text = "label1Team";
            // 
            // T1Result
            // 
            this.T1Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1Result.ForeColor = System.Drawing.Color.Blue;
            this.T1Result.Location = new System.Drawing.Point(158, 33);
            this.T1Result.MaxLength = 5;
            this.T1Result.Multiline = true;
            this.T1Result.Name = "T1Result";
            this.T1Result.ReadOnly = true;
            this.T1Result.Size = new System.Drawing.Size(250, 74);
            this.T1Result.TabIndex = 2;
            this.T1Result.TabStop = false;
            this.T1Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Team1
            // 
            this.Team1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Team1.Location = new System.Drawing.Point(16, 33);
            this.Team1.Multiline = true;
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(392, 74);
            this.Team1.TabIndex = 1;
            this.Team1.TextChanged += new System.EventHandler(this.Team1_KeyPress);
            this.Team1.Enter += new System.EventHandler(this.Team1_Enter);
            this.Team1.Leave += new System.EventHandler(this.Team1_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1318, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCompetionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.newToolStripMenuItem.Text = "Competition";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newCompetionToolStripMenuItem
            // 
            this.newCompetionToolStripMenuItem.Name = "newCompetionToolStripMenuItem";
            this.newCompetionToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.newCompetionToolStripMenuItem.Text = "&New Competition (Alt + C + N)";
            this.newCompetionToolStripMenuItem.Click += new System.EventHandler(this.newCompetitionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fileToolStripMenuItem.Text = "Reset Score";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackGroundColorToolStripMenuItem,
            this.changeTextBoxColorToolStripMenuItem,
            this.changeTextColorToolStripMenuItem,
            this.changeScoringSystemToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeBackGroundColorToolStripMenuItem
            // 
            this.changeBackGroundColorToolStripMenuItem.Name = "changeBackGroundColorToolStripMenuItem";
            this.changeBackGroundColorToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.changeBackGroundColorToolStripMenuItem.Text = "Change &Background Color (Alt + S + B)";
            this.changeBackGroundColorToolStripMenuItem.Click += new System.EventHandler(this.changeBackGroundColorToolStripMenuItem_Click);
            // 
            // changeTextBoxColorToolStripMenuItem
            // 
            this.changeTextBoxColorToolStripMenuItem.Name = "changeTextBoxColorToolStripMenuItem";
            this.changeTextBoxColorToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.changeTextBoxColorToolStripMenuItem.Text = "Change &TextBox Color (Alt + S+ T)";
            this.changeTextBoxColorToolStripMenuItem.Click += new System.EventHandler(this.changeTextBoxColorToolStripMenuItem_Click);
            // 
            // changeTextColorToolStripMenuItem
            // 
            this.changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            this.changeTextColorToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.changeTextColorToolStripMenuItem.Text = "Change Text Color";
            this.changeTextColorToolStripMenuItem.Click += new System.EventHandler(this.changeTextColorToolStripMenuItem_Click);
            // 
            // changeScoringSystemToolStripMenuItem
            // 
            this.changeScoringSystemToolStripMenuItem.Name = "changeScoringSystemToolStripMenuItem";
            this.changeScoringSystemToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.changeScoringSystemToolStripMenuItem.Text = "Change &Scoring System (Alt + S +S)";
            this.changeScoringSystemToolStripMenuItem.Click += new System.EventHandler(this.changeScoringSystemToolStripMenuItem_Click);
            // 
            // RulesShow
            // 
            this.RulesShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.RulesShow.Location = new System.Drawing.Point(686, 549);
            this.RulesShow.Name = "RulesShow";
            this.RulesShow.Size = new System.Drawing.Size(192, 56);
            this.RulesShow.TabIndex = 8;
            this.RulesShow.TabStop = false;
            this.RulesShow.Text = "Show rules";
            this.RulesShow.UseVisualStyleBackColor = true;
            this.RulesShow.Click += new System.EventHandler(this.ShowRules_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(462, 549);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(218, 56);
            this.Reset.TabIndex = 7;
            this.Reset.TabStop = false;
            this.Reset.Text = "Move To Next Level";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Visible = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // End
            // 
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.Location = new System.Drawing.Point(562, 611);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(218, 56);
            this.End.TabIndex = 7;
            this.End.TabStop = false;
            this.End.Text = "End Competition";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // CompetitionName
            // 
            this.CompetitionName.Cursor = System.Windows.Forms.Cursors.Default;
            this.CompetitionName.Font = new System.Drawing.Font("MS Reference Sans Serif", 35F, System.Drawing.FontStyle.Underline);
            this.CompetitionName.ForeColor = System.Drawing.Color.Black;
            this.CompetitionName.Location = new System.Drawing.Point(-7, 19);
            this.CompetitionName.Multiline = true;
            this.CompetitionName.Name = "CompetitionName";
            this.CompetitionName.ReadOnly = true;
            this.CompetitionName.Size = new System.Drawing.Size(1389, 83);
            this.CompetitionName.TabIndex = 0;
            this.CompetitionName.TabStop = false;
            this.CompetitionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Move here to view the shortcuts";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1318, 737);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompetitionName);
            this.Controls.Add(this.RulesShow);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Team6Container);
            this.Controls.Add(this.Team2Container);
            this.Controls.Add(this.Team1Container);
            this.Controls.Add(this.Team5Container);
            this.Controls.Add(this.Team4Container);
            this.Controls.Add(this.Team3Container);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Scorboard It!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.Team4Container.ResumeLayout(false);
            this.Team4Container.PerformLayout();
            this.Team5Container.ResumeLayout(false);
            this.Team5Container.PerformLayout();
            this.Team2Container.ResumeLayout(false);
            this.Team2Container.PerformLayout();
            this.Team6Container.ResumeLayout(false);
            this.Team6Container.PerformLayout();
            this.Team3Container.ResumeLayout(false);
            this.Team3Container.PerformLayout();
            this.Team1Container.ResumeLayout(false);
            this.Team1Container.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Team2;
        private System.Windows.Forms.TextBox Team4;
        private System.Windows.Forms.TextBox Team5;
        private System.Windows.Forms.TextBox Team6;
        private System.Windows.Forms.TextBox T2Result;
        private System.Windows.Forms.TextBox T4Result;
        private System.Windows.Forms.TextBox T5Result;
        private System.Windows.Forms.TextBox T6Result;
        private System.Windows.Forms.Label label2Team;
        private System.Windows.Forms.Label label4Team;
        private System.Windows.Forms.Label label5Team;
        private System.Windows.Forms.Label label6Team;
        private System.Windows.Forms.GroupBox Team4Container;
        private System.Windows.Forms.GroupBox Team5Container;
        private System.Windows.Forms.GroupBox Team2Container;
        private System.Windows.Forms.GroupBox Team6Container;
        private System.Windows.Forms.GroupBox Team3Container;
        private System.Windows.Forms.Label label3Team;
        private System.Windows.Forms.TextBox T3Result;
        private System.Windows.Forms.TextBox Team3;
        private System.Windows.Forms.GroupBox Team1Container;
        private System.Windows.Forms.Label label1Team;
        private System.Windows.Forms.TextBox T1Result;
        private System.Windows.Forms.TextBox Team1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCompetionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button RulesShow;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackGroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTextBoxColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox CompetitionName;
        private System.Windows.Forms.ToolStripMenuItem changeTextColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeScoringSystemToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

