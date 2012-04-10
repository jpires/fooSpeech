using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fooSpeech.Commands
{
    class Play : Command
    {
        public Play()
            : base("Inicio", new Uri("http://localhost:8888/ajquery/?cmd=Start&param1=0&param3=NoResponse"))
        {
        }
    }
}
