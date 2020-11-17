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
            this.txtStory = new System.Windows.Forms.TextBox();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.txtArmor = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDifficulty
            // 
            this.nudDifficulty.Location = new System.Drawing.Point(112, 234);
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
            this.nudDifficulty.Size = new System.Drawing.Size(53, 26);
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
            this.btnStart.Location = new System.Drawing.Point(671, 227);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // txtDifficulty
            // 
            this.txtDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDifficulty.Location = new System.Drawing.Point(33, 236);
            this.txtDifficulty.Name = "txtDifficulty";
            this.txtDifficulty.ReadOnly = true;
            this.txtDifficulty.Size = new System.Drawing.Size(73, 19);
            this.txtDifficulty.TabIndex = 2;
            this.txtDifficulty.Text = "Difficulty:";
            this.ttp1.SetToolTip(this.txtDifficulty, "1 = easy, 2 = medium, 3 = hard");
            this.txtDifficulty.TextChanged += new System.EventHandler(this.txtDifficulty_TextChanged);
            // 
            // txtStory
            // 
            this.txtStory.Enabled = false;
            this.txtStory.Location = new System.Drawing.Point(33, 22);
            this.txtStory.MinimumSize = new System.Drawing.Size(735, 60);
            this.txtStory.Multiline = true;
            this.txtStory.Name = "txtStory";
            this.txtStory.ReadOnly = true;
            this.txtStory.Size = new System.Drawing.Size(735, 60);
            this.txtStory.TabIndex = 3;
            this.txtStory.Text = "\r\n\r\n\r\n\r\n\r\n";
            // 
            // txtChoice
            // 
            this.txtChoice.Enabled = false;
            this.txtChoice.Location = new System.Drawing.Point(33, 87);
            this.txtChoice.MinimumSize = new System.Drawing.Size(735, 90);
            this.txtChoice.Multiline = true;
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.ReadOnly = true;
            this.txtChoice.Size = new System.Drawing.Size(735, 90);
            this.txtChoice.TabIndex = 4;
            this.txtChoice.Text = "\r\n\r\n\r\n\r\n\r\n\r\n";
            this.ttp1.SetToolTip(this.txtChoice, "Story Choices");
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(33, 186);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 36);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "1";
            this.ttp1.SetToolTip(this.btn2, "Choice 1");
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(129, 186);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 36);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "2";
            this.ttp1.SetToolTip(this.btn3, "Choice 2");
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(225, 186);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 36);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "3";
            this.ttp1.SetToolTip(this.btn4, "Choice 3");
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // txtArmor
            // 
            this.txtArmor.BackColor = System.Drawing.SystemColors.Control;
            this.txtArmor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArmor.Location = new System.Drawing.Point(327, 194);
            this.txtArmor.Name = "txtArmor";
            this.txtArmor.Size = new System.Drawing.Size(49, 19);
            this.txtArmor.TabIndex = 9;
            this.txtArmor.Text = "Armor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Leather Armor",
            "Iron Armor",
            "Steel Armor"});
            this.comboBox1.Location = new System.Drawing.Point(382, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // txtWeapon
            // 
            this.txtWeapon.BackColor = System.Drawing.SystemColors.Control;
            this.txtWeapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeapon.Location = new System.Drawing.Point(541, 194);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(80, 19);
            this.txtWeapon.TabIndex = 11;
            this.txtWeapon.Text = "Weapon:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Wood Sword",
            "Iron Sword",
            "Steel Sword",
            "King\'s Sword"});
            this.comboBox2.Location = new System.Drawing.Point(615, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 28);
            this.comboBox2.TabIndex = 12;
            // 
            // GoodKnight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtArmor);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.txtStory);
            this.Controls.Add(this.txtDifficulty);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudDifficulty);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

