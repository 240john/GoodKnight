namespace GoodKnight
{
    partial class GoodKnight
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
            this.nudDifficulty = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtDifficulty = new System.Windows.Forms.TextBox();
            this.ttp1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.txtStory = new System.Windows.Forms.TextBox();
            this.txtArmor = new System.Windows.Forms.TextBox();
            this.cmbArmor = new System.Windows.Forms.ComboBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.cmbWeapon = new System.Windows.Forms.ComboBox();
            this.txtHealthLabel = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDifficulty
            // 
            this.nudDifficulty.Location = new System.Drawing.Point(99, 195);
            this.nudDifficulty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudDifficulty.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDifficulty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDifficulty.Name = "nudDifficulty";
            this.nudDifficulty.Size = new System.Drawing.Size(47, 22);
            this.nudDifficulty.TabIndex = 0;
            this.ttp1.SetToolTip(this.nudDifficulty, "1 = easy, 2 = medium, 3 = hard");
            this.nudDifficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDifficulty.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(597, 189);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 31);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.ttp1.SetToolTip(this.btnStart, "Choose your difficulty before starting");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtDifficulty
            // 
            this.txtDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDifficulty.Location = new System.Drawing.Point(28, 197);
            this.txtDifficulty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDifficulty.Name = "txtDifficulty";
            this.txtDifficulty.ReadOnly = true;
            this.txtDifficulty.Size = new System.Drawing.Size(65, 15);
            this.txtDifficulty.TabIndex = 2;
            this.txtDifficulty.Text = "Difficulty:";
            this.ttp1.SetToolTip(this.txtDifficulty, "1 = easy, 2 = medium, 3 = hard");
            this.txtDifficulty.TextChanged += new System.EventHandler(this.txtDifficulty_TextChanged);
            // 
            // txtChoice
            // 
            this.txtChoice.Enabled = false;
            this.txtChoice.Location = new System.Drawing.Point(29, 92);
            this.txtChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChoice.MinimumSize = new System.Drawing.Size(654, 65);
            this.txtChoice.Multiline = true;
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.ReadOnly = true;
            this.txtChoice.Size = new System.Drawing.Size(654, 65);
            this.txtChoice.TabIndex = 4;
            this.txtChoice.Text = "\r\n\r\n\r\n\r\n\r\n\r\n";
            this.ttp1.SetToolTip(this.txtChoice, "Story Choices");
            this.txtChoice.TextChanged += new System.EventHandler(this.txtChoice_TextChanged);
            // 
            // btn2
            // 
            this.btn2.Enabled = false;
            this.btn2.Location = new System.Drawing.Point(29, 162);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 29);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "1";
            this.ttp1.SetToolTip(this.btn2, "Choice 1");
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Enabled = false;
            this.btn3.Location = new System.Drawing.Point(114, 162);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 29);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "2";
            this.ttp1.SetToolTip(this.btn3, "Choice 2");
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Enabled = false;
            this.btn4.Location = new System.Drawing.Point(200, 162);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 29);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "3";
            this.ttp1.SetToolTip(this.btn4, "Choice 3");
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // txtStory
            // 
            this.txtStory.Enabled = false;
            this.txtStory.Location = new System.Drawing.Point(29, 18);
            this.txtStory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStory.MinimumSize = new System.Drawing.Size(654, 57);
            this.txtStory.Multiline = true;
            this.txtStory.Name = "txtStory";
            this.txtStory.ReadOnly = true;
            this.txtStory.Size = new System.Drawing.Size(654, 70);
            this.txtStory.TabIndex = 3;
            this.txtStory.Text = "Welcome to GoodKnight!\r\nChoose your difficulty in the bottom left, \r\nthen select " +
    "your class,\r\nand click start!\r\n\r\n\r\n\r\n\r\n";
            this.txtStory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStory.TextChanged += new System.EventHandler(this.txtStory_TextChanged);
            // 
            // txtArmor
            // 
            this.txtArmor.BackColor = System.Drawing.SystemColors.Control;
            this.txtArmor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArmor.Location = new System.Drawing.Point(289, 164);
            this.txtArmor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArmor.Name = "txtArmor";
            this.txtArmor.Size = new System.Drawing.Size(44, 15);
            this.txtArmor.TabIndex = 9;
            this.txtArmor.Text = "Armor:";
            // 
            // cmbArmor
            // 
            this.cmbArmor.FormattingEnabled = true;
            this.cmbArmor.Items.AddRange(new object[] {
            "Leather Armor"});
            this.cmbArmor.Location = new System.Drawing.Point(339, 161);
            this.cmbArmor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbArmor.Name = "cmbArmor";
            this.cmbArmor.Size = new System.Drawing.Size(136, 24);
            this.cmbArmor.TabIndex = 10;
            this.cmbArmor.Text = "Leather Armor";
            // 
            // txtWeapon
            // 
            this.txtWeapon.BackColor = System.Drawing.SystemColors.Control;
            this.txtWeapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeapon.Location = new System.Drawing.Point(480, 163);
            this.txtWeapon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(71, 15);
            this.txtWeapon.TabIndex = 11;
            this.txtWeapon.Text = "Weapon:";
            // 
            // cmbWeapon
            // 
            this.cmbWeapon.FormattingEnabled = true;
            this.cmbWeapon.Items.AddRange(new object[] {
            "Wooden Sword"});
            this.cmbWeapon.Location = new System.Drawing.Point(546, 161);
            this.cmbWeapon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbWeapon.Name = "cmbWeapon";
            this.cmbWeapon.Size = new System.Drawing.Size(136, 24);
            this.cmbWeapon.TabIndex = 12;
            this.cmbWeapon.Text = "Wooden Sword";
            this.cmbWeapon.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtHealthLabel
            // 
            this.txtHealthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtHealthLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHealthLabel.Location = new System.Drawing.Point(496, 195);
            this.txtHealthLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHealthLabel.Name = "txtHealthLabel";
            this.txtHealthLabel.Size = new System.Drawing.Size(44, 15);
            this.txtHealthLabel.TabIndex = 13;
            this.txtHealthLabel.Text = "Health:";
            // 
            // txtHealth
            // 
            this.txtHealth.Enabled = false;
            this.txtHealth.Location = new System.Drawing.Point(546, 193);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(42, 22);
            this.txtHealth.TabIndex = 14;
            this.txtHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHealth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblClass
            // 
            this.lblClass.BackColor = System.Drawing.SystemColors.Control;
            this.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblClass.Location = new System.Drawing.Point(289, 197);
            this.lblClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(44, 15);
            this.lblClass.TabIndex = 15;
            this.lblClass.Text = "Class:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Light Knight",
            "Heavy Knight",
            "Magic Knight"});
            this.comboBox3.Location = new System.Drawing.Point(339, 192);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(136, 24);
            this.comboBox3.TabIndex = 16;
            this.comboBox3.Text = "Light Knight";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(597, 189);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.ttp1.SetToolTip(this.btnClose, "Choose your difficulty before starting");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GoodKnight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 233);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtHealthLabel);
            this.Controls.Add(this.cmbWeapon);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.cmbArmor);
            this.Controls.Add(this.txtArmor);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.txtStory);
            this.Controls.Add(this.txtDifficulty);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudDifficulty);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GoodKnight";
            this.Text = "GoodKnight";
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDifficulty;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtDifficulty;
        private System.Windows.Forms.ToolTip ttp1;
        private System.Windows.Forms.TextBox txtStory;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.TextBox txtArmor;
        private System.Windows.Forms.ComboBox cmbArmor;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.ComboBox cmbWeapon;
        private System.Windows.Forms.TextBox txtHealthLabel;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox lblClass;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnClose;
    }
}

