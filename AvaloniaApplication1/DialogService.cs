using Avalonia.Controls;
using AvaloniaApplication1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1
{
    public interface IDialogService
    {
        void ShowDialog(Window owner, Action onClosed);
        void ShowDialog2(Window owner);
        void ShowWindow1(Window owner);
        void MassegeBox(Window owner);
    }

    class DialogService : IDialogService
    {
        public void ShowDialog(Window owner, Action onClosed)
        {
            
                var dialog = new DialogWindow();
            dialog.Closed += (sender, e) =>
            {
                onClosed?.Invoke();
            };
            dialog.ShowDialog(owner);
         


        }

        public void ShowDialog2(Window owner)
        {
          
           
                var dialog = new Window2();
                dialog.ShowDialog(owner);
            
        }
        public void ShowWindow1(Window owner)
        {


            var dialog = new Window1();
            dialog.ShowDialog(owner);

        }
        public void MassegeBox(Window owner)
        {


            var dialog = new MessageBox("Ошибка", "Ошибка #1", 1);
            dialog.ShowDialog(owner);
            dialog.Closed += (sender, e) =>
            {

            };

        }
    }
}