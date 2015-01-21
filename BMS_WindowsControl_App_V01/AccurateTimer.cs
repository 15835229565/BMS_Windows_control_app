using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PCANBasicExample
{
    public class AccurateTimer
    {

        //public event EventHandler<EventArgs> Tick;
        public event TickHandler Tick;
        public delegate void TickHandler(AccurateTimer m, EventArgs e);

        public bool Running { get; private set; }
        public int Interval { get; private set; }

        public AccurateTimer(int interval_ = 1000)
        {
            Running = false;
            Interval = interval_;
        }

        public void Start()
        {
            Running = true;
            Thread thread = new Thread(Run);
            thread.Start();
        }

        public void Stop()
        {
            Running = false;
        }

        private void Run()
        {
            DateTime nextTick = DateTime.Now.AddMilliseconds(Interval);
            while (Running)
            {
                if (DateTime.Now > nextTick)
                {
                    nextTick = nextTick.AddMilliseconds(Interval);
                    OnTick(EventArgs.Empty);
                    
                }
            }
        }

        protected void OnTick(EventArgs e)
        {
            if (Tick != null)
            {
                Tick(this, e);
            }

        }

    }

}
