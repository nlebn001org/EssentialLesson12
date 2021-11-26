using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson12Task3
{
    class Model
    {
        public TimeSpan StartTimeWatch(TimeSpan time) => new TimeSpan(time.Hours, time.Minutes, time.Seconds+1);

        public TimeSpan StopTimeWatch() => new TimeSpan(0,0,0);
    }
}

