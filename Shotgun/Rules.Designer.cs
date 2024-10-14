namespace Shotgun
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            textBoxRules = new TextBox();
            buttonCloseRules = new Button();
            SuspendLayout();
            // 
            // textBoxRules
            // 
            textBoxRules.ForeColor = SystemColors.WindowText;
            textBoxRules.Location = new Point(180, 172);
            textBoxRules.Multiline = true;
            textBoxRules.Name = "textBoxRules";
            textBoxRules.Size = new Size(319, 317);
            textBoxRules.TabIndex = 0;
            textBoxRules.Text = resources.GetString("textBoxRules.Text");
            // 
            // buttonCloseRules
            // 
            buttonCloseRules.Location = new Point(289, 537);
            buttonCloseRules.Name = "buttonCloseRules";
            buttonCloseRules.Size = new Size(97, 36);
            buttonCloseRules.TabIndex = 1;
            buttonCloseRules.Text = "Stäng";
            buttonCloseRules.UseVisualStyleBackColor = true;
            buttonCloseRules.Click += buttonCloseRules_Click;
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 647);
            Controls.Add(buttonCloseRules);
            Controls.Add(textBoxRules);
            Name = "Rules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRules;
        private Button buttonCloseRules;
    }
}