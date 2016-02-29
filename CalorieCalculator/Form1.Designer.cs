namespace CalorieCalculator
{
    partial class frmHealthClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHealthClub));
            this.tooHealthClub = new System.Windows.Forms.ToolTip(this.components);
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radInactive = new System.Windows.Forms.RadioButton();
            this.radActive = new System.Windows.Forms.RadioButton();
            this.txtWeightKgs = new System.Windows.Forms.TextBox();
            this.txtWeightLbs = new System.Windows.Forms.TextBox();
            this.txtTotalDailyCalories = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.grpActivityLevel = new System.Windows.Forms.GroupBox();
            this.grpWeightSelect = new System.Windows.Forms.GroupBox();
            this.lblWeightKgs = new System.Windows.Forms.Label();
            this.lblWieghtLbs = new System.Windows.Forms.Label();
            this.lblTotalDailyCalories = new System.Windows.Forms.Label();
            this.lblRippedClubCalculator = new System.Windows.Forms.Label();
            this.grpGender.SuspendLayout();
            this.grpActivityLevel.SuspendLayout();
            this.grpWeightSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(50, 87);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 20);
            this.txtFirstName.TabIndex = 0;
            this.tooHealthClub.SetToolTip(this.txtFirstName, "Enter you first name here.");
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(251, 87);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 20);
            this.txtLastName.TabIndex = 1;
            this.tooHealthClub.SetToolTip(this.txtLastName, "Enter your last name here.");
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(23, 91);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.tooHealthClub.SetToolTip(this.radFemale, "Choose this if you are female.");
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(23, 43);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.tooHealthClub.SetToolTip(this.radMale, "Choose this if you are male.");
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radInactive
            // 
            this.radInactive.AutoSize = true;
            this.radInactive.Location = new System.Drawing.Point(14, 91);
            this.radInactive.Name = "radInactive";
            this.radInactive.Size = new System.Drawing.Size(63, 17);
            this.radInactive.TabIndex = 1;
            this.radInactive.TabStop = true;
            this.radInactive.Text = "Inactive";
            this.tooHealthClub.SetToolTip(this.radInactive, "Choose this if you have an inactive lifestyle. ex No exercise, no sports ...");
            this.radInactive.UseVisualStyleBackColor = true;
            // 
            // radActive
            // 
            this.radActive.AutoSize = true;
            this.radActive.Location = new System.Drawing.Point(14, 43);
            this.radActive.Name = "radActive";
            this.radActive.Size = new System.Drawing.Size(55, 17);
            this.radActive.TabIndex = 0;
            this.radActive.TabStop = true;
            this.radActive.Text = "Active";
            this.tooHealthClub.SetToolTip(this.radActive, "Choose this if you have an active lifestyle. ex Play sports, visit the gym..");
            this.radActive.UseVisualStyleBackColor = true;
            // 
            // txtWeightKgs
            // 
            this.txtWeightKgs.Location = new System.Drawing.Point(114, 86);
            this.txtWeightKgs.Name = "txtWeightKgs";
            this.txtWeightKgs.Size = new System.Drawing.Size(100, 20);
            this.txtWeightKgs.TabIndex = 1;
            this.txtWeightKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tooHealthClub.SetToolTip(this.txtWeightKgs, "Enter your weight in kilos here.");
            // 
            // txtWeightLbs
            // 
            this.txtWeightLbs.Location = new System.Drawing.Point(114, 38);
            this.txtWeightLbs.Name = "txtWeightLbs";
            this.txtWeightLbs.Size = new System.Drawing.Size(100, 20);
            this.txtWeightLbs.TabIndex = 0;
            this.txtWeightLbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tooHealthClub.SetToolTip(this.txtWeightLbs, "Enter your weight in pounds here.");
            // 
            // txtTotalDailyCalories
            // 
            this.txtTotalDailyCalories.Enabled = false;
            this.txtTotalDailyCalories.Location = new System.Drawing.Point(295, 351);
            this.txtTotalDailyCalories.Name = "txtTotalDailyCalories";
            this.txtTotalDailyCalories.Size = new System.Drawing.Size(64, 20);
            this.txtTotalDailyCalories.TabIndex = 5;
            this.txtTotalDailyCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tooHealthClub.SetToolTip(this.txtTotalDailyCalories, "This displays your daily recommedned calorie intake.");
            // 
            // btnCalculate
            // 
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(375, 351);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.tooHealthClub.SetToolTip(this.btnCalculate, "Pressing this will calculate your daily recommendeed calorie intake based on the " +
                    "information you provide.\r\nShortcut: alt + c");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(456, 351);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Cl&ear";
            this.tooHealthClub.SetToolTip(this.btnClear, "Pressing this will clear the form.\r\nShortcut: alt + E");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(456, 396);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.tooHealthClub.SetToolTip(this.btnExit, "Pressing this will exit the program.\r\nShortcut: alt + X");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(47, 58);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(248, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // grpGender
            // 
            this.grpGender.BackColor = System.Drawing.Color.Red;
            this.grpGender.Controls.Add(this.radFemale);
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Location = new System.Drawing.Point(50, 152);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(111, 174);
            this.grpGender.TabIndex = 2;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // grpActivityLevel
            // 
            this.grpActivityLevel.Controls.Add(this.radInactive);
            this.grpActivityLevel.Controls.Add(this.radActive);
            this.grpActivityLevel.Location = new System.Drawing.Point(167, 152);
            this.grpActivityLevel.Name = "grpActivityLevel";
            this.grpActivityLevel.Size = new System.Drawing.Size(111, 174);
            this.grpActivityLevel.TabIndex = 3;
            this.grpActivityLevel.TabStop = false;
            this.grpActivityLevel.Text = "Activity";
            // 
            // grpWeightSelect
            // 
            this.grpWeightSelect.Controls.Add(this.txtWeightKgs);
            this.grpWeightSelect.Controls.Add(this.txtWeightLbs);
            this.grpWeightSelect.Controls.Add(this.lblWeightKgs);
            this.grpWeightSelect.Controls.Add(this.lblWieghtLbs);
            this.grpWeightSelect.Location = new System.Drawing.Point(295, 152);
            this.grpWeightSelect.Name = "grpWeightSelect";
            this.grpWeightSelect.Size = new System.Drawing.Size(223, 174);
            this.grpWeightSelect.TabIndex = 4;
            this.grpWeightSelect.TabStop = false;
            this.grpWeightSelect.Text = "Weight Selection";
            // 
            // lblWeightKgs
            // 
            this.lblWeightKgs.AutoSize = true;
            this.lblWeightKgs.Location = new System.Drawing.Point(19, 86);
            this.lblWeightKgs.Name = "lblWeightKgs";
            this.lblWeightKgs.Size = new System.Drawing.Size(76, 13);
            this.lblWeightKgs.TabIndex = 1;
            this.lblWeightKgs.Text = "Weight In Kg\'s";
            // 
            // lblWieghtLbs
            // 
            this.lblWieghtLbs.AutoSize = true;
            this.lblWieghtLbs.Location = new System.Drawing.Point(19, 38);
            this.lblWieghtLbs.Name = "lblWieghtLbs";
            this.lblWieghtLbs.Size = new System.Drawing.Size(71, 13);
            this.lblWieghtLbs.TabIndex = 0;
            this.lblWieghtLbs.Text = "Weight in lbs.";
            // 
            // lblTotalDailyCalories
            // 
            this.lblTotalDailyCalories.AutoSize = true;
            this.lblTotalDailyCalories.Location = new System.Drawing.Point(17, 351);
            this.lblTotalDailyCalories.Name = "lblTotalDailyCalories";
            this.lblTotalDailyCalories.Size = new System.Drawing.Size(261, 13);
            this.lblTotalDailyCalories.TabIndex = 6;
            this.lblTotalDailyCalories.Text = "Suggested calorie intake to maintain current weight is:";
            // 
            // lblRippedClubCalculator
            // 
            this.lblRippedClubCalculator.AutoSize = true;
            this.lblRippedClubCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRippedClubCalculator.Location = new System.Drawing.Point(47, 18);
            this.lblRippedClubCalculator.Name = "lblRippedClubCalculator";
            this.lblRippedClubCalculator.Size = new System.Drawing.Size(455, 29);
            this.lblRippedClubCalculator.TabIndex = 9;
            this.lblRippedClubCalculator.Text = "Ripped Body Club Calories Calculator";
            // 
            // frmHealthClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(581, 437);
            this.Controls.Add(this.lblRippedClubCalculator);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpActivityLevel);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalDailyCalories);
            this.Controls.Add(this.lblTotalDailyCalories);
            this.Controls.Add(this.grpWeightSelect);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHealthClub";
            this.Text = "Ripped Body Club";
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpActivityLevel.ResumeLayout(false);
            this.grpActivityLevel.PerformLayout();
            this.grpWeightSelect.ResumeLayout(false);
            this.grpWeightSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip tooHealthClub;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.GroupBox grpActivityLevel;
        private System.Windows.Forms.RadioButton radInactive;
        private System.Windows.Forms.RadioButton radActive;
        private System.Windows.Forms.GroupBox grpWeightSelect;
        private System.Windows.Forms.TextBox txtWeightKgs;
        private System.Windows.Forms.TextBox txtWeightLbs;
        private System.Windows.Forms.Label lblWeightKgs;
        private System.Windows.Forms.Label lblWieghtLbs;
        private System.Windows.Forms.Label lblTotalDailyCalories;
        private System.Windows.Forms.TextBox txtTotalDailyCalories;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRippedClubCalculator;
    }
}

