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
            button0.Click += NumberButton_Click;
            button1.Click += NumberButton_Click;
            button2.Click += NumberButton_Click;
            button3.Click += NumberButton_Click;
            button4.Click += NumberButton_Click;
            button5.Click += NumberButton_Click;
            button6.Click += NumberButton_Click;
            button7.Click += NumberButton_Click;
            button8.Click += NumberButton_Click;
            button9.Click += NumberButton_Click;
            plus.Click += OperationButton_Click;
            take_away.Click += OperationButton_Click;
            multiply.Click += OperationButton_Click;
            share.Click += OperationButton_Click;
            equal.Click += EqualButton_Click;
            CE.Click += CEButton_Click;
            C.Click += CButton_Click;
            Back.Click += BackButton_Click;
        }
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            _currentNumber += button.Content;
            result.Text = _currentNumber;
        }
        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            _currentOperation = button.Content.ToString();
            _result = double.Parse(_currentNumber);
            _currentNumber = "";
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
    }
}