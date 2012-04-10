using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fooSpeech.Commands
{
    class Stop : Command
    {
        public Stop()
            : base("Para", new Uri("http://localhost:8888/ajquery/?cmd=Stop&param3=NoResponse"))
        {
        }
    }
}