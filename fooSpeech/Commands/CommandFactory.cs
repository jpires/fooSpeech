using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace httpFoo.Commands
{
    static class CommandFactory
    {
        private static Command[] commands = {new Play(), new Stop()};


        public static Command Contruct(String command)
        {
            foreach (Command c in commands)
                if (c.CommandText == command)
                    return c;

            return null;
        }
    }
}