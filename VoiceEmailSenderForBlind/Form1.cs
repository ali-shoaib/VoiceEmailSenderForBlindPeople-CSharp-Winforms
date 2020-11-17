using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Speech.Recognition;
using System.IO;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;
using XanderUI;

namespace VoiceEmailSenderForBlind
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();
        
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            VoiceRecognition();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this will minimize the app.
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        public void VoiceRecognition()
        {
            StartListen.Enabled = false;
            StopListen.Enabled = true;
            clist.Add(new string[] { "send","deliver","nothing", "stop",
                "save", "sender","reciever", "password","exit","testing","remove",
                "gmail","hotmail", "yahoo"});
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
        public void MailSending()
        {
            try
            {
                MailMessage mail = new MailMessage(from.Text, to.Text, sub.Text, body.Text);
                SmtpClient client = new SmtpClient(smtp.Text);
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential(from.Text, pass.Text);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Email sent", "Success", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void sre_speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit word in e.Result.Words)
            {

                if (word.Text == "sender")
                {
                    from.Text += "vgotelv8@gmail.com";
                }

                else if (word.Text == "reciever")
                {
                    to.Text += "m.a.s.guy15@gmail.com";
                }

                else if (word.Text == "testing")
                {
                    sub.Text += e.Result.Text.ToString();
                }

                else if(word.Text == "gmail")
                {
                    smtp.Text += "smtp.gmail.com";
                }

                else if (word.Text == "hotmail")
                {
                    smtp.Text += "smtp.outlook.com";
                }

                else if (word.Text == "yahoo")
                {
                    smtp.Text += "smtp.yahoo.com";
                }

                else if (word.Text == "password")
                {
                    pass.Text += "minisowiredheadphones";
                }

                else if (word.Text == "nothing")
                {
                    body.Text += e.Result.Text.ToString();
                }

                //this line of code will empty all the fields.
                else if (word.Text == "remove")
                {
                    from.Text = "";
                    to.Text = "";
                    sub.Text = "";
                    smtp.Text = "";
                    pass.Text = "";
                    body.Text = "";
                }

                //Voice recognition system will stop.
                else if (word.Text == "stop")
                {
                    sre.RecognizeAsyncStop();
                    StartListen.Enabled = true;
                    StopListen.Enabled = false;
                    MessageBox.Show("Listening Stopped.", "Confirmation", MessageBoxButtons.OK);
                }

                //this will close the application.
                else if (word.Text == "exit")
                {
                    button6_Click(sender, e);
                }

                //through this email will be delivered. 
                else if (word.Text == "deliver")
                {
                    MailSending();
                }
            }
        }

        private void from_TextChanged(object sender, EventArgs e)
        {
        }

        private void to_TextChanged(object sender, EventArgs e)
        {
        }

        private void sub_TextChanged(object sender, EventArgs e)
        {
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
        }

        private void body_TextChanged(object sender, EventArgs e)
        {
        }
        private void xuiCheckBox1_Click(object sender, EventArgs e)
        {
            //coding for whether to show password or not.
            bool check = xuiCheckBox1.Checked;
            switch (check)
            {
                case true:
                    pass.UseSystemPasswordChar = true;
                    break;
                default:
                    pass.UseSystemPasswordChar = false;
                    break;
            }
        }

        private void StartListen_Click(object sender, EventArgs e)
        {
            VoiceRecognition();
        }

        private void StopListen_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsyncStop();
            StartListen.Enabled = true;
            StopListen.Enabled = false;
        }

        private void SendEmail_Click(object sender, EventArgs e)
        {
            MailSending();
        }
    }
}
