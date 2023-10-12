namespace TicTacToeTest.Stores
{
    public class CurrentPlayerStore
    {
        private int _currentPlayer = 1;
        public int CurrentPlayer
        {
            get { return _currentPlayer; }
            set
            {
                _currentPlayer = value;
            }
        }

        public void ChangePlayerTurn()
        {
            if (CurrentPlayer == 1) { CurrentPlayer = 2; }
            else CurrentPlayer = 1;
        }
    }
}
