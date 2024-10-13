namespace Shotgun
{
    partial class Shotgun
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxPlayer = new GroupBox();
            radioButtonShotgun = new RadioButton();
            radioButtonBlock = new RadioButton();
            radioButtonCharge = new RadioButton();
            radioButtonShoot = new RadioButton();
            buttonGo = new Button();
            textBoxGameLog = new TextBox();
            textBoxShotsPlayer = new TextBox();
            textBoxShotsComputer = new TextBox();
            labelShotsPlayer = new Label();
            labelShotsComputer = new Label();
            buttonRules = new Button();
            pictureBoxComputer = new PictureBox();
            pictureBoxPlayer = new PictureBox();
            groupBoxPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComputer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPlayer
            // 
            groupBoxPlayer.Controls.Add(radioButtonShotgun);
            groupBoxPlayer.Controls.Add(radioButtonBlock);
            groupBoxPlayer.Controls.Add(radioButtonCharge);
            groupBoxPlayer.Controls.Add(radioButtonShoot);
            groupBoxPlayer.Location = new Point(67, 309);
            groupBoxPlayer.Margin = new Padding(2, 2, 2, 2);
            groupBoxPlayer.Name = "groupBoxPlayer";
            groupBoxPlayer.Padding = new Padding(2, 2, 2, 2);
            groupBoxPlayer.Size = new Size(124, 166);
            groupBoxPlayer.TabIndex = 0;
            groupBoxPlayer.TabStop = false;
            groupBoxPlayer.Text = "Spelare";
            // 
            // radioButtonShotgun
            // 
            radioButtonShotgun.AutoSize = true;
            radioButtonShotgun.Location = new Point(32, 138);
            radioButtonShotgun.Margin = new Padding(2, 2, 2, 2);
            radioButtonShotgun.Name = "radioButtonShotgun";
            radioButtonShotgun.Size = new Size(70, 19);
            radioButtonShotgun.TabIndex = 3;
            radioButtonShotgun.TabStop = true;
            radioButtonShotgun.Text = "Shotgun";
            radioButtonShotgun.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlock
            // 
            radioButtonBlock.AutoSize = true;
            radioButtonBlock.Location = new Point(32, 104);
            radioButtonBlock.Margin = new Padding(2, 2, 2, 2);
            radioButtonBlock.Name = "radioButtonBlock";
            radioButtonBlock.Size = new Size(60, 19);
            radioButtonBlock.TabIndex = 2;
            radioButtonBlock.TabStop = true;
            radioButtonBlock.Text = "Blocka";
            radioButtonBlock.UseVisualStyleBackColor = true;
            // 
            // radioButtonCharge
            // 
            radioButtonCharge.AutoSize = true;
            radioButtonCharge.Location = new Point(32, 65);
            radioButtonCharge.Margin = new Padding(2, 2, 2, 2);
            radioButtonCharge.Name = "radioButtonCharge";
            radioButtonCharge.Size = new Size(57, 19);
            radioButtonCharge.TabIndex = 1;
            radioButtonCharge.TabStop = true;
            radioButtonCharge.Text = "Ladda";
            radioButtonCharge.UseVisualStyleBackColor = true;
            // 
            // radioButtonShoot
            // 
            radioButtonShoot.AutoSize = true;
            radioButtonShoot.Location = new Point(32, 28);
            radioButtonShoot.Margin = new Padding(2, 2, 2, 2);
            radioButtonShoot.Name = "radioButtonShoot";
            radioButtonShoot.Size = new Size(57, 19);
            radioButtonShoot.TabIndex = 0;
            radioButtonShoot.TabStop = true;
            radioButtonShoot.Text = "Skjuta";
            radioButtonShoot.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(67, 479);
            buttonGo.Margin = new Padding(2, 2, 2, 2);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(124, 44);
            buttonGo.TabIndex = 1;
            buttonGo.Text = "Kör";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // textBoxGameLog
            // 
            textBoxGameLog.Location = new Point(372, 310);
            textBoxGameLog.Margin = new Padding(2, 2, 2, 2);
            textBoxGameLog.Multiline = true;
            textBoxGameLog.Name = "textBoxGameLog";
            textBoxGameLog.Size = new Size(145, 168);
            textBoxGameLog.TabIndex = 2;
            // 
            // textBoxShotsPlayer
            // 
            textBoxShotsPlayer.Location = new Point(67, 289);
            textBoxShotsPlayer.Margin = new Padding(2, 2, 2, 2);
            textBoxShotsPlayer.Name = "textBoxShotsPlayer";
            textBoxShotsPlayer.Size = new Size(126, 23);
            textBoxShotsPlayer.TabIndex = 3;
            // 
            // textBoxShotsComputer
            // 
            textBoxShotsComputer.Location = new Point(564, 290);
            textBoxShotsComputer.Margin = new Padding(2, 2, 2, 2);
            textBoxShotsComputer.Name = "textBoxShotsComputer";
            textBoxShotsComputer.Size = new Size(126, 23);
            textBoxShotsComputer.TabIndex = 4;
            // 
            // labelShotsPlayer
            // 
            labelShotsPlayer.AutoSize = true;
            labelShotsPlayer.Location = new Point(67, 273);
            labelShotsPlayer.Margin = new Padding(2, 0, 2, 0);
            labelShotsPlayer.Name = "labelShotsPlayer";
            labelShotsPlayer.Size = new Size(75, 15);
            labelShotsPlayer.TabIndex = 5;
            labelShotsPlayer.Text = "Spelare Skott";
            // 
            // labelShotsComputer
            // 
            labelShotsComputer.AutoSize = true;
            labelShotsComputer.Location = new Point(564, 274);
            labelShotsComputer.Margin = new Padding(2, 0, 2, 0);
            labelShotsComputer.Name = "labelShotsComputer";
            labelShotsComputer.Size = new Size(66, 15);
            labelShotsComputer.TabIndex = 6;
            labelShotsComputer.Text = "Dator Skott";
            // 
            // buttonRules
            // 
            buttonRules.Location = new Point(11, 567);
            buttonRules.Margin = new Padding(2, 2, 2, 2);
            buttonRules.Name = "buttonRules";
            buttonRules.Size = new Size(76, 30);
            buttonRules.TabIndex = 7;
            buttonRules.Text = "Regler";
            buttonRules.UseVisualStyleBackColor = true;
            buttonRules.Click += buttonRules_Click;
            // 
            // pictureBoxComputer
            // 
            pictureBoxComputer.Location = new Point(564, 318);
            pictureBoxComputer.Name = "pictureBoxComputer";
            pictureBoxComputer.Size = new Size(126, 157);
            pictureBoxComputer.TabIndex = 8;
            pictureBoxComputer.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.Location = new Point(221, 318);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(126, 157);
            pictureBoxPlayer.TabIndex = 9;
            pictureBoxPlayer.TabStop = false;
            // 
            // Shotgun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 722);
            Controls.Add(pictureBoxPlayer);
            Controls.Add(pictureBoxComputer);
            Controls.Add(buttonRules);
            Controls.Add(labelShotsComputer);
            Controls.Add(labelShotsPlayer);
            Controls.Add(textBoxShotsComputer);
            Controls.Add(textBoxShotsPlayer);
            Controls.Add(textBoxGameLog);
            Controls.Add(buttonGo);
            Controls.Add(groupBoxPlayer);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Shotgun";
            Text = "Shotgun";
            groupBoxPlayer.ResumeLayout(false);
            groupBoxPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComputer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPlayer;
        private RadioButton radioButtonShotgun;
        private RadioButton radioButtonBlock;
        private RadioButton radioButtonCharge;
        private RadioButton radioButtonShoot;
        private Button buttonGo;
        private TextBox textBoxGameLog;
        private TextBox textBoxShotsPlayer;
        private TextBox textBoxShotsComputer;
        private Label labelShotsPlayer;
        private Label labelShotsComputer;
        private Button buttonRules;
        private PictureBox pictureBoxComputer;
        private PictureBox pictureBoxPlayer;
    }
}
