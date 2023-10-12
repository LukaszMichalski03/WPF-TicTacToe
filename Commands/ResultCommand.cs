using System.Collections.Generic;
using TicTacToeTest.ViewModels;

namespace TicTacToeTest.Commands
{
    public class ResultCommand : CommandBase
    {
        private readonly List<SingleElementViewModel> _boardElements;
        private readonly BoardViewModel _boardViewModel;        
        
        public ResultCommand(BoardViewModel boardViewModel)
        {
            _boardElements = boardViewModel.BoardElements;
            _boardViewModel = boardViewModel;            
        }

        public override void Execute(object? parameter)
        {     
            if(IfDraw()) _boardViewModel.ResetBoardCommand.Execute(null);
            else if (
                !IfDraw()&&(
                (_boardElements[0].Symbol == _boardElements[3].Symbol && _boardElements[0].Symbol == _boardElements[6].Symbol) && _boardElements[0].Symbol != "" ||
                (_boardElements[1].Symbol == _boardElements[4].Symbol && _boardElements[1].Symbol == _boardElements[7].Symbol) && _boardElements[1].Symbol != "" ||
                (_boardElements[2].Symbol == _boardElements[5].Symbol && _boardElements[2].Symbol == _boardElements[8].Symbol) && _boardElements[2].Symbol != "" ||
                (_boardElements[0].Symbol == _boardElements[1].Symbol && _boardElements[0].Symbol == _boardElements[2].Symbol) && _boardElements[0].Symbol != "" ||
                (_boardElements[3].Symbol == _boardElements[4].Symbol && _boardElements[3].Symbol == _boardElements[5].Symbol) && _boardElements[3].Symbol != "" ||
                (_boardElements[6].Symbol == _boardElements[7].Symbol && _boardElements[6].Symbol == _boardElements[8].Symbol) && _boardElements[6].Symbol != "" ||
                (_boardElements[0].Symbol == _boardElements[4].Symbol && _boardElements[0].Symbol == _boardElements[8].Symbol) && _boardElements[0].Symbol != "" ||
                (_boardElements[2].Symbol == _boardElements[4].Symbol && _boardElements[2].Symbol == _boardElements[6].Symbol) && _boardElements[2].Symbol != ""
                ))
                {
                    int X =0, O =0;
                    foreach ( var boardElement in _boardElements )
                    {
                        if (boardElement.Symbol == "X") X++;
                        if (boardElement.Symbol == "O") O++;
                    
                    }                
                
                    if (X>O && X!=0) _boardViewModel.Player1_Wins++;
                    else _boardViewModel.Player2_Wins++;
                
                    _boardViewModel.ResetBoardCommand.Execute(null);
                }           
            
        }
        public bool IfDraw()
        {
            int i = 0;
            foreach(var Element in _boardElements )
            {
                if (Element.Symbol == "X" || Element.Symbol == "O") i++;                
            }
            if (i >=9) return true;
            return false;

        }
    }
}
