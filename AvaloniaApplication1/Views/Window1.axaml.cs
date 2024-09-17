using Avalonia.Controls;
using AvaloniaApplication1.ViewModels;

namespace AvaloniaApplication1.Views
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataContext = new Window1ViewModel(this);
        }
    }
}
