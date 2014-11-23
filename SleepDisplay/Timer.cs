using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepDisplay
{
    class Timer
    {
        public delegate void Update(int second);

        private int second;
        private readonly Update update;
        private readonly System.Windows.Forms.Timer timer;

        public Timer(int theSecond, Update theUpdate)
        {
            second = theSecond;
            update = theUpdate;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Pass);
        }

        private void Pass(Object sender, EventArgs e)
        {
            if (second > 0)
            {
                second--;
            }

            update(second);
        }

        public void Start()
        {
            timer.Start();
        }
    }
}
