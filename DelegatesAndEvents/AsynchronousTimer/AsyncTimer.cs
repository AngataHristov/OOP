
namespace AsynchronousTimer
{
    using System;
    using System.Timers;

    public class AsyncTimer
    {
        private double interval;

        private int ticks;

        public AsyncTimer(Action action, int ticks, double interval)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.Interval = Interval;
            this.InternalTimer = new Timer();
        }

        private Action Action { get; set; }

        private int Ticks
        {
            get { return this.ticks; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be a non-negative number!");
                }

                this.ticks = value;
            }

        }

        private double Interval
        {
            get { return this.interval; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be a non-negative number!");
                }

                this.interval = value;
            }
        }

        private Timer InternalTimer { get; set; }

        public void Run()
        {
            this.InternalTimer.Elapsed += this.OnTimeEvent;
            this.InternalTimer.AutoReset = true;
            this.InternalTimer.Enabled = true;
        }

        private void OnTimeEvent(object source, ElapsedEventArgs e)
        {
            this.Action();

            if (this.Ticks <= 1)
            {
                this.InternalTimer.AutoReset = false;
                this.InternalTimer.Enabled = false;
            }

            this.Ticks--;
        }

        //  // makes sure the Asynchronous Timer will be working on the background
        //  public void ExecuteAction()
        //  {
        //      Thread parallelThread = new Thread(this.Run);
        //      parallelThread.Start();
        //  }
        // 
        //  private void Run()
        //  {
        //      // counts "Ticks"
        //      for (int i = 0; i < this.Ticks; i++)
        //      {
        //          Thread.Sleep(this.T); // adds a "T" milliseconds interval between ticks
        //          Random random = new Random();
        // 
        //          if (this.MethodToExecute != null)
        //          {
        //              this.MethodToExecute(random.Next(33, 127)); // adds a random number as argument, each time the method is executed
        //          }
        //      }
        //  }
    }
}
