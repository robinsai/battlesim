namespace MortyBattleSimulator
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
            this.player1PicBox = new System.Windows.Forms.PictureBox();
            this.player2PicBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.listOfComputerAttackBox = new System.Windows.Forms.ComboBox();
            this.listOfUserComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.player1PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // player1PicBox
            // 
            this.player1PicBox.Location = new System.Drawing.Point(46, 302);
            this.player1PicBox.Name = "player1PicBox";
            this.player1PicBox.Size = new System.Drawing.Size(155, 284);
            this.player1PicBox.TabIndex = 0;
            this.player1PicBox.TabStop = false;
            // 
            // player2PicBox
            // 
            this.player2PicBox.Location = new System.Drawing.Point(612, 12);
            this.player2PicBox.Name = "player2PicBox";
            this.player2PicBox.Size = new System.Drawing.Size(155, 284);
            this.player2PicBox.TabIndex = 1;
            this.player2PicBox.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(217, 557);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(374, 29);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(217, 12);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(374, 29);
            this.progressBar2.TabIndex = 3;
            this.progressBar2.Value = 100;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(176, 28);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(35, 13);
            this.player2Label.TabIndex = 4;
            this.player2Label.Text = "label1";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(597, 573);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(35, 13);
            this.player1Label.TabIndex = 5;
            this.player1Label.Text = "label2";
            // 
            // listOfComputerAttackBox
            // 
            this.listOfComputerAttackBox.FormattingEnabled = true;
            this.listOfComputerAttackBox.Items.AddRange(new object[] {
            "Bite",
            "Whine",
            "Arm Flail",
            "Cry"});
            this.listOfComputerAttackBox.Location = new System.Drawing.Point(426, 47);
            this.listOfComputerAttackBox.Name = "listOfComputerAttackBox";
            this.listOfComputerAttackBox.Size = new System.Drawing.Size(165, 21);
            this.listOfComputerAttackBox.TabIndex = 6;
            // 
            // listOfUserComboBox
            // 
            this.listOfUserComboBox.FormattingEnabled = true;
            this.listOfUserComboBox.Items.AddRange(new object[] {
            "Bite",
            "Whine",
            "Arm Flail",
            "Cry"});
            this.listOfUserComboBox.Location = new System.Drawing.Point(426, 530);
            this.listOfUserComboBox.Name = "listOfUserComboBox";
            this.listOfUserComboBox.Size = new System.Drawing.Size(165, 21);
            this.listOfUserComboBox.TabIndex = 7;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 598);
            this.Controls.Add(this.listOfUserComboBox);
            this.Controls.Add(this.listOfComputerAttackBox);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.player2PicBox);
            this.Controls.Add(this.player1PicBox);
            this.Name = "BattleForm";
            this.Text = "BattleForm";
            this.Load += new System.EventHandler(this.BattleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player1PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox player1PicBox;
        private System.Windows.Forms.PictureBox player2PicBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.ComboBox listOfComputerAttackBox;
        private System.Windows.Forms.ComboBox listOfUserComboBox;
    }
}