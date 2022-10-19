using Calculator_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator_MVVM.Commands 
{
    internal class OperatorCommand : ICommand
    {
        private CalculatorViewModel ViewModel { get; set; }

        public OperatorCommand(CalculatorViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            this.ViewModel.OperatorExecute = parameter.ToString();
            ViewModel.FirstValue = ViewModel.SecondValue;
            ViewModel.ResultValue = 0;
        }
    }
}
