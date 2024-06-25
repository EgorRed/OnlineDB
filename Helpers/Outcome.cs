using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class Outcome<Data>
    {
        public Status status { get; }
        public Data data { get; }

        public Outcome(Status _status, Data _data) 
        {
            status = _status;
            data = _data;
        }
    }
}
