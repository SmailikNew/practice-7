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

namespace practice_7
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

        private Money sum1;
        private Money sum2;

        private void exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-34, Горшков Илья, Вариант 2. Использовать класс Pair (пара чисел). Определить класс-наследник Money с характеристиками: рубли и копейки. Переопределить операцию сложения и определить методы вычитания и деления денежный сумм.");
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            rez.Clear();
            firstP1.Clear();
            secondP1.Clear();
            secondP2.Clear();
            firstP2.Clear();
            secondP2.Clear();
        }

        private void summation(object sender, RoutedEventArgs e)
        {
            sum1 = new Money(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            sum2 = new Money(int.Parse(firstP2.Text), int.Parse(secondP2.Text));
            Money result = sum1.Sum(sum2);
            rez.Text = result.Rubles  + "," + result.Kopecks;
        }

        private void substract(object sender, RoutedEventArgs e)
        {
            sum1 = new Money(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            sum2 = new Money(int.Parse(firstP2.Text), int.Parse(secondP2.Text));
            Money result = sum1.Minus(sum2);
            rez.Text = result.Rubles + "," + result.Kopecks;
        }

        private void devide(object sender, RoutedEventArgs e)
        {
            sum1 = new Money(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            sum2 = new Money(int.Parse(firstP2.Text), int.Parse(secondP2.Text));
            Money result = sum1.Divide(sum2);
            rez.Text = result.Rubles + "," + result.Kopecks;
        }
    }
}
