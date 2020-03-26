using System.ComponentModel;

namespace Organizeit
{
   //[ImplementPropertyChanged]
   /// <summary>
   /// Базовая ViewModel посылающая PropertyChanged при необходимости
   /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие откликающееся при измении значения свойства потомка
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Вызвает событие <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
