using Shotgun.Classes;

namespace Shotgun
{
    public partial class Shotgun : Form
    {
        private GameMode move;
        public int UserBullets = 0;
        public int ComputerBullets = 0;

        public Shotgun()
        {
            InitializeComponent();
            move = new GameMode();
            move.GameLog += UpdateLog;

        }
        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (radioButtonCharge.Checked)
            {
                move.GamePlay("Ladda");
                UpdateShoots();

            }
            else if (radioButtonBlock.Checked)
            {
                move.GamePlay("Blocka");
                UpdateShoots();
            }
            else if (radioButtonShoot.Checked)
            {       
                    move.GamePlay("Skjuta");
                    UpdateShoots();
            }
            else if (radioButtonShotgun.Checked)
            {
                    move.GamePlay("Shotgun");
                    UpdateShoots();
            }
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.ShowDialog();
        }
        private void UpdateShoots()
        {
            int UserBullets = move.User.Bullets;
            int ComputerBullets = move.Computer.Bullets;
            labelUserBullets.Text = $"Skott:{UserBullets}";
            labelComputerBullets.Text = $"Skott: {ComputerBullets}";
        }
        private void UpdateLog(string logMessenge)
        {
            listBoxGameLog.Items.Add(logMessenge);
            listBoxGameLog.TopIndex = listBoxGameLog.Items.Count - 1;
        }
    }
}
