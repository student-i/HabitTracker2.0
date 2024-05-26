namespace HabitTracker2._0
{
    partial class VeiwForm
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
            this.habitComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InstanceListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // habitComboBox
            // 
            this.habitComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.habitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitComboBox.FormattingEnabled = true;
            this.habitComboBox.Location = new System.Drawing.Point(458, 86);
            this.habitComboBox.Name = "habitComboBox";
            this.habitComboBox.Size = new System.Drawing.Size(181, 45);
            this.habitComboBox.TabIndex = 0;
            this.habitComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.backButton.ForeColor = System.Drawing.Color.DarkGray;
            this.backButton.Location = new System.Drawing.Point(30, 598);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 49);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Habit:";
            // 
            // InstanceListView
            // 
            this.InstanceListView.BackColor = System.Drawing.Color.LightGray;
            this.InstanceListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstanceListView.HideSelection = false;
            this.InstanceListView.Location = new System.Drawing.Point(55, 161);
            this.InstanceListView.Name = "InstanceListView";
            this.InstanceListView.Size = new System.Drawing.Size(1030, 410);
            this.InstanceListView.TabIndex = 3;
            this.InstanceListView.UseCompatibleStateImageBehavior = false;
            this.InstanceListView.View = System.Windows.Forms.View.List;
            // 
            // VeiwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1133, 673);
            this.Controls.Add(this.InstanceListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.habitComboBox);
            this.Name = "VeiwForm";
            this.Text = "Habit Tracker - Veiw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox habitComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView InstanceListView;
    }
}