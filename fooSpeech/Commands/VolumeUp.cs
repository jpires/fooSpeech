﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fooSpeech.Commands
{
    class VolumeUp : Command
    {
        public VolumeUp()
            : base("Aumentar Volume", new Uri("http://localhost:8888/ajquery/?cmd=VolumeDelta&param1=10&param3=NoResponse"))
        {
        }
    }
}
