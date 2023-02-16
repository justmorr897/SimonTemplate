namespace SimonSays
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.normalGameButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(6, 51);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 32);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.newButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newButton.FlatAppearance.BorderSize = 0;
            this.newButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(6, 13);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(84, 32);
            this.newButton.TabIndex = 18;
            this.newButton.Text = "New Game";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // normalGameButton
            // 
            this.normalGameButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.normalGameButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.normalGameButton.FlatAppearance.BorderSize = 0;
            this.normalGameButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.normalGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.normalGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalGameButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalGameButton.ForeColor = System.Drawing.Color.White;
            this.normalGameButton.Location = new System.Drawing.Point(103, 13);
            this.normalGameButton.Name = "normalGameButton";
            this.normalGameButton.Size = new System.Drawing.Size(87, 32);
            this.normalGameButton.TabIndex = 20;
            this.normalGameButton.Text = "Normal";
            this.normalGameButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.normalGameButton.UseVisualStyleBackColor = false;
            this.normalGameButton.Visible = false;
            this.normalGameButton.Click += new System.EventHandler(this.normalGameButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.shuffleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.shuffleButton.FlatAppearance.BorderSize = 0;
            this.shuffleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.shuffleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.shuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleButton.ForeColor = System.Drawing.Color.White;
            this.shuffleButton.Location = new System.Drawing.Point(204, 13);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(84, 32);
            this.shuffleButton.TabIndex = 21;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.shuffleButton.UseVisualStyleBackColor = false;
            this.shuffleButton.Visible = false;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.normalGameButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(301, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button normalGameButton;
        private System.Windows.Forms.Button shuffleButton;
    }
}
