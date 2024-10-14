using Microsoft.VisualBasic.ApplicationServices;
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
                if (UserBullets > 2)
                {
                    listBoxGameLog.Items.Add("Spelare: SHOTGUN");
                    UserWon userWon = new UserWon();
                    userWon.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Du måste ha minst 3 skott");
                }
                
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
