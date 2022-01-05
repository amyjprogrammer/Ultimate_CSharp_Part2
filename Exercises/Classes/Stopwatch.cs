using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Classes
{
    public class Stopwatch
    {
        public DateTime Start()
        {
            return DateTime.Now;
        }

        public DateTime Stop()
        {
            return DateTime.Now;
        }

        public double Duration
        {
            get
            {
                var duration = Start().Second - Stop().Second;
                return duration;
            }
        }
    }
}
