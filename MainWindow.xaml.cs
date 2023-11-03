using System;
using System.Windows;
using System.Windows.Controls;
namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private string _currentNumber = "";
        private string _currentOperation = "";
        private double _result = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            switch (_currentOperation)
            {
                case "+":
                    _result += double.Parse(_currentNumber);
                    break;
                case "-":
                    _result -= double.Parse(_currentNumber);
                    break;
                case "*":
                    _result *= double.Parse(_currentNumber);
                    break;
                case "/":
                    _result /= double.Parse(_currentNumber);
                    break;
            }
            result.Text = _result.ToString();
            _currentNumber = _result.ToString();
        }
        private void CEButton_Click(object sender, RoutedEventArgs e)
        {
            _currentNumber = "";
            result.Text = "0";
        }
        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            _currentNumber = "";
            _currentOperation = "";
            _result = 0;
            result.Text = "0";
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentNumber.Length > 0)
            {
                _currentNumber = _currentNumber.Substring(0, _currentNumber.Length - 1);
                result.Text = _currentNumber;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            _currentNumber += button.Content;
            result.Text = _currentNumber;
        }
        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            _currentOperation = button.Content.ToString();
            _result = double.Parse(_currentNumber);
            _currentNumber = "";
        }
    }
}