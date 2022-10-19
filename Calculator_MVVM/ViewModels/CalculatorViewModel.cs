using Calculator_MVVM.Commands;
using LibraryCalculate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator_MVVM.ViewModels
{
    internal class CalculatorViewModel : INotifyPropertyChanged
    {
        public ICommand NumberInput { get; set; }
        public ICommand Calculate { get; set; }
        public ICommand Operator { get; set; }   
        public string OperatorExecute { get; set; }
        public double SecondValue { get; set; }
        public double FirstValue { get; set; }



        public CalculatorViewModel()
        {
            NumberInput = new NumberInputCommand(this);
            Calculate = new CalculateCommand(this, new OperationCaller());
            Operator = new OperatorCommand(this);    
        }

        public double ResultValue
        {
            get => SecondValue;

            set
            {
                if (SecondValue != value)
                {
                    SecondValue = value;
                    RaisePropertyChanged();
                }
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (!string.IsNullOrEmpty(propertyName))
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
