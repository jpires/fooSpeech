using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fooSpeech.Commands
{
    class Continue : Command
    {   
        public Continue() :
            base("Continua", new Uri("http://localhost:8888/ajquery/?cmd=PlayOrPause&param3=NoResponse"))
        {
        }
    }
}
