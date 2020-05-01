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
using Algorithms.Parsers;

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
                result.Content = input.Text;

                Parser parsedValue = new Parser();
                List<int> convertedInput = parsedValue.StringToIntList(input.Text);

                BubbleSorting t = new BubbleSorting();
                result.Content = t.Sort(convertedInput);
            };

            if ((bool)fibonacci.IsChecked) MessageBox.Show(fibonacci.Name);

        }

        // code for parse functionality testing
        private void Parse(object sender, RoutedEventArgs e)
        {
            Parser parsedValue = new Parser();
            List<int> res = new List<int>();

            res = parsedValue.StringToIntList(input.Text);
            
            string rest = "";
            res.ForEach(x => 
            {
                x.ToString();
                rest = rest + x;
            });
            result.Content = rest;
        }
    }
}
