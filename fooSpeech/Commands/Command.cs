using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeScales.Http;
using CodeScales.Http.Entity;
using CodeScales.Http.Methods;

namespace fooSpeech.Commands
{
    abstract class Command
    {
        private String command;

        /// <summary>
        /// The text representation of the command
        /// </summary>
        public String CommandText
        {
            get { return command; }
            protected set { command = value; }
        }

        private Uri uri;
        /// <summary>
        /// The Uri where the resource is stored
        /// </summary>
        public Uri Uri
        {
            get { return uri; }
            protected set { uri = value; }
        }

        private Result result;

        internal Result Result
        {
            get { return result; }
            private set { result = value; }
        }
        /// <summary>
        /// Creates a instance of Command
        /// </summary>
        /// <param name="command">The text representation of command</param>
        /// <param name="uri">The Uri where the resolce os located</param>
        public Command(String command, Uri uri)
        {
            Uri = uri;
            CommandText = command;
        }

        /// <summary>
        /// Executes the command
        /// </summary>
        public void Execute()
        {
            HttpClient cli = new HttpClient();
            HttpGet get = new HttpGet(Uri);
            HttpResponse resp = cli.Execute(get);
        }
    }
}