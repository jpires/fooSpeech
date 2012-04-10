using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Speech.Recognition;
using fooSpeech.Commands;

namespace fooSpeech
{
    class ASREngine
    {
        private SpeechRecognitionEngine sr;
        /// <summary>
        /// Creates a ASREngine.
        /// </summary>
        public ASREngine()
        {
            sr = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("pt-PT"));
            sr.SetInputToDefaultAudioDevice();
            sr.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(SpeechRecognized);
        }

        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Command command = CommandFactory.Contruct(e.Result.Text);
            if(command != null)
                command.Execute();                
            //TODO: Do something about the null reference. Maybe loggin.
        }

        /// <summary>
        /// Register a command in this engine.
        /// </summary>
        /// <param name="command">The command to register</param>
        public void Register(Command command)
        {
            GrammarBuilder gb2 = new GrammarBuilder(command.CommandText);
            gb2.Culture = sr.RecognizerInfo.Culture;
            sr.LoadGrammar(new Grammar(gb2));
        }

        /// <summary>
        /// Begins the recognition.
        /// </summary>
        public void Begin()
        {
            sr.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}