
namespace Monetka
{
    partial class Form1
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
            this.pictureMonetka = new System.Windows.Forms.PictureBox();
            this.Heads = new System.Windows.Forms.RadioButton();
            this.Tails = new System.Windows.Forms.RadioButton();
            this.SendButton = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.Panel();
            this.ServerButton = new System.Windows.Forms.Button();
            this.ConectButton = new System.Windows.Forms.Button();
            this.IpLable = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMonetka)).BeginInit();
            this.Game.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureMonetka
            // 
            this.pictureMonetka.Location = new System.Drawing.Point(16, 9);
            this.pictureMonetka.Name = "pictureMonetka";
            this.pictureMonetka.Size = new System.Drawing.Size(141, 152);
            this.pictureMonetka.TabIndex = 0;
            this.pictureMonetka.TabStop = false;
            // 
            // Heads
            // 
            this.Heads.AutoSize = true;
            this.Heads.Checked = true;
            this.Heads.Location = new System.Drawing.Point(16, 167);
            this.Heads.Name = "Heads";
            this.Heads.Size = new System.Drawing.Size(56, 17);
            this.Heads.TabIndex = 2;
            this.Heads.TabStop = true;
            this.Heads.Text = "Heads";
            this.Heads.UseVisualStyleBackColor = true;
            // 
            // Tails
            // 
            this.Tails.AutoSize = true;
            this.Tails.Location = new System.Drawing.Point(16, 191);
            this.Tails.Name = "Tails";
            this.Tails.Size = new System.Drawing.Size(47, 17);
            this.Tails.TabIndex = 3;
            this.Tails.Text = "Tails";
            this.Tails.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(16, 214);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(141, 31);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Game
            // 
            this.Game.Controls.Add(this.SendButton);
            this.Game.Controls.Add(this.Tails);
            this.Game.Controls.Add(this.Heads);
            this.Game.Controls.Add(this.pictureMonetka);
            this.Game.Location = new System.Drawing.Point(142, 2);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(171, 256);
            this.Game.TabIndex = 5;
            // 
            // ServerButton
            // 
            this.ServerButton.Location = new System.Drawing.Point(12, 2);
            this.ServerButton.Name = "ServerButton";
            this.ServerButton.Size = new System.Drawing.Size(75, 23);
            this.ServerButton.TabIndex = 5;
            this.ServerButton.Text = "Open Server";
            this.ServerButton.UseVisualStyleBackColor = true;
            this.ServerButton.Click += new System.EventHandler(this.ServerButton_Click);
            // 
            // ConectButton
            // 
            this.ConectButton.Location = new System.Drawing.Point(12, 31);
            this.ConectButton.Name = "ConectButton";
            this.ConectButton.Size = new System.Drawing.Size(75, 23);
            this.ConectButton.TabIndex = 5;
            this.ConectButton.Text = "Conect";
            this.ConectButton.UseVisualStyleBackColor = true;
            this.ConectButton.Click += new System.EventHandler(this.ConectButton_Click);
            // 
            // IpLable
            // 
            this.IpLable.AutoSize = true;
            this.IpLable.Location = new System.Drawing.Point(9, 57);
            this.IpLable.Name = "IpLable";
            this.IpLable.Size = new System.Drawing.Size(16, 13);
            this.IpLable.TabIndex = 5;
            this.IpLable.Text = "Ip";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(12, 73);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(100, 20);
            this.textBoxIp.TabIndex = 5;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(12, 112);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 20);
            this.PortTextBox.TabIndex = 8;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(9, 96);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 9;
            this.PortLabel.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 260);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.IpLable);
            this.Controls.Add(this.ConectButton);
            this.Controls.Add(this.ServerButton);
            this.Controls.Add(this.Game);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMonetka)).EndInit();
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMonetka;
        private System.Windows.Forms.RadioButton Heads;
        private System.Windows.Forms.RadioButton Tails;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Panel Game;
        private System.Windows.Forms.Button ServerButton;
        private System.Windows.Forms.Button ConectButton;
        private System.Windows.Forms.Label IpLable;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label PortLabel;
    }
}

