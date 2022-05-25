using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLT_data_balance
{
    internal class Calculate
    {
        public Result calculateRemaining(double std_usage, double tot_usage, string package)
        {
            Result result;
            double day_amount = 40;
            double night_amount = 60;

            double day_rem = day_amount - std_usage;
            double night_rem = night_amount - (tot_usage - std_usage);

            result = new Result(Math.Round(day_rem, 2), Math.Round(night_rem, 2));

            return result;
        }
    }
}
