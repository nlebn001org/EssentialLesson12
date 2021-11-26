using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson12Task2
{
    class Presenter
    {
        Model model = null;
        MainWindow view = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.view = mainWindow;
            this.view.MyEvent += new EventHandler(mainWindow_Event);
        }

        void mainWindow_Event(object sender, EventArgs e)
        {
            var data = this.view.MainTextBox.Text;
            string variable = model.Logic(data);
            this.view.MainTextBox.Text = variable;
        }

    }
}
