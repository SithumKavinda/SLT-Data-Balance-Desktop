using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLT_data_balance
{
    internal class Result
    {
        private double day_remaining;
        private double night_remaining;

        public Result()
        {
        }

        public Result(double day_remaining, double night_remaining)
        {
            this.day_remaining = day_remaining;
            this.night_remaining = night_remaining;
        }

        public double getDayRemaining()
        {
            return day_remaining;
        }

        public double getNightRemaining()
        {
            return night_remaining;
        }
    }
}
