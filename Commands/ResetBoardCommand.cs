using System.Collections.Generic;
using TicTacToeTest.Stores;
using TicTacToeTest.ViewModels;

namespace TicTacToeTest.Commands
{
    public class ResetBoardCommand : CommandBase
    {
       
        private readonly CurrentPlayerStore _currentPlayerStore;
        
        private List<SingleElementViewModel> _boardElements;

        public ResetBoardCommand(BoardViewModel boardViewModel, CurrentPlayerStore currentPlayerStore)
        {            
            _currentPlayerStore = currentPlayerStore;            
            _boardElements = boardViewModel.BoardElements;
        }
        public override void Execute(object? parameter)
        {
            foreach (var element in _boardElements)
            {
                element.Symbol = string.Empty;                
            }
            
            _currentPlayerStore.CurrentPlayer = 1;
        }
    }
}
