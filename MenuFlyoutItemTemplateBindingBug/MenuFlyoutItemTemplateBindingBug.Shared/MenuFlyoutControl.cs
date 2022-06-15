using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MenuFlyoutItemTemplateBindingBug
{
    public partial class MenuFlyoutControl : Control
    {
        public ICommand Action1
        {
            get { return (ICommand)GetValue(Action1Property); }
            set { SetValue(Action1Property, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Action1Property =
            DependencyProperty.Register("Action1", typeof(ICommand), typeof(MenuFlyoutControl), new PropertyMetadata(null));

        public ICommand Action2
        {
            get { return (ICommand)GetValue(Action2Property); }
            set { SetValue(Action2Property, value); }
        }

        // Using a DependencyProperty as the backing store for Action2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Action2Property =
            DependencyProperty.Register("Action2", typeof(ICommand), typeof(MenuFlyoutControl), new PropertyMetadata(null));
    }
}
