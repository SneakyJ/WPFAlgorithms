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
using Algorithms.Sorting;
using Algorithms.Convertors;

namespace Algorithms
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Process_Algorithm(object sender, RoutedEventArgs e)
        {
            // string output = "";

            if ((bool)bubble.IsChecked)
            {
                List<int> convertedInput = StringToIntList.Convert(input.Text);
                List<int> sortedList = Bubble.Sort(convertedInput);

                result.Content = IntListToString.Convert(sortedList);
            };

            if ((bool)selection.IsChecked) 
            {
                List<int> convertedInput = StringToIntList.Convert(input.Text);
                List<int> sortedList = Selection.Sort(convertedInput);

                result.Content = IntListToString.Convert(sortedList);
            }

            if ((bool)fibonacci.IsChecked) MessageBox.Show(fibonacci.Name);

        }
    }
}
