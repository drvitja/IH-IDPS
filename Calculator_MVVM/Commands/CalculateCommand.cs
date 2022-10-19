using Calculator_MVVM.ViewModels;
using System;
using LibraryCalculate;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator_MVVM.Commands
{
    internal class CalculateCommand : ICommand
    {
        private CalculatorViewModel _viewModel;
        private ICaller _caller;

        public CalculateCommand(CalculatorViewModel viewModel, ICaller caller)
        {
            this._viewModel = viewModel;
            this._caller = caller;
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
                    ICalculation calculation = this._caller.GetCalculation(_viewModel.OperatorExecute);
                    _viewModel.ResultValue = calculation.Execute(_viewModel.FirstValue, _viewModel.SecondValue);
            }
        }
    }
}
