namespace Shotgun
{
    partial class UserWon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWon));
            groupBoxRestart = new GroupBox();
            buttonNo = new Button();
            buttonYes = new Button();
            pictureBox1 = new PictureBox();
            groupBoxRestart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxRestart
            // 
            groupBoxRestart.BackColor = Color.White;
            groupBoxRestart.Controls.Add(buttonNo);
            groupBoxRestart.Controls.Add(buttonYes);
            groupBoxRestart.Location = new Point(249, 428);
            groupBoxRestart.Name = "groupBoxRestart";
            groupBoxRestart.Size = new Size(155, 60);
            groupBoxRestart.TabIndex = 1;
            groupBoxRestart.TabStop = false;
            groupBoxRestart.Text = "Vill Du börja om?";
            // 
            // buttonNo
            // 
            buttonNo.Location = new Point(81, 22);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(69, 31);
            buttonNo.TabIndex = 1;
            buttonNo.Text = "Nej";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(6, 22);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(69, 31);
            buttonYes.TabIndex = 0;
            buttonYes.Text = "Ja";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UserWon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 647);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxRestart);
            Name = "UserWon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Du vann";
            groupBoxRestart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRestart;
        private Button buttonNo;
        private Button buttonYes;
        private PictureBox pictureBox1;
    }
}