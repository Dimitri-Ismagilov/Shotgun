namespace Shotgun.Classes
{
    public class GameMode
    {
        public Player Computer { get; set; }
        public Player User { get; set; }
        public event Action<string> GameLog;

        public GameMode()
        {
            User = new Player();
            Computer = new Player();
        }
        public void GamePlay(string userMove)
        {
            string computerMove = ComputerMove();
            string logMessage = $" Spelare: {userMove} VS Dator:{computerMove}";
            if (userMove == "Ladda")
            {
                if (computerMove == "Ladda")
                {
                    User.Charge();
                    Computer.Charge();
                    GameLog.Invoke(logMessage);
                        
                        
                }
                else if (computerMove == "Blocka")
                {
                    User.Charge();
                    GameLog.Invoke(logMessage);
                }
                else if (computerMove == "Skjuta")
                {
                    Computer.Shoot();
                    GameOver gameOver = new GameOver();
                    gameOver.ShowDialog();
                    GameLog.Invoke(logMessage);
                }
            }
            else if (userMove == "Blocka")
            {
                if (computerMove == "Ladda")
                {
                    Computer.Charge();
                    GameLog.Invoke(logMessage);
                }
                else if (computerMove == "Blocka")
                {
                    GameLog.Invoke(logMessage);
                }
                else if (computerMove == "Skjuta")
                {
                    Computer.Shoot();
                    GameLog.Invoke(logMessage);
                }
            }
            else if(userMove == "Skjuta")
            {
                if (User.CanShoot())
                {
                    if (computerMove == "Ladda")
                    {
                        User.Shoot();
                        GameLog.Invoke(logMessage);
                        UserWon userWin = new UserWon();
                        userWin.ShowDialog();
                    }
                    else if (computerMove == "Blocka")
                    {
                        User.Shoot();
                        GameLog.Invoke(logMessage);
                    }
                    else if (computerMove == "Skjuta")
                    {
                        User.Shoot();
                        Computer.Shoot();
                        GameLog.Invoke(logMessage);
                    }
                }else
                {
                    MessageBox.Show("Du har inga skott");
                }
            }
            else if (userMove == "Shotgun")
            {
                if (User.Shotgun())
                {
                    User.Shotgun();
                    GameLog.Invoke(logMessage);
                    UserWon userWon = new UserWon();
                    userWon.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Du har inte tillräckligt med skott");
                }
            }
        }
        private string ComputerMove()
        {
            List<string> computerMove = new List<string> { "Ladda", "Blocka" };
            if (Computer.Bullets > 2)
            {
                GameLog.Invoke("Dator: SHOTGUN");
                GameOver gameOver = new GameOver();
                gameOver.ShowDialog();
            }
            else if (Computer.CanShoot())
            {
                computerMove.Add("Skjuta");
            }
            Random random = new Random();
            int index = random.Next(computerMove.Count);
            return computerMove[index];
            }
    }
}
