using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;
using System.Speech.Recognition;

namespace VoiceEmailSenderForBlind
{
    public partial class Form3 : Form
    {
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();

        public Form3()
        {
            InitializeComponent();
            clist.Add(new string[] { "open mail", "document", "exit" });
            Grammar gr = new Grammar(new GrammarBuilder(clist));
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_speechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //this coding is for drop shadow effect.
        private const int drop_shadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = drop_shadow;
                return cp;
            }
        }
        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            Form1 es = new Form1();
            es.Show();
            sre.RecognizeAsyncStop();
            this.Hide();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Form2 rm = new Form2();
            rm.Show();
            sre.RecognizeAsyncStop();
            this.Hide();
        }

        public void sre_speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text.ToString())
            {
                case "open mail":
                    Form1 f1 = new Form1();
                    f1.Show();
                    sre.RecognizeAsyncStop();
                    this.Hide();
                    break;

                case "document":
                    Form2 f2 = new Form2();
                    f2.Show();
                    sre.RecognizeAsyncStop();
                    this.Hide();
                    break;

                case "exit":
                    Application.Exit();
                    break;
            }
        }
     }
 }
