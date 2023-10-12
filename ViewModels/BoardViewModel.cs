using System.Collections.Generic;
using TicTacToeTest.Commands;
using TicTacToeTest.Stores;

namespace TicTacToeTest.ViewModels
{
    public class BoardViewModel : ViewModelBase
    {
        private int _player1Wins=0;
        public int Player1_Wins
        {
            get { return _player1Wins; }
            set
            {
                _player1Wins = value;
                OnPropertyChanged(nameof(Player1_Wins));
            }
        }

        private int _player2Wins=0;
        public int Player2_Wins
        {
            get { return _player2Wins; }
            set
            {
                _player2Wins = value;
                OnPropertyChanged(nameof(Player2_Wins));
            }
        }

        private List<SingleElementViewModel> _boardElements;
        public List<SingleElementViewModel> BoardElements
        {
            get { return _boardElements; }
            set
            {
                _boardElements = value;                
            }
        }

        private readonly CurrentPlayerStore _currentPlayerStore;
        public int CurrentPlayerStore => _currentPlayerStore.CurrentPlayer;

        public BoardViewModel(CurrentPlayerStore currentPlayerStore)
        {
            
            InitializeBoardElements();
            _currentPlayerStore = currentPlayerStore;            
        }
                

        public ResetScoresCommand ResetScoresCommand => new(this);
        public ResetBoardCommand ResetBoardCommand => new(this, _currentPlayerStore);
        public List<DrawSignCommand> DrawSignCommands => new()
        {
            new DrawSignCommand(_currentPlayerStore, this,0),
            new DrawSignCommand(_currentPlayerStore, this,1),
            new DrawSignCommand(_currentPlayerStore, this,2),
            new DrawSignCommand(_currentPlayerStore, this,3),
            new DrawSignCommand(_currentPlayerStore, this,4),
            new DrawSignCommand(_currentPlayerStore, this,5),
            new DrawSignCommand(_currentPlayerStore, this,6),
            new DrawSignCommand(_currentPlayerStore, this,7),
            new DrawSignCommand(_currentPlayerStore, this,8),
        };

        private void InitializeBoardElements()
        {
            _boardElements = new List<SingleElementViewModel>
            {
                new SingleElementViewModel() { Symbol = "" },
                new SingleElementViewModel() { Symbol = "" },
                new SingleElementViewModel() { Symbol = "" },
                new SingleElementViewModel() { Symbol = "" },
                new SingleElementViewModel() { Symbol = ""},
                new SingleElementViewModel() { Symbol = "" },
                new SingleElementViewModel() { Symbol = "" },
                new SingleElementViewModel() { Symbol = "" },
                new SingleElementViewModel() { Symbol = "" }
            };            
        }
              

    }
}
