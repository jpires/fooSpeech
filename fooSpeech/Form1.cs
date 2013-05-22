using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CodeScales.Http;
using CodeScales.Http.Entity;
using CodeScales.Http.Methods;
using Microsoft.Speech.Recognition;
using fooSpeech.Commands;

namespace fooSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ASREngine asr = new ASREngine();
            asr.Register(new Play());
            asr.Register(new Stop());
            asr.Register(new VolumeDown());
            asr.Register(new VolumeUp());
            asr.Register(new NextMusic());
            asr.Register(new PreviousMusic());
            asr.Register(new Pause());
            asr.Register(new Continue());
            asr.Begin();
        }
    }
}
