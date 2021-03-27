using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public delegate void Handler();

    class Clock
    {
        public int hour { get; set; }
        public int min { get; set; }
        public int sec { get; set; }

        public int aHour { get; set; }
        public int aMin { get; set; }
        public int aSec { get; set; }

        public event Handler Tick;
        public event Handler Alarm;

        public Clock(int hour, int min, int sec, int aHour, int aMin, int aSec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
            this.aHour = aHour;
            this.aMin = aMin;
            this.aSec = aSec;
        }
        public void Run()
        {
            //trigger the event
            Tick();
            Alarm();
        }

        public void tick()
        {
            while (!(hour == aHour && min == aMin && sec == aSec))
            {
                Console.WriteLine($"{hour}:{min}:{sec}");
                sec = (sec + 1) % 60;
                if (sec == 0)
                {
                    min = (min + 1) % 60;
                    if (min == 0)
                    {
                        hour = (hour + 1) % 24;
                    }
                }
                System.Threading.Thread.Sleep(1000);//set the time interval to be 1s
            }
        }

        public void alarm()
        {
            Console.WriteLine($"{hour}:{min}:{sec} Time is up!\a");
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            Clock clock = new Clock(15, 59, 55, 16, 0, 5);
            clock.Tick += new Handler(clock.tick);
            clock.Alarm += new Handler(clock.alarm);

            clock.Run();

        }
    }
}
