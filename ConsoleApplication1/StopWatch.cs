using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StopWatch
    {
        private TimeSpan _duration;
        private DateTime _start;
        private DateTime _stop;
        private bool _startProtect;

        public StopWatch()
        {
            _duration = new TimeSpan(0, 0, 0, 0, 0);
            _startProtect = false;
        }
        public void SetDuration()
        {
            _duration = _duration + (this.GetStop() - this.GetStart());
        }
        public TimeSpan GetDuration()
        {
            return _duration;
        }
        public void SetStart()
        {
            try
            {
                if (!_startProtect)
                {
                    _start = DateTime.Now;
                    _startProtect = true;
                }
                else
                    throw new Exception();
            }
            catch(Exception e)
            {
                Console.WriteLine("You cannot Start the timer twice in a row!");
            }
            
            
        }
        public DateTime GetStart()
        {
            return _start;
        }
        public void SetStop()
        {
           _stop = DateTime.Now;
            this.SetDuration();
            _startProtect = false;
        }
        public DateTime GetStop()
        {
            return _stop;
        }
        public void ClearTime()
        {
            _duration = new TimeSpan(0, 0, 0, 0);
            _startProtect = false;
        }

    }
}
