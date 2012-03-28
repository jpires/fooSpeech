using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeScales.Http;
using CodeScales.Http.Entity;
using CodeScales.Http.Methods;

namespace httpFoo.Commands
{
    class Play : Command
    {
        public Play() : base("Inicio", new Uri("http://localhost:8888/default/?cmd=Start&param1="))
        {
        }

        public override void Execute()
        {
            HttpClient cli = new HttpClient();
            HttpGet get = new HttpGet(Uri);
            HttpResponse resp = cli.Execute(get);
        }
    }
}
