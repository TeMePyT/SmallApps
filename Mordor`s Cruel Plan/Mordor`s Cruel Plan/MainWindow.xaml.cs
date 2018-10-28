using MoodCalculatorLibrary;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Mordor_s_Cruel_Plan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string str;
        Gandalf gandalf = new Gandalf();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gandalf = new Gandalf();
            gandalf.Eat(str.Split().Where(fn => fn != String.Empty).Select(fn => FoodFactory.GetFood(fn)));
            Mood.Content = gandalf;
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            str = Input.Text;
        }

      
    }
}
