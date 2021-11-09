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

namespace HomeWork1WpfAppV1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*
             
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Ввидите целое число. Х=");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввидите целое число. Y=");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("      1 - сложение");
                Console.WriteLine("      2 - вычетание");
                Console.WriteLine("      3 - умножение");
                Console.WriteLine("      4 - деление");
                Console.Write("Ваш выбор:");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1: { Console.WriteLine("Результат = {0}", a + b); break; }
                    case 2: { Console.WriteLine("Результат = {0}", a - b); break; }
                    case 3: { Console.WriteLine("Результат = {0}", a * b); break; }
                    case 4: { Console.WriteLine("Результат = {0}", a / b); break; }
                    default: { Console.WriteLine("Нет операции с указанным номером"); } break;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.ReadKey();
            */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
