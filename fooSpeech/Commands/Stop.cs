using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeScales.Http;
using CodeScales.Http.Entity;
using CodeScales.Http.Methods;

namespace httpFoo.Commands
{
    class Stop : Command
    {
        public Stop() : base("Para", new Uri("http://localhost:8888/default/?cmd=Stop&param1="))
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