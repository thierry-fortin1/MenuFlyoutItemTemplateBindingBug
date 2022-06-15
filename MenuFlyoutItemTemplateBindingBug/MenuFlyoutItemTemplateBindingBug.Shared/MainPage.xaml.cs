using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MenuFlyoutItemTemplateBindingBug
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = new ViewModel(() =>
            {
                TextTest.Text = "command is executed";
            });
        }
        public class ViewModel
        {
            public ViewModel(Action a)
            {
                CustomCommand = new ButtonActionCommand(a);
            }

            public ButtonActionCommand CustomCommand { get; set; }
        }
    }

    public class ButtonActionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public ButtonActionCommand(Action a)
        {
            _action = a;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        private readonly Action _action;
    }
}
