namespace Shotgun
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            groupBoxRestart = new GroupBox();
            buttonNo = new Button();
            buttonYes = new Button();
            groupBoxRestart.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRestart
            // 
            groupBoxRestart.Controls.Add(buttonNo);
            groupBoxRestart.Controls.Add(buttonYes);
            groupBoxRestart.Location = new Point(250, 320);
            groupBoxRestart.Name = "groupBoxRestart";
            groupBoxRestart.Size = new Size(155, 60);
            groupBoxRestart.TabIndex = 2;
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
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 647);
            Controls.Add(groupBoxRestart);
            Name = "GameOver";
            Text = "Game Over";
            groupBoxRestart.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRestart;
        private Button buttonNo;
        private Button buttonYes;
    }
}