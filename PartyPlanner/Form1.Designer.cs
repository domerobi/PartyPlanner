namespace PartyPlanner
{
    partial class partyForm
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
            this.peopleNum = new System.Windows.Forms.NumericUpDown();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.decorationChk = new System.Windows.Forms.CheckBox();
            this.healthyChk = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dinnerPage = new System.Windows.Forms.TabPage();
            this.birthdayPage = new System.Windows.Forms.TabPage();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.cakeWritingLabel = new System.Windows.Forms.Label();
            this.numberBirthdayLabel = new System.Windows.Forms.Label();
            this.costBirthday = new System.Windows.Forms.Label();
            this.numBirthday = new System.Windows.Forms.NumericUpDown();
            this.costBirthdayLabel = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.peopleNum)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.dinnerPage.SuspendLayout();
            this.birthdayPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleNum
            // 
            this.peopleNum.Location = new System.Drawing.Point(131, 13);
            this.peopleNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.peopleNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.peopleNum.Name = "peopleNum";
            this.peopleNum.Size = new System.Drawing.Size(61, 20);
            this.peopleNum.TabIndex = 0;
            this.peopleNum.Tag = "";
            this.peopleNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.peopleNum.ValueChanged += new System.EventHandler(this.peopleNum_ValueChanged);
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peopleLabel.Location = new System.Drawing.Point(3, 13);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(122, 17);
            this.peopleLabel.TabIndex = 1;
            this.peopleLabel.Text = "Number of People";
            // 
            // decorationChk
            // 
            this.decorationChk.AutoSize = true;
            this.decorationChk.Checked = true;
            this.decorationChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.decorationChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decorationChk.Location = new System.Drawing.Point(6, 57);
            this.decorationChk.Name = "decorationChk";
            this.decorationChk.Size = new System.Drawing.Size(138, 21);
            this.decorationChk.TabIndex = 2;
            this.decorationChk.Text = "Fancy Decoration";
            this.decorationChk.UseVisualStyleBackColor = true;
            this.decorationChk.CheckedChanged += new System.EventHandler(this.decorationChk_CheckedChanged);
            // 
            // healthyChk
            // 
            this.healthyChk.AutoSize = true;
            this.healthyChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.healthyChk.Location = new System.Drawing.Point(6, 97);
            this.healthyChk.Name = "healthyChk";
            this.healthyChk.Size = new System.Drawing.Size(121, 21);
            this.healthyChk.TabIndex = 3;
            this.healthyChk.Text = "Healthy Option";
            this.healthyChk.UseVisualStyleBackColor = true;
            this.healthyChk.CheckedChanged += new System.EventHandler(this.healthyChk_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.costLabel.Location = new System.Drawing.Point(3, 145);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(40, 17);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost";
            // 
            // costBox
            // 
            this.costBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.costBox.Location = new System.Drawing.Point(50, 145);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(110, 23);
            this.costBox.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dinnerPage);
            this.tabControl1.Controls.Add(this.birthdayPage);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(268, 260);
            this.tabControl1.TabIndex = 6;
            // 
            // dinnerPage
            // 
            this.dinnerPage.Controls.Add(this.peopleLabel);
            this.dinnerPage.Controls.Add(this.costBox);
            this.dinnerPage.Controls.Add(this.peopleNum);
            this.dinnerPage.Controls.Add(this.costLabel);
            this.dinnerPage.Controls.Add(this.decorationChk);
            this.dinnerPage.Controls.Add(this.healthyChk);
            this.dinnerPage.Location = new System.Drawing.Point(4, 22);
            this.dinnerPage.Name = "dinnerPage";
            this.dinnerPage.Padding = new System.Windows.Forms.Padding(3);
            this.dinnerPage.Size = new System.Drawing.Size(260, 234);
            this.dinnerPage.TabIndex = 0;
            this.dinnerPage.Text = "Dinner Party";
            this.dinnerPage.UseVisualStyleBackColor = true;
            // 
            // birthdayPage
            // 
            this.birthdayPage.Controls.Add(this.cakeWriting);
            this.birthdayPage.Controls.Add(this.tooLongLabel);
            this.birthdayPage.Controls.Add(this.cakeWritingLabel);
            this.birthdayPage.Controls.Add(this.numberBirthdayLabel);
            this.birthdayPage.Controls.Add(this.costBirthday);
            this.birthdayPage.Controls.Add(this.numBirthday);
            this.birthdayPage.Controls.Add(this.costBirthdayLabel);
            this.birthdayPage.Controls.Add(this.fancyBirthday);
            this.birthdayPage.Location = new System.Drawing.Point(4, 22);
            this.birthdayPage.Name = "birthdayPage";
            this.birthdayPage.Padding = new System.Windows.Forms.Padding(3);
            this.birthdayPage.Size = new System.Drawing.Size(260, 234);
            this.birthdayPage.TabIndex = 1;
            this.birthdayPage.Text = "Birthday Party";
            this.birthdayPage.UseVisualStyleBackColor = true;
            // 
            // cakeWriting
            // 
            this.cakeWriting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cakeWriting.Location = new System.Drawing.Point(12, 142);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(186, 23);
            this.cakeWriting.TabIndex = 13;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tooLongLabel.Location = new System.Drawing.Point(115, 98);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(83, 17);
            this.tooLongLabel.TabIndex = 12;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // cakeWritingLabel
            // 
            this.cakeWritingLabel.AutoSize = true;
            this.cakeWritingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cakeWritingLabel.Location = new System.Drawing.Point(12, 98);
            this.cakeWritingLabel.Name = "cakeWritingLabel";
            this.cakeWritingLabel.Size = new System.Drawing.Size(88, 17);
            this.cakeWritingLabel.TabIndex = 11;
            this.cakeWritingLabel.Text = "Cake Writing";
            // 
            // numberBirthdayLabel
            // 
            this.numberBirthdayLabel.AutoSize = true;
            this.numberBirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberBirthdayLabel.Location = new System.Drawing.Point(9, 14);
            this.numberBirthdayLabel.Name = "numberBirthdayLabel";
            this.numberBirthdayLabel.Size = new System.Drawing.Size(122, 17);
            this.numberBirthdayLabel.TabIndex = 7;
            this.numberBirthdayLabel.Text = "Number of People";
            // 
            // costBirthday
            // 
            this.costBirthday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.costBirthday.Location = new System.Drawing.Point(56, 192);
            this.costBirthday.Name = "costBirthday";
            this.costBirthday.Size = new System.Drawing.Size(142, 23);
            this.costBirthday.TabIndex = 10;
            // 
            // numBirthday
            // 
            this.numBirthday.Location = new System.Drawing.Point(137, 14);
            this.numBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBirthday.Name = "numBirthday";
            this.numBirthday.Size = new System.Drawing.Size(61, 20);
            this.numBirthday.TabIndex = 6;
            this.numBirthday.Tag = "";
            this.numBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBirthday.ValueChanged += new System.EventHandler(this.numBirthday_ValueChanged);
            // 
            // costBirthdayLabel
            // 
            this.costBirthdayLabel.AutoSize = true;
            this.costBirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.costBirthdayLabel.Location = new System.Drawing.Point(9, 192);
            this.costBirthdayLabel.Name = "costBirthdayLabel";
            this.costBirthdayLabel.Size = new System.Drawing.Size(40, 17);
            this.costBirthdayLabel.TabIndex = 9;
            this.costBirthdayLabel.Text = "Cost";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Checked = true;
            this.fancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fancyBirthday.Location = new System.Drawing.Point(12, 56);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(138, 21);
            this.fancyBirthday.TabIndex = 8;
            this.fancyBirthday.Text = "Fancy Decoration";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // partyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 262);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "partyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.peopleNum)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.dinnerPage.ResumeLayout(false);
            this.dinnerPage.PerformLayout();
            this.birthdayPage.ResumeLayout(false);
            this.birthdayPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown peopleNum;
        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.CheckBox decorationChk;
        private System.Windows.Forms.CheckBox healthyChk;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label costBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dinnerPage;
        private System.Windows.Forms.TabPage birthdayPage;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label cakeWritingLabel;
        private System.Windows.Forms.Label numberBirthdayLabel;
        private System.Windows.Forms.Label costBirthday;
        private System.Windows.Forms.NumericUpDown numBirthday;
        private System.Windows.Forms.Label costBirthdayLabel;
        private System.Windows.Forms.CheckBox fancyBirthday;
    }
}

