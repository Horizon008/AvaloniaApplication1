using Avalonia.Controls;
using AvaloniaApplication1.ViewModels;

namespace AvaloniaApplication1.Views
{
    public partial class MessageBox : Window
    {
        public string title { get; set; }
        public string mainform { get; set; }
        public int i { get; set; }
        public MessageBox(/*string ti, string main, int i*//*a*/)
        {

            InitializeComponent();
            ////title = ti;
            ////mainform = main;
            ////i = ia;
            DataContext = new MessageBoxViewModel(title, mainform, i);
        }
        
        public MessageBox(string ti, string main, int ia)
        {

 
            title = ti;
            mainform = main;
            i = ia;
            DataContext = new MessageBoxViewModel(title, mainform, i);
        }
    }
}
