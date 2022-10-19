using Calculator_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator_MVVM.Commands
{
    internal class NumberInputCommand : ICommand
    {
        private CalculatorViewModel ViewModel { get; set; }

        public NumberInputCommand(CalculatorViewModel viewModel)
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
            if (parameter != null)
            {
                if (double.TryParse(parameter.ToString(), out double number))
                {
                    this.ViewModel.ResultValue = this.ViewModel.ResultValue * 10 + number;
                }
                else if (parameter.ToString() == "C")
                {
                    this.ViewModel.ResultValue = 0;
                    this.ViewModel.FirstValue = 0;
                    this.ViewModel.SecondValue = 0;
                    this.ViewModel.OperatorExecute = "";
                }
            }
        }
    }
}
