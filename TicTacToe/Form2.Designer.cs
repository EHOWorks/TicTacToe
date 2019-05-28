namespace TicTacToe
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.play_button = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Joueur 1 :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Joueur 2 :";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(113, 79);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(297, 22);
            this.p1.TabIndex = 2;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(113, 114);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(297, 22);
            this.p2.TabIndex = 3;
            this.p2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P2_KeyPress);
            // 
            // play_button
            // 
            this.play_button.Location = new System.Drawing.Point(327, 153);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(82, 53);
            this.play_button.Style = MetroFramework.MetroColorStyle.Purple;
            this.play_button.TabIndex = 4;
            this.play_button.Text = "Jouer";
            this.play_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.play_button.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 215);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Tic Tac Toe";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private MetroFramework.Controls.MetroTile play_button;
    }
}