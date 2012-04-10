using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fooSpeech.Commands
{
    class PreviousMusic : Command
    {
        public PreviousMusic()
            : base("Musica Anterior", new Uri("http://localhost:8888/ajquery/?cmd=StartPrevious&param3=NoResponse"))
        {
        }
    }
}
