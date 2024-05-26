namespace HabitTracker2._0
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.addHabitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.recordButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.LevelPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LevelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addHabitButton
            // 
            this.addHabitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addHabitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHabitButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.addHabitButton.Location = new System.Drawing.Point(72, 153);
            this.addHabitButton.Name = "addHabitButton";
            this.addHabitButton.Size = new System.Drawing.Size(249, 119);
            this.addHabitButton.TabIndex = 1;
            this.addHabitButton.Text = "Add Habit";
            this.addHabitButton.UseVisualStyleBackColor = false;
            this.addHabitButton.Click += new System.EventHandler(this.addHabitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome! You are currently connected.";
            // 
            // recordButton
            // 
            this.recordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.recordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.recordButton.Location = new System.Drawing.Point(72, 343);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(249, 119);
            this.recordButton.TabIndex = 3;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = false;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(72, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 119);
            this.button1.TabIndex = 4;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.AutoSize = true;
            this.DisconnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DisconnectButton.ForeColor = System.Drawing.Color.DarkGray;
            this.DisconnectButton.Location = new System.Drawing.Point(971, 610);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(150, 44);
            this.DisconnectButton.TabIndex = 5;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = false;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(623, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Points: ";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(822, 159);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(29, 31);
            this.pointsLabel.TabIndex = 7;
            this.pointsLabel.Text = "0";
            // 
            // LevelPictureBox
            // 
            this.LevelPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LevelPictureBox.Image")));
            this.LevelPictureBox.Location = new System.Drawing.Point(572, 262);
            this.LevelPictureBox.Name = "LevelPictureBox";
            this.LevelPictureBox.Size = new System.Drawing.Size(200, 200);
            this.LevelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LevelPictureBox.TabIndex = 8;
            this.LevelPictureBox.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1133, 673);
            this.Controls.Add(this.LevelPictureBox);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addHabitButton);
            this.Name = "HomeForm";
            this.Text = "Habit Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.LevelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addHabitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.PictureBox LevelPictureBox;
    }
}