﻿//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

using System;
using System.Windows.Input;

namespace ZsutPw.Patterns.WindowsApplication.Utilities
{
    public class ControllerCommand : ICommand
    {
        private readonly Func<bool> canExecute;

        private readonly Action execute;

        public ControllerCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            this.execute = execute;
            this.canExecute = canExecute;
        }

        public ControllerCommand(Action execute) : this(execute, null)
        {
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute();
        }

        public void Execute(object parameter)
        {
            execute();
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;

            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}