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
            radioButtonShotgun = new RadioButton();
            radioButtonBlock = new RadioButton();
            radioButtonCharge = new RadioButton();
            radioButtonShoot = new RadioButton();
            buttonGo = new Button();
            textBoxGameLog = new TextBox();
            buttonRules = new Button();
            pictureBoxComputer = new PictureBox();
            pictureBoxPlayer = new PictureBox();
            groupBoxUser = new GroupBox();
            listBoxUser = new ListBox();
            groupBoxComputer = new GroupBox();
            listBoxComputer = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComputer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            groupBoxUser.SuspendLayout();
            groupBoxComputer.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonShotgun
            // 
            radioButtonShotgun.AutoSize = true;
            radioButtonShotgun.Location = new Point(34, 150);
            radioButtonShotgun.Margin = new Padding(2);
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
            radioButtonBlock.Location = new Point(34, 82);
            radioButtonBlock.Margin = new Padding(2);
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
            radioButtonCharge.Location = new Point(34, 48);
            radioButtonCharge.Margin = new Padding(2);
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
            radioButtonShoot.Location = new Point(34, 118);
            radioButtonShoot.Margin = new Padding(2);
            radioButtonShoot.Name = "radioButtonShoot";
            radioButtonShoot.Size = new Size(57, 19);
            radioButtonShoot.TabIndex = 0;
            radioButtonShoot.TabStop = true;
            radioButtonShoot.Text = "Skjuta";
            radioButtonShoot.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(5, 180);
            buttonGo.Margin = new Padding(2);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(123, 44);
            buttonGo.TabIndex = 1;
            buttonGo.Text = "Kör";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // textBoxGameLog
            // 
            textBoxGameLog.Location = new Point(374, 211);
            textBoxGameLog.Margin = new Padding(2);
            textBoxGameLog.Multiline = true;
            textBoxGameLog.Name = "textBoxGameLog";
            textBoxGameLog.Size = new Size(145, 241);
            textBoxGameLog.TabIndex = 2;
            // 
            // buttonRules
            // 
            buttonRules.Location = new Point(11, 567);
            buttonRules.Margin = new Padding(2);
            buttonRules.Name = "buttonRules";
            buttonRules.Size = new Size(76, 30);
            buttonRules.TabIndex = 7;
            buttonRules.Text = "Regler";
            buttonRules.UseVisualStyleBackColor = true;
            buttonRules.Click += buttonRules_Click;
            // 
            // pictureBoxComputer
            // 
            pictureBoxComputer.Location = new Point(6, 56);
            pictureBoxComputer.Name = "pictureBoxComputer";
            pictureBoxComputer.Size = new Size(126, 157);
            pictureBoxComputer.TabIndex = 8;
            pictureBoxComputer.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.Location = new Point(218, 267);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(126, 157);
            pictureBoxPlayer.TabIndex = 9;
            pictureBoxPlayer.TabStop = false;
            // 
            // groupBoxUser
            // 
            groupBoxUser.Controls.Add(radioButtonShotgun);
            groupBoxUser.Controls.Add(listBoxUser);
            groupBoxUser.Controls.Add(buttonGo);
            groupBoxUser.Controls.Add(radioButtonBlock);
            groupBoxUser.Controls.Add(radioButtonCharge);
            groupBoxUser.Controls.Add(radioButtonShoot);
            groupBoxUser.Location = new Point(59, 211);
            groupBoxUser.Name = "groupBoxUser";
            groupBoxUser.Size = new Size(136, 241);
            groupBoxUser.TabIndex = 10;
            groupBoxUser.TabStop = false;
            groupBoxUser.Text = "Spelare";
            // 
            // listBoxUser
            // 
            listBoxUser.FormattingEnabled = true;
            listBoxUser.ItemHeight = 15;
            listBoxUser.Location = new Point(5, 22);
            listBoxUser.Name = "listBoxUser";
            listBoxUser.Size = new Size(123, 19);
            listBoxUser.TabIndex = 11;
            // 
            // groupBoxComputer
            // 
            groupBoxComputer.Controls.Add(listBoxComputer);
            groupBoxComputer.Controls.Add(pictureBoxComputer);
            groupBoxComputer.Location = new Point(562, 211);
            groupBoxComputer.Name = "groupBoxComputer";
            groupBoxComputer.Size = new Size(136, 241);
            groupBoxComputer.TabIndex = 12;
            groupBoxComputer.TabStop = false;
            groupBoxComputer.Text = "Dator";
            // 
            // listBoxComputer
            // 
            listBoxComputer.FormattingEnabled = true;
            listBoxComputer.ItemHeight = 15;
            listBoxComputer.Location = new Point(6, 22);
            listBoxComputer.Name = "listBoxComputer";
            listBoxComputer.Size = new Size(123, 19);
            listBoxComputer.TabIndex = 11;
            // 
            // Shotgun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 722);
            Controls.Add(groupBoxComputer);
            Controls.Add(groupBoxUser);
            Controls.Add(pictureBoxPlayer);
            Controls.Add(buttonRules);
            Controls.Add(textBoxGameLog);
            Margin = new Padding(2);
            Name = "Shotgun";
            Text = "Shotgun";
            ((System.ComponentModel.ISupportInitialize)pictureBoxComputer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            groupBoxUser.ResumeLayout(false);
            groupBoxUser.PerformLayout();
            groupBoxComputer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButtonShotgun;
        private RadioButton radioButtonBlock;
        private RadioButton radioButtonCharge;
        private RadioButton radioButtonShoot;
        private Button buttonGo;
        private TextBox textBoxGameLog;
        private Button buttonRules;
        private PictureBox pictureBoxComputer;
        private PictureBox pictureBoxPlayer;
        private GroupBox groupBoxUser;
        private ListBox listBoxUser;
        private GroupBox groupBoxComputer;
        private ListBox listBoxComputer;
    }
}
