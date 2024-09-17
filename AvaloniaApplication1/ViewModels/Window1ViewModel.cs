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
    public class Window1ViewModel : ViewModelBase
    {
        public ReactiveUI.ReactiveCommand<Unit, Unit> Greeting { get; }
        public ReactiveUI.ReactiveCommand<Unit, Unit> Greeting2 { get; }
        public ReactiveUI.ReactiveCommand<Unit, Unit> Greeting3 { get; }
        private IDialogService _dialogService;
        private Window _mainWindow;

        public Window1ViewModel(Window mainWindow)
        {
            _mainWindow = mainWindow;
            _dialogService = new DialogService();
           
            Greeting = ReactiveUI.ReactiveCommand.Create(Exce);
            Greeting2 = ReactiveUI.ReactiveCommand.Create(Exce2);
            Greeting3 = ReactiveUI.ReactiveCommand.Create(MassegeBox);
        }

        public void Exce()
        {
            try
            {
                _dialogService.ShowDialog(_mainWindow, Res);

            }
            catch (Exception ex)
            {

            }
            //Res();
        }
        void Exce2()
        {
            try
            {
                _dialogService.ShowDialog2(_mainWindow);
            }
            catch (Exception ex)
            {

            }

        }
        void MassegeBox()
        {
            try
            {
                _dialogService.MassegeBox(_mainWindow);
            }
            catch (Exception ex)
            {

            }

        }


        public void Res()
        {
            MainText = "Успех";
       
        }

        private string _MainText;
        public string MainText
        {
            get => _MainText;
            private set
            {
                _MainText = value;
                OnPropertyChanged();
            }
        }

    }
}
