namespace TicTacToeTest.ViewModels
{
    public class SingleElementViewModel : ViewModelBase
    {        
        private string _symbol;
        public string Symbol
        {
            get { return _symbol; }
            set
            {
                if (_symbol != value)
                {
                     _symbol = value;
                    OnPropertyChanged(nameof(Symbol));
                }
            }
        }        
    }
}
