namespace Utilities
{
    using System;
    using System.ComponentModel;

    public class PropertyContainerBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        private readonly IEventDispatcher _dispatcher;

        protected PropertyContainerBase(IEventDispatcher dispatcher)
        {
            this._dispatcher = dispatcher;
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;

            if (handler == null)
                return;
            
            var args = new PropertyChangedEventArgs(propertyName);
            
            Action action = () => handler(this, args);

            _dispatcher.Dispatch(action);
        }
    }
}