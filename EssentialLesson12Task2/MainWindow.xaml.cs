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



//Задание
//Измените существующий проект данного урока 003_MVP, расширив его добавлением методов доступа add и remove к событию.

namespace EssentialLesson12Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);                                                                        // this - MainWindow
        }

        event EventHandler myEvent = null;
        public event EventHandler MyEvent { add => myEvent += value; remove => myEvent -= value; }

        private void MainButton_Click(object sender, RoutedEventArgs e)                                 // sender- button, e - event data
        {
            myEvent.Invoke(sender, e);
        }
    }
}
