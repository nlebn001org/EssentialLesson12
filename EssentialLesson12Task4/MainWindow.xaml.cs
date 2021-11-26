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

namespace EssentialLesson12Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double first;
        double second;
        char sign;
        bool isFirstEntered = false;
        bool isSecondEntered = true;

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            LabelShow.Content = "0";
            first = 0;
            second = 0;
            isFirstEntered = false;
            isSecondEntered = true;
            sign = ' ';
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() == "Divided by zero.")
                LabelShow.Content = "1";
            else if (LabelShow.Content.ToString() == "0")
                LabelShow.Content = "1";
            else
                LabelShow.Content = LabelShow.Content + "1";
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() == "Divided by zero.")
                LabelShow.Content = "2";
            else if (LabelShow.Content.ToString() == "0")
                LabelShow.Content = "2";
            else
                LabelShow.Content = LabelShow.Content + "2";
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() == "Divided by zero.")
                LabelShow.Content = "3";
            else if (LabelShow.Content.ToString() == "0")
                LabelShow.Content = "3";
            else
                LabelShow.Content = LabelShow.Content + "3";
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() == "Divided by zero.")
                LabelShow.Content = "4";
            else if (LabelShow.Content.ToString() == "0")
                LabelShow.Content = "4";
            else
                LabelShow.Content = LabelShow.Content + "4";
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() == "Divided by zero.")
                LabelShow.Content = "5";
            else if (LabelShow.Content.ToString() == "0")
                LabelShow.Content = "5";
            else
                LabelShow.Content = LabelShow.Content + "5";
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() == "Divided by zero.")
                LabelShow.Content = "6";
            else if (LabelShow.Content.ToString() == "0")
                LabelShow.Content = "6";
            else
                LabelShow.Content = LabelShow.Content + "6";
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() == "Divided by zero.")
                LabelShow.Content = "7";
            else if (LabelShow.Content.ToString() == "0")
                LabelShow.Content = "7";
            else
                LabelShow.Content = LabelShow.Content + "7";
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() == "Divided by zero.")
                LabelShow.Content = "8";
            else if (LabelShow.Content.ToString() == "0")
                LabelShow.Content = "8";
            else
                LabelShow.Content = LabelShow.Content + "8";
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() == "Divided by zero.")
                LabelShow.Content = "9";
            else if (LabelShow.Content.ToString() == "0")
                LabelShow.Content = "9";
            else
                LabelShow.Content = LabelShow.Content + "9";
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() == "Divided by zero.")
                LabelShow.Content = "0";
            else if (LabelShow.Content.ToString() == "0")
                LabelShow.Content = "0";
            else
                LabelShow.Content = LabelShow.Content + "0";
        }

        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            if (LabelShow.Content.ToString() != " " && !LabelShow.Content.ToString().Contains("."))
                LabelShow.Content = LabelShow.Content + ".";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (!isFirstEntered)
            {
                double.TryParse(LabelShow.Content.ToString(), out first);
                isFirstEntered = true;
            }
            else
            {
                double.TryParse(LabelShow.Content.ToString(), out second);
                isSecondEntered = true;
            }

            sign = '+';
            LabelShow.Content = "";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (!isFirstEntered)
            {
                double.TryParse(LabelShow.Content.ToString(), out first);
                isFirstEntered = true;
            }
            else
            {
                double.TryParse(LabelShow.Content.ToString(), out second);
                isSecondEntered = true;
            }

            sign = '-';
            LabelShow.Content = "";
        }

        private void ButtonDevide_Click(object sender, RoutedEventArgs e)
        {
            if (!isFirstEntered)
            {
                double.TryParse(LabelShow.Content.ToString(), out first);
                isFirstEntered = true;
            }
            else
            {
                double.TryParse(LabelShow.Content.ToString(), out second);
                isSecondEntered = true;
            }

            sign = '/';
            LabelShow.Content = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)         //mult
        {
            if (!isFirstEntered)
            {
                double.TryParse(LabelShow.Content.ToString(), out first);
                isFirstEntered = true;
            }
            else
            {
                double.TryParse(LabelShow.Content.ToString(), out second);
                isSecondEntered = true;
            }

            sign = '*';
            LabelShow.Content = "";
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;

            double.TryParse(LabelShow.Content.ToString(), out second);

            if (isSecondEntered && isSecondEntered)
            {
                switch (sign)
                {
                    case '+':
                        result = Math.Round((first + second), 4);
                        LabelShow.Content = result.ToString();
                        first = result;
                        sign = ' ';
                        //isSecondEntered = false;
                        break;

                    case '-':
                        result = Math.Round((first - second), 4);
                        LabelShow.Content = result.ToString();
                        first = result;
                        sign = ' ';
                        //isSecondEntered = false;
                        break;

                    case '*':
                        result = Math.Round((first * second), 4);
                        LabelShow.Content = result.ToString();
                        first = result;
                        sign = ' ';
                        //isSecondEntered = false;
                        break;

                    case '/':
                        if (second != 0)
                        {
                            result = Math.Round((first / second), 4);
                            LabelShow.Content = result.ToString();
                            first = result;
                            sign = ' ';
                            //isSecondEntered = false;
                            break;
                        }
                        else
                        {
                            LabelShow.Content = "Divided by zero.";
                            isFirstEntered = false;
                            isSecondEntered = false;
                            first = 0;
                            second = 0;
                            sign = ' ';
                            break;

                        }
                }
            }

            if (isFirstEntered && !isSecondEntered)
            {
                LabelShow.Content = first.ToString();
            }

        }
    }
}
