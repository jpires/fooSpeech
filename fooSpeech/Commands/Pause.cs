using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fooSpeech.Commands
{
    class Pause: Command
    {
        public Pause()
            : base("Pausa", new Uri("http://localhost:8888/ajquery/?cmd=PlayOrPause&param3=NoResponse"))
        {
        }
    }
}
