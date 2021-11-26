using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AirBNB.Viewmodels.commands
{
    public class Show_SpecificLandlord : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action _execute;
        public Show_SpecificLandlord(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
            Console.WriteLine("showuserinfo word ge execute");
        }
    }
}
