namespace MortyBattleSimulator
{
    partial class MainMenuForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.player1Ready = new System.Windows.Forms.CheckBox();
            this.versusPicBox = new System.Windows.Forms.PictureBox();
            this.player2PicBox = new System.Windows.Forms.PictureBox();
            this.player1PicBox = new System.Windows.Forms.PictureBox();
            this.zombiePicBox = new System.Windows.Forms.PictureBox();
            this.ghostPicBox = new System.Windows.Forms.PictureBox();
            this.OGPicBox = new System.Windows.Forms.PictureBox();
            this.karatePicBox = new System.Windows.Forms.PictureBox();
            this.hippiePicBox = new System.Windows.Forms.PictureBox();
            this.scruffyPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.versusPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombiePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OGPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karatePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hippiePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scruffyPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Image = global::MortyBattleSimulator.Properties.Resources.startButton;
            this.startButton.Location = new System.Drawing.Point(331, 376);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(373, 133);
            this.startButton.TabIndex = 7;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // player1Ready
            // 
            this.player1Ready.AutoSize = true;
            this.player1Ready.Location = new System.Drawing.Point(344, 665);
            this.player1Ready.Name = "player1Ready";
            this.player1Ready.Size = new System.Drawing.Size(57, 17);
            this.player1Ready.TabIndex = 11;
            this.player1Ready.Text = "Ready";
            this.player1Ready.UseVisualStyleBackColor = true;
            this.player1Ready.CheckedChanged += new System.EventHandler(this.player1Ready_CheckedChanged);
            // 
            // versusPicBox
            // 
            this.versusPicBox.Image = global::MortyBattleSimulator.Properties.Resources.VS;
            this.versusPicBox.Location = new System.Drawing.Point(405, 515);
            this.versusPicBox.Name = "versusPicBox";
            this.versusPicBox.Size = new System.Drawing.Size(220, 145);
            this.versusPicBox.TabIndex = 10;
            this.versusPicBox.TabStop = false;
            this.versusPicBox.Visible = false;
            // 
            // player2PicBox
            // 
            this.player2PicBox.Image = global::MortyBattleSimulator.Properties.Resources.shadowMorty;
            this.player2PicBox.Location = new System.Drawing.Point(710, 376);
            this.player2PicBox.Name = "player2PicBox";
            this.player2PicBox.Size = new System.Drawing.Size(236, 370);
            this.player2PicBox.TabIndex = 9;
            this.player2PicBox.TabStop = false;
            // 
            // player1PicBox
            // 
            this.player1PicBox.ErrorImage = global::MortyBattleSimulator.Properties.Resources.shadowMorty;
            this.player1PicBox.Image = global::MortyBattleSimulator.Properties.Resources.shadowMorty;
            this.player1PicBox.Location = new System.Drawing.Point(89, 376);
            this.player1PicBox.Name = "player1PicBox";
            this.player1PicBox.Size = new System.Drawing.Size(236, 370);
            this.player1PicBox.TabIndex = 8;
            this.player1PicBox.TabStop = false;
            // 
            // zombiePicBox
            // 
            this.zombiePicBox.Image = global::MortyBattleSimulator.Properties.Resources.frontAncientMorty;
            this.zombiePicBox.Location = new System.Drawing.Point(870, 0);
            this.zombiePicBox.Name = "zombiePicBox";
            this.zombiePicBox.Size = new System.Drawing.Size(148, 370);
            this.zombiePicBox.TabIndex = 5;
            this.zombiePicBox.TabStop = false;
            this.zombiePicBox.Click += new System.EventHandler(this.clickOnCharacter);
            this.zombiePicBox.MouseEnter += new System.EventHandler(this.hoverOverPicture);
            this.zombiePicBox.MouseLeave += new System.EventHandler(this.hoverAwayPicture);
            // 
            // ghostPicBox
            // 
            this.ghostPicBox.Image = global::MortyBattleSimulator.Properties.Resources.frontGhostMorty;
            this.ghostPicBox.Location = new System.Drawing.Point(171, 0);
            this.ghostPicBox.Name = "ghostPicBox";
            this.ghostPicBox.Size = new System.Drawing.Size(154, 370);
            this.ghostPicBox.TabIndex = 4;
            this.ghostPicBox.TabStop = false;
            this.ghostPicBox.Click += new System.EventHandler(this.clickOnCharacter);
            this.ghostPicBox.MouseEnter += new System.EventHandler(this.hoverOverPicture);
            this.ghostPicBox.MouseLeave += new System.EventHandler(this.hoverAwayPicture);
            // 
            // OGPicBox
            // 
            this.OGPicBox.Image = global::MortyBattleSimulator.Properties.Resources.FrontOGMorty;
            this.OGPicBox.Location = new System.Drawing.Point(331, 0);
            this.OGPicBox.Name = "OGPicBox";
            this.OGPicBox.Size = new System.Drawing.Size(165, 370);
            this.OGPicBox.TabIndex = 3;
            this.OGPicBox.TabStop = false;
            this.OGPicBox.Click += new System.EventHandler(this.clickOnCharacter);
            this.OGPicBox.MouseEnter += new System.EventHandler(this.hoverOverPicture);
            this.OGPicBox.MouseLeave += new System.EventHandler(this.hoverAwayPicture);
            // 
            // karatePicBox
            // 
            this.karatePicBox.Image = global::MortyBattleSimulator.Properties.Resources.frontKarateMorty;
            this.karatePicBox.Location = new System.Drawing.Point(502, 0);
            this.karatePicBox.Name = "karatePicBox";
            this.karatePicBox.Size = new System.Drawing.Size(202, 370);
            this.karatePicBox.TabIndex = 2;
            this.karatePicBox.TabStop = false;
            this.karatePicBox.Click += new System.EventHandler(this.clickOnCharacter);
            this.karatePicBox.MouseEnter += new System.EventHandler(this.hoverOverPicture);
            this.karatePicBox.MouseLeave += new System.EventHandler(this.hoverAwayPicture);
            // 
            // hippiePicBox
            // 
            this.hippiePicBox.Image = global::MortyBattleSimulator.Properties.Resources.FrontHippyMorty;
            this.hippiePicBox.Location = new System.Drawing.Point(710, 0);
            this.hippiePicBox.Name = "hippiePicBox";
            this.hippiePicBox.Size = new System.Drawing.Size(154, 370);
            this.hippiePicBox.TabIndex = 1;
            this.hippiePicBox.TabStop = false;
            this.hippiePicBox.Click += new System.EventHandler(this.clickOnCharacter);
            this.hippiePicBox.MouseEnter += new System.EventHandler(this.hoverOverPicture);
            this.hippiePicBox.MouseLeave += new System.EventHandler(this.hoverAwayPicture);
            // 
            // scruffyPicBox
            // 
            this.scruffyPicBox.Image = global::MortyBattleSimulator.Properties.Resources.frontScruffyMorty;
            this.scruffyPicBox.Location = new System.Drawing.Point(0, 0);
            this.scruffyPicBox.Name = "scruffyPicBox";
            this.scruffyPicBox.Size = new System.Drawing.Size(165, 370);
            this.scruffyPicBox.TabIndex = 0;
            this.scruffyPicBox.TabStop = false;
            this.scruffyPicBox.Click += new System.EventHandler(this.clickOnCharacter);
            this.scruffyPicBox.MouseEnter += new System.EventHandler(this.hoverOverPicture);
            this.scruffyPicBox.MouseLeave += new System.EventHandler(this.hoverAwayPicture);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 734);
            this.Controls.Add(this.player1Ready);
            this.Controls.Add(this.versusPicBox);
            this.Controls.Add(this.player2PicBox);
            this.Controls.Add(this.player1PicBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.zombiePicBox);
            this.Controls.Add(this.ghostPicBox);
            this.Controls.Add(this.OGPicBox);
            this.Controls.Add(this.karatePicBox);
            this.Controls.Add(this.hippiePicBox);
            this.Controls.Add(this.scruffyPicBox);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.versusPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombiePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OGPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karatePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hippiePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scruffyPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox scruffyPicBox;
        private System.Windows.Forms.PictureBox hippiePicBox;
        private System.Windows.Forms.PictureBox karatePicBox;
        private System.Windows.Forms.PictureBox OGPicBox;
        private System.Windows.Forms.PictureBox ghostPicBox;
        private System.Windows.Forms.PictureBox zombiePicBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox player1PicBox;
        private System.Windows.Forms.PictureBox player2PicBox;
        private System.Windows.Forms.PictureBox versusPicBox;
        private System.Windows.Forms.CheckBox player1Ready;
    }
}

