using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using Avalonia.Controls;
using AvaloniaApplication1.Views;
using ReactiveUI;
namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ReactiveUI.ReactiveCommand<Unit, Unit> Greeting { get; }
        private IDialogService _dialogService;
        private Window _mainWindow;
        public MainWindowViewModel(Window owner)
        {
            _dialogService = new DialogService();
            _mainWindow = owner;
             Greeting = ReactiveUI.ReactiveCommand.Create(Exce);
        }

        public void Exce()
        {

        
            _dialogService.ShowWindow1(_mainWindow);
        }
    }
}
