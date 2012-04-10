using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fooSpeech.Commands
{
    class NextMusic :Command
    {
        public NextMusic()
            : base("Proxima Musica", new Uri("http://localhost:8888/ajquery/?cmd=StartNext&param3=NoResponse"))
        {
        }
    }
}
