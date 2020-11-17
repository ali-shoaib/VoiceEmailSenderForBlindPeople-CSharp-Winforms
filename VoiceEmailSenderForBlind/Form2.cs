using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace VoiceEmailSenderForBlind
{
    public partial class Form2 : Form
    {
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();
        public Form2()
        {
            InitializeComponent();
            clist.Add(new string[] { "exit", "beginning" });
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

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        public void sre_speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit word in e.Result.Words)
            {
                if (word.Text == "exit")
                {
                    close_Click(sender, e);
                }

                else if(word.Text =="beginning")
                {
                    close_Click(sender, e);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsyncStop();
            this.Close();
            Form3 startup = new Form3();
            startup.ShowDialog();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
