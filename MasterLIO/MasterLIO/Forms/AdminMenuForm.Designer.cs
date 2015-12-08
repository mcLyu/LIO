namespace MasterLIO.Forms
{
    partial class AdminMenuForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.statistic = new System.Windows.Forms.Button();
            this.ExerciseButton = new System.Windows.Forms.Button();
            this.CreateExercsieButton = new System.Windows.Forms.Button();
            this.EditAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(57, 252);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(284, 50);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // statistic
            // 
            this.statistic.Location = new System.Drawing.Point(57, 84);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(284, 50);
            this.statistic.TabIndex = 4;
            this.statistic.Text = "Статистика";
            this.statistic.UseVisualStyleBackColor = true;
            this.statistic.Click += new System.EventHandler(this.statistic_Click);
            // 
            // ExerciseButton
            // 
            this.ExerciseButton.Location = new System.Drawing.Point(57, 28);
            this.ExerciseButton.Name = "ExerciseButton";
            this.ExerciseButton.Size = new System.Drawing.Size(284, 50);
            this.ExerciseButton.TabIndex = 3;
            this.ExerciseButton.Text = "Упражнение";
            this.ExerciseButton.UseVisualStyleBackColor = true;
            this.ExerciseButton.Click += new System.EventHandler(this.ExerciseButton_Click);
            // 
            // CreateExercsieButton
            // 
            this.CreateExercsieButton.Location = new System.Drawing.Point(57, 140);
            this.CreateExercsieButton.Name = "CreateExercsieButton";
            this.CreateExercsieButton.Size = new System.Drawing.Size(284, 50);
            this.CreateExercsieButton.TabIndex = 6;
            this.CreateExercsieButton.Text = "Создание упражнения";
            this.CreateExercsieButton.UseVisualStyleBackColor = true;
            this.CreateExercsieButton.Click += new System.EventHandler(this.CreateExercsieButton_Click);
            // 
            // EditAccountButton
            // 
            this.EditAccountButton.Location = new System.Drawing.Point(57, 196);
            this.EditAccountButton.Name = "EditAccountButton";
            this.EditAccountButton.Size = new System.Drawing.Size(284, 50);
            this.EditAccountButton.TabIndex = 7;
            this.EditAccountButton.Text = "Управление учетными записями";
            this.EditAccountButton.UseVisualStyleBackColor = true;
            this.EditAccountButton.Click += new System.EventHandler(this.EditAccountButton_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 314);
            this.Controls.Add(this.EditAccountButton);
            this.Controls.Add(this.CreateExercsieButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statistic);
            this.Controls.Add(this.ExerciseButton);
            this.Name = "AdminMenuForm";
            this.Text = "AdminMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button statistic;
        private System.Windows.Forms.Button ExerciseButton;
        private System.Windows.Forms.Button CreateExercsieButton;
        private System.Windows.Forms.Button EditAccountButton;
    }
}