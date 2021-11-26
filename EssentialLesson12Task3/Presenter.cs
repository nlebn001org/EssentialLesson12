using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;


namespace EssentialLesson12Task3
{
    class Presenter
    {
        MainWindow view = null;
        Model model = null;
        TimeSpan time;
        BackgroundWorker backgroundWorker1 = new BackgroundWorker();
        
        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            time = new TimeSpan(0, 0, 0);
            this.view = mainWindow;
            this.view.StartEvent += startPauseStopWatch_Event;
            this.view.StopEvent += StopStopWatch_Event;
            backgroundWorker1.DoWork += worker_DoWork;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                time = model.StartTimeWatch(time);
                Trace.WriteLine(time.ToString());
                view.stopWatchFrame.Dispatcher.BeginInvoke(() => view.stopWatchFrame.Text = time.ToString());
                Thread.Sleep(1000);

                if (backgroundWorker1.CancellationPending)
                {
                    Trace.WriteLine("Thread is exiting");
                    break;
                }
            }
        }

        public void startPauseStopWatch_Event(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                view.startButton.Content = "Pause";
            }
            else
            {
                backgroundWorker1.CancelAsync();
                view.startButton.Content = "Start";
            }
        }

        public void StopStopWatch_Event(object sender, EventArgs e)
        {
            time = new TimeSpan(0, 0, 0);

            view.Dispatcher.BeginInvoke(() => view.stopWatchFrame.Text = time.ToString());

            Trace.WriteLine(time);

            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                Trace.WriteLine("backgroundWorker1.CancelAsync()");
                view.startButton.Content = "Start";
            }
        }
    }
}
