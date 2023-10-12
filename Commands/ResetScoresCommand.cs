using TicTacToeTest.ViewModels;

namespace TicTacToeTest.Commands
{
    public class ResetScoresCommand : CommandBase
    {
        private readonly BoardViewModel _boardViewModel;
        
        private readonly ResetBoardCommand _resetBoardCommand;

        public ResetScoresCommand(BoardViewModel boardViewModel)
        {
            _boardViewModel = boardViewModel;
            
            _resetBoardCommand = boardViewModel.ResetBoardCommand;
        }
        public override void Execute(object? parameter)
        {
            _boardViewModel.Player1_Wins = 0;            
            _boardViewModel.Player2_Wins = 0;

            _resetBoardCommand.Execute(null);
        }
        
    }
}
