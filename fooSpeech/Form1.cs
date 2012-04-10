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
            asr.Begin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient cli = new HttpClient();
            HttpGet get = new HttpGet(new Uri("http://localhost:8888/ajquery/?cmd=Start&param1="));
            HttpResponse resp = cli.Execute(get);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HttpClient cli = new HttpClient();
            HttpGet get = new HttpGet(new Uri("http://localhost:8888/ajquery/?cmd=SearchMediaLibrary&param1=massive&param3=NoResponse"));
            //HttpGet get = new HttpGet(new Uri("http://www.google.com"));
            HttpResponse resp = cli.Execute(get);
            get = new HttpGet(new Uri("http://localhost:8888/ajquery/?cmd=SwitchPlaylist&&param1=5&param3=NoResponse"));
            resp = cli.Execute(get);

            get = new HttpGet(new Uri("http://localhost:8888/ajquery/?cmd=Start&param1=0&param3=NoResponse"));
            resp = cli.Execute(get);


            MessageBox.Show(resp.ResponseCode.ToString());
            MessageBox.Show(EntityUtils.ToString(resp.Entity));
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
