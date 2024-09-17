using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive;
using System.Text;
using Avalonia.Controls;
using AvaloniaApplication1.Views;
using ReactiveUI;
namespace AvaloniaApplication1.ViewModels
{
    public class MessageBoxViewModel : ViewModelBase, INotifyPropertyChanged
    {

        public MessageBoxViewModel(string title, string mainform, int i)
        {
            TitleText = title;
            MainText = mainform;
           
        }
        private string _TitleText = "123123";

        public string TitleText
        {
            get { return _TitleText; }
            set
            {
                _TitleText = value;
                OnPropertyChanged(nameof(TitleText));
            }
        }
        private string _MainText = "123222222222222223";

        public string MainText
        {
            get { return _MainText; }
            set
            {
                _MainText = value;
                OnPropertyChanged(nameof(MainText));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
