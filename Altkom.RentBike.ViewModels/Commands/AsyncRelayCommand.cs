﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Altkom.RentBike.ViewModels.Commands
{
    public class AsyncRelayCommand : ICommand
    {
        private readonly Func<object, Task> execute;
        private readonly Predicate<object> canExecute;

        private long isExecuting;

        public AsyncRelayCommand(Func<object, Task> execute, Predicate<object> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute ?? (o => true);
        }

        public event EventHandler CanExecuteChanged;

        //{
        //    add { CommandManager.RequerySuggested += value; }
        //    remove { CommandManager.RequerySuggested -= value; }
        //}

        //public void RaiseCanExecuteChanged()
        //{
        //    CommandManager.InvalidateRequerySuggested();
        //}

        public bool CanExecute(object parameter)
        {
            if (Interlocked.Read(ref isExecuting) != 0)
                return false;

            return canExecute(parameter);
        }

        public async void Execute(object parameter)
        {
            Interlocked.Exchange(ref isExecuting, 1);
          //  RaiseCanExecuteChanged();

            try
            {
                await execute(parameter);
            }
            finally
            {
                Interlocked.Exchange(ref isExecuting, 0);
          //      RaiseCanExecuteChanged();
            }
        }
    }
}
