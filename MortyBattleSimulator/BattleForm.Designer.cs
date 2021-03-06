﻿namespace MortyBattleSimulator
{
    partial class BattleForm
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.player1HealthBar = new System.Windows.Forms.ProgressBar();
            this.compHealthBar = new System.Windows.Forms.ProgressBar();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.listOfUserComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.player2PicBox = new System.Windows.Forms.PictureBox();
            this.player1PicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player2PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player1HealthBar
            // 
            this.player1HealthBar.Location = new System.Drawing.Point(217, 557);
            this.player1HealthBar.Name = "player1HealthBar";
            this.player1HealthBar.Size = new System.Drawing.Size(374, 29);
            this.player1HealthBar.TabIndex = 2;
            this.player1HealthBar.Value = 100;
            // 
            // compHealthBar
            // 
            this.compHealthBar.Location = new System.Drawing.Point(217, 12);
            this.compHealthBar.Name = "compHealthBar";
            this.compHealthBar.Size = new System.Drawing.Size(374, 29);
            this.compHealthBar.TabIndex = 3;
            this.compHealthBar.Value = 100;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(609, 302);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(35, 13);
            this.player2Label.TabIndex = 4;
            this.player2Label.Text = "label1";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(43, 283);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(35, 13);
            this.player1Label.TabIndex = 5;
            this.player1Label.Text = "label2";
            // 
            // listOfUserComboBox
            // 
            this.listOfUserComboBox.FormattingEnabled = true;
            this.listOfUserComboBox.Location = new System.Drawing.Point(426, 530);
            this.listOfUserComboBox.Name = "listOfUserComboBox";
            this.listOfUserComboBox.Size = new System.Drawing.Size(165, 21);
            this.listOfUserComboBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Image = global::MortyBattleSimulator.Properties.Resources.Attack;
            this.button1.Location = new System.Drawing.Point(621, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 83);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // player2PicBox
            // 
            this.player2PicBox.Location = new System.Drawing.Point(612, 12);
            this.player2PicBox.Name = "player2PicBox";
            this.player2PicBox.Size = new System.Drawing.Size(155, 284);
            this.player2PicBox.TabIndex = 1;
            this.player2PicBox.TabStop = false;
            // 
            // player1PicBox
            // 
            this.player1PicBox.Location = new System.Drawing.Point(46, 302);
            this.player1PicBox.Name = "player1PicBox";
            this.player1PicBox.Size = new System.Drawing.Size(155, 284);
            this.player1PicBox.TabIndex = 0;
            this.player1PicBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(46, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 464);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 598);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listOfUserComboBox);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.compHealthBar);
            this.Controls.Add(this.player1HealthBar);
            this.Controls.Add(this.player2PicBox);
            this.Controls.Add(this.player1PicBox);
            this.Name = "BattleForm";
            this.Text = "BattleForm";
            this.Load += new System.EventHandler(this.BattleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player2PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox player1PicBox;
        private System.Windows.Forms.PictureBox player2PicBox;
        private System.Windows.Forms.ProgressBar player1HealthBar;
        private System.Windows.Forms.ProgressBar compHealthBar;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.ComboBox listOfUserComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}