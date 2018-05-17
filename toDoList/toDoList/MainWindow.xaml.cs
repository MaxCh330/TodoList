using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace toDoList
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void minimum_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void maximum_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void data_MouseDown(object sender, MouseButtonEventArgs e)
        {

            List <string> all = new List <string>() ;

            foreach (UserControl1 todoitem in TodoStack.Children)
            {
                all.Add (todoitem.getTaskName());
            }
            System.IO.File.WriteAllLines(@"C:\Data",all);
        }

        private void Tasks_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //
            UserControl1 todoitem = new UserControl1();
            //
            TodoStack.Children.Add(todoitem);
        }
    }
}
