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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shotgun));
            radioButtonShotgun = new RadioButton();
            radioButtonBlock = new RadioButton();
            radioButtonCharge = new RadioButton();
            radioButtonShoot = new RadioButton();
            buttonGo = new Button();
            buttonRules = new Button();
            groupBoxUser = new GroupBox();
            labelUserBullets = new Label();
            groupBoxComputer = new GroupBox();
            labelComputerBullets = new Label();
            groupBoxGameLog = new GroupBox();
            listBoxGameLog = new ListBox();
            pictureBox1 = new PictureBox();
            groupBoxUser.SuspendLayout();
            groupBoxComputer.SuspendLayout();
            groupBoxGameLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // groupBoxUser
            // 
            groupBoxUser.Controls.Add(labelUserBullets);
            groupBoxUser.Controls.Add(radioButtonShotgun);
            groupBoxUser.Controls.Add(buttonGo);
            groupBoxUser.Controls.Add(radioButtonBlock);
            groupBoxUser.Controls.Add(radioButtonCharge);
            groupBoxUser.Controls.Add(radioButtonShoot);
            groupBoxUser.Location = new Point(40, 260);
            groupBoxUser.Name = "groupBoxUser";
            groupBoxUser.Size = new Size(136, 241);
            groupBoxUser.TabIndex = 10;
            groupBoxUser.TabStop = false;
            groupBoxUser.Text = "Spelare";
            // 
            // labelUserBullets
            // 
            labelUserBullets.AutoSize = true;
            labelUserBullets.Location = new Point(34, 19);
            labelUserBullets.Name = "labelUserBullets";
            labelUserBullets.Size = new Size(46, 15);
            labelUserBullets.TabIndex = 13;
            labelUserBullets.Text = "Skott: 0";
            // 
            // groupBoxComputer
            // 
            groupBoxComputer.Controls.Add(pictureBox1);
            groupBoxComputer.Controls.Add(labelComputerBullets);
            groupBoxComputer.Location = new Point(480, 260);
            groupBoxComputer.Name = "groupBoxComputer";
            groupBoxComputer.Size = new Size(136, 241);
            groupBoxComputer.TabIndex = 12;
            groupBoxComputer.TabStop = false;
            groupBoxComputer.Text = "Dator";
            // 
            // labelComputerBullets
            // 
            labelComputerBullets.AutoSize = true;
            labelComputerBullets.Location = new Point(44, 19);
            labelComputerBullets.Name = "labelComputerBullets";
            labelComputerBullets.Size = new Size(46, 15);
            labelComputerBullets.TabIndex = 9;
            labelComputerBullets.Text = "Skott: 0";
            // 
            // groupBoxGameLog
            // 
            groupBoxGameLog.Controls.Add(listBoxGameLog);
            groupBoxGameLog.Location = new Point(214, 260);
            groupBoxGameLog.Name = "groupBoxGameLog";
            groupBoxGameLog.Size = new Size(227, 241);
            groupBoxGameLog.TabIndex = 13;
            groupBoxGameLog.TabStop = false;
            groupBoxGameLog.Text = "Spellogg";
            // 
            // listBoxGameLog
            // 
            listBoxGameLog.FormattingEnabled = true;
            listBoxGameLog.ItemHeight = 15;
            listBoxGameLog.Location = new Point(6, 22);
            listBoxGameLog.Name = "listBoxGameLog";
            listBoxGameLog.Size = new Size(215, 214);
            listBoxGameLog.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Shotgun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 647);
            Controls.Add(groupBoxGameLog);
            Controls.Add(groupBoxComputer);
            Controls.Add(groupBoxUser);
            Controls.Add(buttonRules);
            Margin = new Padding(2);
            Name = "Shotgun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shotgun";
            groupBoxUser.ResumeLayout(false);
            groupBoxUser.PerformLayout();
            groupBoxComputer.ResumeLayout(false);
            groupBoxComputer.PerformLayout();
            groupBoxGameLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton radioButtonShotgun;
        private RadioButton radioButtonBlock;
        private RadioButton radioButtonCharge;
        private RadioButton radioButtonShoot;
        private Button buttonGo;
        private Button buttonRules;
        private GroupBox groupBoxUser;
        private GroupBox groupBoxComputer;
        private Label labelUserBullets;
        private Label labelComputerBullets;
        private GroupBox groupBoxGameLog;
        private ListBox listBoxGameLog;
        private PictureBox pictureBox1;
    }
}
