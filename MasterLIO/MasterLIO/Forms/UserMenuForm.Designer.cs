namespace MasterLIO.Forms
{
    partial class UserMenuForm
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
            this.ExerciseButton = new System.Windows.Forms.Button();
            this.statistic = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExerciseButton
            // 
            this.ExerciseButton.Location = new System.Drawing.Point(12, 72);
            this.ExerciseButton.Name = "ExerciseButton";
            this.ExerciseButton.Size = new System.Drawing.Size(284, 50);
            this.ExerciseButton.TabIndex = 0;
            this.ExerciseButton.Text = "Упражнение";
            this.ExerciseButton.UseVisualStyleBackColor = true;
            this.ExerciseButton.Click += new System.EventHandler(this.ExerciseButton_Click);
            // 
            // statistic
            // 
            this.statistic.Location = new System.Drawing.Point(12, 128);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(284, 50);
            this.statistic.TabIndex = 1;
            this.statistic.Text = "Статистика";
            this.statistic.UseVisualStyleBackColor = true;
            this.statistic.Click += new System.EventHandler(this.statistic_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 184);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(284, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UserMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 284);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statistic);
            this.Controls.Add(this.ExerciseButton);
            this.Name = "UserMenuForm";
            this.Text = "UserMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExerciseButton;
        private System.Windows.Forms.Button statistic;
        private System.Windows.Forms.Button exitButton;
    }
}