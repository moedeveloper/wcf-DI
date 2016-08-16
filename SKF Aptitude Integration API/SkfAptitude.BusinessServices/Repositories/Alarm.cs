using SkfAptitude.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkfAptitude.BusinessServices
{
    public class Alarm : IAlarm
    {
        public string ReturnString()
        {
            Connection.Create();
            return "Testing";
        }
    }
}
