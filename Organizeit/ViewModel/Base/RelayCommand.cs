using System;
using System.Windows.Input;

namespace Organizeit
{
    /// <summary>
    /// Базовая команда для запуска Действия
    /// </summary>
    public class RelayCommand : ICommand
    {
 
        #region Private Members

        /// <summary>
        /// действие для запуска
        /// </summary>
        private Action mAction;


        #endregion

        #region Public Events
        /// <summary>
        /// Событие срабатывающее когда значение <see cref="CanExecute(object)"/> было изменено
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => {};
        #endregion

        #region Constructor
        public RelayCommand(Action action)
        {
            mAction = action;
        }
        #endregion

        #region Command Methods

        /// <summary>
        /// команда ретрансляции всегда может быть выполнена
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет действие команды
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction();
        }

        #endregion
    }
}
