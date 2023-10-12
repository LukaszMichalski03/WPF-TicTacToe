using System.Collections.Generic;
using TicTacToeTest.Stores;
using TicTacToeTest.ViewModels;

namespace TicTacToeTest.Commands
{
    public class DrawSignCommand : CommandBase
    {
        
        private List<SingleElementViewModel> _boardElements => _boardViewModel.BoardElements;
        private readonly int _index;
        private readonly CurrentPlayerStore _currentPlayerStore;
        private readonly BoardViewModel _boardViewModel;        


        public ResultCommand ResultCommand; 

        public DrawSignCommand(CurrentPlayerStore currentPlayerStore, BoardViewModel boardViewModel, int index)
        {
           
            _currentPlayerStore = currentPlayerStore;
            _boardViewModel = boardViewModel;
            _index = index;
            ResultCommand = new ResultCommand(boardViewModel);                      
        }        

        public override void Execute(object? parameter)
        {            
            if (_currentPlayerStore.CurrentPlayer == 1)
            {
                _boardElements[_index].Symbol = "X";                
            }
            else _boardElements[_index].Symbol = "O";

            _currentPlayerStore.ChangePlayerTurn();            

            ResultCommand.Execute(null);
        }
        public override bool CanExecute(object? parameter)
        {            
            return string.IsNullOrEmpty(_boardElements[_index].Symbol);            
        }        
    }
}
