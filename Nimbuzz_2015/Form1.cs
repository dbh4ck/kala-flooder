using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using agsXMPP;
using agsXMPP.protocol.client;
using agsXMPP.protocol.x.muc;
using agsXMPP.Xml.Dom;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.IO;
using Nimbuzz_2015.Properties;

namespace Nimbuzz_2015
{
    public partial class Form1 : Form
    {
        public string[] a;
        private XmppClientConnection db1;
        private XmppClientConnection db2;
        private XmppClientConnection db3;
        private XmppClientConnection db4;
        private XmppClientConnection db5;
        private XmppClientConnection db6;
        private XmppClientConnection db7;
        private XmppClientConnection db8;

        private Random random = new Random();



        public Form1()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //1st id conn
            XmppClientConnection dbcon1 = new XmppClientConnection();
            dbcon1.Server += "nimbuzz.com";
            dbcon1.ConnectServer += "o.nimbuzz.com";
            dbcon1.Port = 5222;
            this.db1 = dbcon1;
            this.db1.Open(this.textBox1.Text, this.textBox9.Text, "Nimbuzz_Symbian" + (object)this.random.Next(100, 999));
            this.db1.Status += "online";
            this.db1.OnLogin += new ObjectHandler(this.login1);
            this.db1.OnAuthError += new XmppElementHandler(this.failed1);
            this.db1.OnClose += new ObjectHandler(this.dc1);
            //dbcon1.OnReadXml += new XmlHandler(Xml1);
            this.db1.OnMessage += new MessageHandler(this.OnMessage1);
            this.db1.OnPresence += new agsXMPP.protocol.client.PresenceHandler(this.OnPresence1);
            Random random = new Random();

            //2nd Connection

            XmppClientConnection dbcon2 = new XmppClientConnection();
            dbcon2.Server += "nimbuzz.com";
            dbcon2.ConnectServer += "o.nimbuzz.com";
            dbcon2.Port = 5222;
            this.db2 = dbcon2;
            this.db2.Open(this.textBox2.Text, this.textBox9.Text, "Nimbuzz_Symbian" + (object)this.random.Next(100, 999));
            this.db2.Status += "online";
            this.db2.OnLogin += new ObjectHandler(this.login2);
            this.db2.OnAuthError += new XmppElementHandler(this.failed2);
            this.db2.OnClose += new ObjectHandler(this.dc2);
            //dbcon2.OnReadXml += new XmlHandler(Xml2);
            this.db2.OnMessage += new MessageHandler(this.OnMessage2);
            this.db2.OnPresence += new agsXMPP.protocol.client.PresenceHandler(this.OnPresence2);


            //3rd Connection
            
            XmppClientConnection dbcon3 = new XmppClientConnection();
            dbcon3.Server += "nimbuzz.com";
            dbcon3.ConnectServer += "o.nimbuzz.com";
            dbcon3.Port = 5222;
            this.db3 = dbcon3;
            this.db3.Open(this.textBox3.Text, this.textBox9.Text, "Nimbuzz_Symbian" + (object)this.random.Next(100, 999));
            this.db3.Status += "online";
            this.db3.OnLogin += new ObjectHandler(this.login3);
            this.db3.OnAuthError += new XmppElementHandler(this.failed3);
            this.db3.OnClose += new ObjectHandler(this.dc3);
            //dbcon3.OnReadXml += new XmlHandler(Xml3);
            this.db3.OnMessage += new MessageHandler(this.OnMessage3);
            this.db3.OnPresence += new agsXMPP.protocol.client.PresenceHandler(this.OnPresence3);

            // 4th Connection

            XmppClientConnection dbcon4 = new XmppClientConnection();
            dbcon4.Server += "nimbuzz.com";
            dbcon4.ConnectServer += "o.nimbuzz.com";
            dbcon4.Port = 5222;
            this.db4 = dbcon4;
            this.db4.Open(this.textBox4.Text, this.textBox9.Text, "Nimbuzz_Symbian" + (object)this.random.Next(100, 999));
            this.db4.Status += "online";
            this.db4.OnLogin += new ObjectHandler(this.login4);
            this.db4.OnAuthError += new XmppElementHandler(this.failed4);
            this.db4.OnClose += new ObjectHandler(this.dc4);
            //dbcon4.OnReadXml += new XmlHandler(Xml4);
            this.db4.OnMessage += new MessageHandler(this.OnMessage4);
            this.db4.OnPresence += new agsXMPP.protocol.client.PresenceHandler(this.OnPresence4);

            // 5th Connection

            XmppClientConnection dbcon5 = new XmppClientConnection();
            dbcon5.Server += "nimbuzz.com";
            dbcon5.ConnectServer += "o.nimbuzz.com";
            dbcon5.Port = 5222;
            this.db5 = dbcon5;
            this.db5.Open(this.textBox5.Text, this.textBox9.Text, "Nimbuzz_Symbian" + (object)this.random.Next(100, 999));
            this.db5.Status += "online";
            this.db5.OnLogin += new ObjectHandler(this.login5);
            this.db5.OnAuthError += new XmppElementHandler(this.failed5);
            this.db5.OnClose += new ObjectHandler(this.dc5);
            //dbcon5.OnReadXml += new XmlHandler(Xml5);
            this.db5.OnMessage += new MessageHandler(this.OnMessage5);
            this.db5.OnPresence += new agsXMPP.protocol.client.PresenceHandler(this.OnPresence5);

            // 6th Connection

            XmppClientConnection dbcon6 = new XmppClientConnection();
            dbcon6.Server += "nimbuzz.com";
            dbcon6.ConnectServer += "o.nimbuzz.com";
            dbcon6.Port = 5222;
            this.db6 = dbcon6;
            this.db6.Open(this.textBox6.Text, this.textBox9.Text, "Nimbuzz_Symbian" + (object)this.random.Next(100, 999));
            this.db6.Status += "online";
            this.db6.OnLogin += new ObjectHandler(this.login6);
            this.db6.OnAuthError += new XmppElementHandler(this.failed6);
            this.db6.OnClose += new ObjectHandler(this.dc6);
            //dbcon6.OnReadXml += new XmlHandler(Xml6);
            this.db6.OnMessage += new MessageHandler(this.OnMessage6);
            this.db6.OnPresence += new agsXMPP.protocol.client.PresenceHandler(this.OnPresence6);

            // 7th Connection

            XmppClientConnection dbcon7 = new XmppClientConnection();
            dbcon7.Server += "nimbuzz.com";
            dbcon7.ConnectServer += "o.nimbuzz.com";
            dbcon7.Port = 5222;
            this.db7 = dbcon7;
            this.db7.Open(this.textBox7.Text, this.textBox9.Text, "Nimbuzz_Symbian" + (object)this.random.Next(100, 999));
            this.db7.Status += "online";
            this.db7.OnLogin += new ObjectHandler(this.login7);
            this.db7.OnAuthError += new XmppElementHandler(this.failed7);
            this.db7.OnClose += new ObjectHandler(this.dc7);
            //dbcon7.OnReadXml += new XmlHandler(Xml7);
            this.db7.OnMessage += new MessageHandler(this.OnMessage7);
            this.db7.OnPresence += new agsXMPP.protocol.client.PresenceHandler(this.OnPresence7);


            // 8th Connection

            XmppClientConnection dbcon8 = new XmppClientConnection();
            dbcon8.Server += "nimbuzz.com";
            dbcon8.ConnectServer += "o.nimbuzz.com";
            dbcon8.Port = 5222;
            this.db8 = dbcon8;
            this.db8.Open(this.textBox8.Text, this.textBox9.Text, "Nimbuzz_Symbian" + (object)this.random.Next(100, 999));
            this.db8.Status += "online";
            this.db8.OnLogin += new ObjectHandler(this.login8);
            this.db8.OnAuthError += new XmppElementHandler(this.failed8);
            this.db8.OnClose += new ObjectHandler(this.dc8);
            //dbcon8.OnReadXml += new XmlHandler(Xml8);
            this.db8.OnMessage += new MessageHandler(this.OnMessage8);
            this.db8.OnPresence += new agsXMPP.protocol.client.PresenceHandler(this.OnPresence8);


        }



        private void button2_Click(object sender, EventArgs e)
        {
            string[] strArray = this.richTextBox1.Text.Split('#');

            this.textBox1.Text = strArray[0];
            this.textBox2.Text = strArray[1];
            this.textBox3.Text = strArray[2];
            this.textBox4.Text = strArray[3];
            this.textBox5.Text = strArray[4];
            this.textBox6.Text = strArray[5];
            this.textBox7.Text = strArray[6];
            this.textBox8.Text = strArray[7];

            this.richTextBox1.Text = (string)null;
            for (int index = 8; index <= strArray.GetUpperBound(0); ++index)
                this.richTextBox1.Text = this.richTextBox1.Text + strArray[index] + "#";
        
        }


        //1st CONN DETAILS

        private void login1(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.login1), sender);
            else
                this.textBox1.BackColor = Color.Green;
        }

        
        private void failed1(object sender, Element e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new XmppElementHandler(this.failed1), sender, (object)e);
            else
                this.textBox1.BackColor = Color.Red;
        }

        private void dc1(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.dc1), sender);
            else
                this.textBox1.BackColor = Color.Yellow;
        }

        private void OnMessage1(object sender, agsXMPP.protocol.client.Message msg)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new MessageHandler(this.OnMessage1), sender, (object)msg);
            else if (msg.Type == MessageType.groupchat && msg.From.Resource == "admin")
                this.pictureBox1.Load(msg.Body.Replace("Enter the right answer to start chatting. ", ""));

        }

        void OnPresence1(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(OnPresence1), new object[] { sender, pres });
                return;
            }

            if (pres.From.Server.StartsWith("conference"))
            {
                if (pres.MucUser != null)
                {
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                    {
                        listBox1.Items.Add(pres.From.Resource);
                    }

                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                    {
                        listBox1.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                    {
                        listBox1.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                    {
                        listBox1.Items.Add(pres.From.Resource);
                    }

                    if (pres.Type == PresenceType.unavailable)
                    {
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                        {
                            listBox1.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                        {
                            listBox1.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                        {
                            listBox1.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                        {
                            listBox1.Items.Remove(pres.From.Resource);
                        }
                    }
                }

            }

        }







        //2nd CONN DETAILS

        private void login2(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.login2), sender);
            else
                this.textBox2.BackColor = Color.Green;
        }


        private void failed2(object sender, Element e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new XmppElementHandler(this.failed2), sender, (object)e);
            else
                this.textBox2.BackColor = Color.Red;
        }

        private void dc2(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.dc2), sender);
            else
                this.textBox2.BackColor = Color.Yellow;
        }

        private void OnMessage2(object sender, agsXMPP.protocol.client.Message msg)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new MessageHandler(this.OnMessage2), sender, (object)msg);
            else if (msg.Type == MessageType.groupchat && msg.From.Resource == "admin")
                this.pictureBox2.Load(msg.Body.Replace("Enter the right answer to start chatting. ", ""));

        }

        void OnPresence2(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(OnPresence2), new object[] { sender, pres });
                return;
            }

            if (pres.From.Server.StartsWith("conference"))
            {
                if (pres.MucUser != null)
                {
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                    {
                        listBox2.Items.Add(pres.From.Resource);
                    }

                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                    {
                        listBox2.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                    {
                        listBox2.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                    {
                        listBox2.Items.Add(pres.From.Resource);
                    }

                    if (pres.Type == PresenceType.unavailable)
                    {
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                        {
                            listBox2.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                        {
                            listBox2.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                        {
                            listBox2.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                        {
                            listBox2.Items.Remove(pres.From.Resource);
                        }
                    }
                }

            }

        }







        //3rd CONN DETAILS

        private void login3(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.login3), sender);
            else
                this.textBox3.BackColor = Color.Green;
        }


        private void failed3(object sender, Element e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new XmppElementHandler(this.failed3), sender, (object)e);
            else
                this.textBox3.BackColor = Color.Red;
        }

        private void dc3(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.dc3), sender);
            else
                this.textBox3.BackColor = Color.Yellow;
        }

        private void OnMessage3(object sender, agsXMPP.protocol.client.Message msg)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new MessageHandler(this.OnMessage3), sender, (object)msg);
            else if (msg.Type == MessageType.groupchat && msg.From.Resource == "admin")
                this.pictureBox3.Load(msg.Body.Replace("Enter the right answer to start chatting. ", ""));

        }

        void OnPresence3(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(OnPresence3), new object[] { sender, pres });
                return;
            }



            if (pres.From.Server.StartsWith("conference"))
            {
                if (pres.MucUser != null)
                {
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                    {
                        listBox3.Items.Add(pres.From.Resource);
                    }

                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                    {
                        listBox3.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                    {
                        listBox3.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                    {
                        listBox3.Items.Add(pres.From.Resource);
                    }

                    if (pres.Type == PresenceType.unavailable)
                    {
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                        {
                            listBox3.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                        {
                            listBox3.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                        {
                            listBox3.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                        {
                            listBox3.Items.Remove(pres.From.Resource);
                        }
                    }
                }

            }

        }



        //4th CONN DETAILS

        private void login4(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.login4), sender);
            else
                this.textBox4.BackColor = Color.Green;
        }


        private void failed4(object sender, Element e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new XmppElementHandler(this.failed4), sender, (object)e);
            else
                this.textBox4.BackColor = Color.Red;
        }

        private void dc4(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.dc4), sender);
            else
                this.textBox4.BackColor = Color.Yellow;
        }

        private void OnMessage4(object sender, agsXMPP.protocol.client.Message msg)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new MessageHandler(this.OnMessage4), sender, (object)msg);
            else if (msg.Type == MessageType.groupchat && msg.From.Resource == "admin")
                this.pictureBox4.Load(msg.Body.Replace("Enter the right answer to start chatting. ", ""));

        }

        void OnPresence4(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(OnPresence4), new object[] { sender, pres });
                return;
            }

            if (pres.From.Server.StartsWith("conference"))
            {
                if (pres.MucUser != null)
                {
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                    {
                        listBox4.Items.Add(pres.From.Resource);
                    }

                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                    {
                        listBox4.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                    {
                        listBox4.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                    {
                        listBox4.Items.Add(pres.From.Resource);
                    }

                    if (pres.Type == PresenceType.unavailable)
                    {
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                        {
                            listBox4.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                        {
                            listBox4.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                        {
                            listBox4.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                        {
                            listBox4.Items.Remove(pres.From.Resource);
                        }
                    }
                }

            }

        }



        //5th CONN DETAILS

        private void login5(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.login5), sender);
            else
                this.textBox5.BackColor = Color.Green;
        }


        private void failed5(object sender, Element e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new XmppElementHandler(this.failed5), sender, (object)e);
            else
                this.textBox5.BackColor = Color.Red;
        }

        private void dc5(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.dc5), sender);
            else
                this.textBox5.BackColor = Color.Yellow;
        }

        private void OnMessage5(object sender, agsXMPP.protocol.client.Message msg)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new MessageHandler(this.OnMessage5), sender, (object)msg);
            else if (msg.Type == MessageType.groupchat && msg.From.Resource == "admin")
                this.pictureBox5.Load(msg.Body.Replace("Enter the right answer to start chatting. ", ""));

        }

        void OnPresence5(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(OnPresence5), new object[] { sender, pres });
                return;
            }

            if (pres.From.Server.StartsWith("conference"))
            {
                if (pres.MucUser != null)
                {
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                    {
                        listBox5.Items.Add(pres.From.Resource);
                    }

                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                    {
                        listBox5.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                    {
                        listBox5.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                    {
                        listBox5.Items.Add(pres.From.Resource);
                    }

                    if (pres.Type == PresenceType.unavailable)
                    {
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                        {
                            listBox5.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                        {
                            listBox5.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                        {
                            listBox5.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                        {
                            listBox5.Items.Remove(pres.From.Resource);
                        }
                    }
                }

            }

        }



        //6th CONN DETAILS

        private void login6(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.login6), sender);
            else
                this.textBox6.BackColor = Color.Green;
        }


        private void failed6(object sender, Element e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new XmppElementHandler(this.failed6), sender, (object)e);
            else
                this.textBox6.BackColor = Color.Red;
        }

        private void dc6(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.dc6), sender);
            else
                this.textBox6.BackColor = Color.Yellow;
        }

        private void OnMessage6(object sender, agsXMPP.protocol.client.Message msg)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new MessageHandler(this.OnMessage6), sender, (object)msg);
            else if (msg.Type == MessageType.groupchat && msg.From.Resource == "admin")
                this.pictureBox6.Load(msg.Body.Replace("Enter the right answer to start chatting. ", ""));

        }

        void OnPresence6(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(OnPresence6), new object[] { sender, pres });
                return;
            }

            if (pres.From.Server.StartsWith("conference"))
            {
                if (pres.MucUser != null)
                {
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                    {
                        listBox6.Items.Add(pres.From.Resource);
                    }

                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                    {
                        listBox6.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                    {
                        listBox6.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                    {
                        listBox6.Items.Add(pres.From.Resource);
                    }

                    if (pres.Type == PresenceType.unavailable)
                    {
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                        {
                            listBox6.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                        {
                            listBox6.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                        {
                            listBox6.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                        {
                            listBox6.Items.Remove(pres.From.Resource);
                        }
                    }
                }

            }

        }





        //7th CONN DETAILS

        private void login7(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.login7), sender);
            else
                this.textBox7.BackColor = Color.Green;
        }


        private void failed7(object sender, Element e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new XmppElementHandler(this.failed7), sender, (object)e);
            else
                this.textBox7.BackColor = Color.Red;
        }

        private void dc7(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.dc7), sender);
            else
                this.textBox7.BackColor = Color.Yellow;
        }

        private void OnMessage7(object sender, agsXMPP.protocol.client.Message msg)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new MessageHandler(this.OnMessage7), sender, (object)msg);
            else if (msg.Type == MessageType.groupchat && msg.From.Resource == "admin")
                this.pictureBox7.Load(msg.Body.Replace("Enter the right answer to start chatting. ", ""));

        }

        void OnPresence7(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(OnPresence7), new object[] { sender, pres });
                return;
            }

            if (pres.From.Server.StartsWith("conference"))
            {
                if (pres.MucUser != null)
                {
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                    {
                        listBox7.Items.Add(pres.From.Resource);
                    }

                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                    {
                        listBox7.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                    {
                        listBox7.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                    {
                        listBox7.Items.Add(pres.From.Resource);
                    }

                    if (pres.Type == PresenceType.unavailable)
                    {
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                        {
                            listBox7.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                        {
                            listBox7.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                        {
                            listBox7.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                        {
                            listBox7.Items.Remove(pres.From.Resource);
                        }
                    }
                }

            }

        }



        //8th CONN DETAILS

        private void login8(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.login8), sender);
            else
                this.textBox8.BackColor = Color.Green;
        }


        private void failed8(object sender, Element e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new XmppElementHandler(this.failed8), sender, (object)e);
            else
                this.textBox8.BackColor = Color.Red;
        }

        private void dc8(object sender)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new ObjectHandler(this.dc8), sender);
            else
                this.textBox8.BackColor = Color.Yellow;
        }

        private void OnMessage8(object sender, agsXMPP.protocol.client.Message msg)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Delegate)new MessageHandler(this.OnMessage8), sender, (object)msg);
            else if (msg.Type == MessageType.groupchat && msg.From.Resource == "admin")
                this.pictureBox8.Load(msg.Body.Replace("Enter the right answer to start chatting. ", ""));

        }


        void OnPresence8(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(OnPresence8), new object[] { sender, pres });
                return;
            }

            if (pres.From.Server.StartsWith("conference"))
            {
                if (pres.MucUser != null)
                {
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                    {
                        listBox8.Items.Add(pres.From.Resource);
                    }

                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                    {
                        listBox8.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                    {
                        listBox8.Items.Add(pres.From.Resource);
                    }
                    if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                    {
                        listBox8.Items.Add(pres.From.Resource);
                    }

                    if (pres.Type == PresenceType.unavailable)
                    {
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.owner)
                        {
                            listBox8.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.admin)
                        {
                            listBox8.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.member)
                        {
                            listBox8.Items.Remove(pres.From.Resource);
                        }
                        if (pres.MucUser.Item.Affiliation == agsXMPP.protocol.x.muc.Affiliation.none)
                        {
                            listBox8.Items.Remove(pres.From.Resource);
                        }
                    }
                }

            }

        }


       

        
        private void button5_Click(object sender, EventArgs e)
        {
            this.db1.Send("<presence to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox1.Text + "'></presence>");
            this.db2.Send("<presence to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox2.Text + "'></presence>");
            this.db3.Send("<presence to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox3.Text + "'></presence>");
            this.db4.Send("<presence to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox4.Text + "'></presence>");
            this.db5.Send("<presence to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox5.Text + "'></presence>");
            this.db6.Send("<presence to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox6.Text + "'></presence>");
            this.db7.Send("<presence to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox7.Text + "'></presence>");
            this.db8.Send("<presence to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox8.Text + "'></presence>");
        }


        private void button23_Click(object sender, EventArgs e)
        {
            this.db1.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox1.Text + "'></presence>");
            this.db2.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox2.Text + "'></presence>");
            this.db3.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox3.Text + "'></presence>");
            this.db4.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox4.Text + "'></presence>");
            this.db5.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox5.Text + "'></presence>");
            this.db6.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox6.Text + "'></presence>");
            this.db7.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox7.Text + "'></presence>");
            this.db8.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox8.Text + "'></presence>");

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
        }

       


        private void button4_Click(object sender, EventArgs e)
        {
            this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.textBox10.Text + "</body></message>'");

            for (int index = 1; index <= 2; ++index)
            {
                this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
                this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
                this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
                this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
                this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox6.Text + "</body></message>'");
                this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox7.Text + "</body></message>'");
                this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
                this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
                this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
                this.db1.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
            }
                this.db1.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox1.Text + "'></presence>");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < this.listBox1.Items.Count; a++)
            this.db1.Send("<message xmlns='jabber:client' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.listBox1.Items[a].ToString() + "'  type='chat' id=''><body>" + this.richTextBox2.Text + "</body><active xmlns='http://jabber.org/protocol/chatstates' /><x xmlns='jabber:x:event'><composing /></x></message>");
                                   
        }

       private void textBox10_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4_Click(sender, e);
                this.textBox10.Clear();
                this.textBox11.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                button14_Click(sender, e);
            }
                        
        }

       private void button6_Click(object sender, EventArgs e)
       {
           this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.textBox11.Text + "</body></message>'");
            for (int index = 1; index <= 2; ++index)
             {
               this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
               this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
               this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
               this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
               this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox6.Text + "</body></message>'");
               this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox7.Text + "</body></message>'");
               this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
               this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
               this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
               this.db2.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
             }
           this.db2.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox2.Text + "'></presence>");

       }

       private void button15_Click(object sender, EventArgs e)
       {
           for (int a = 0; a < this.listBox2.Items.Count; a++)
               this.db2.Send("<message xmlns='jabber:client' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.listBox2.Items[a].ToString() + "'  type='chat' id=''><body>" + this.richTextBox3.Text + "</body><active xmlns='http://jabber.org/protocol/chatstates' /><x xmlns='jabber:x:event'><composing /></x></message>");
       }
      
       private void textBox11_KeyDown(object sender, KeyEventArgs e)
       {

           if (e.KeyCode == Keys.Enter)
           {
               button6_Click(sender, e);
               this.textBox11.Clear();
               this.textBox12.Focus();
           }
           if (e.KeyCode == Keys.Enter)
           {
               button15_Click(sender, e);
              

           }
       }



       private void button7_Click(object sender, EventArgs e)
       {
           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.textBox12.Text + "</body></message>'");

           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox6.Text + "</body></message>'");
           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox7.Text + "</body></message>'");
           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db3.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
           this.db3.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox3.Text + "'></presence>");
       
       }

       private void button16_Click(object sender, EventArgs e)
       {
           for (int a = 0; a < this.listBox3.Items.Count; a++)
               this.db3.Send("<message xmlns='jabber:client' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.listBox3.Items[a].ToString() + "'  type='chat' id=''><body>" + this.richTextBox4.Text + "</body><active xmlns='http://jabber.org/protocol/chatstates' /><x xmlns='jabber:x:event'><composing /></x></message>");
       
       }


       private void textBox12_KeyDown_1(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               button7_Click(sender, e);
               this.textBox12.Clear();
               this.textBox13.Focus();
           }
           if (e.KeyCode == Keys.Enter)
           {
               button16_Click(sender, e);
           }
       }

       private void button8_Click(object sender, EventArgs e)
       {
           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.textBox13.Text + "</body></message>'");

           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox6.Text + "</body></message>'");
           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox7.Text + "</body></message>'");
           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db4.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");

           this.db4.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox4.Text + "'></presence>");
       
       }

       private void button17_Click(object sender, EventArgs e)
       {
           for (int a = 0; a < this.listBox4.Items.Count; a++)
               this.db4.Send("<message xmlns='jabber:client' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.listBox4.Items[a].ToString() + "'  type='chat' id=''><body>" + this.richTextBox5.Text + "</body><active xmlns='http://jabber.org/protocol/chatstates' /><x xmlns='jabber:x:event'><composing /></x></message>");
       }

       private void textBox13_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               button8_Click(sender, e);
               this.textBox13.Clear();
               this.textBox14.Focus();
           }
           if (e.KeyCode == Keys.Enter)
           {
               button17_Click(sender, e);
           }
       }



       private void button9_Click(object sender, EventArgs e)
       {
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.textBox14.Text + "</body></message>'");
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox6.Text + "</body></message>'");
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox7.Text + "</body></message>'");
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db5.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");

           this.db5.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox5.Text + "'></presence>");
       }

       private void button18_Click(object sender, EventArgs e)
       {
           for (int a = 0; a < this.listBox5.Items.Count; a++)
               this.db5.Send("<message xmlns='jabber:client' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.listBox5.Items[a].ToString() + "'  type='chat' id=''><body>" + this.richTextBox6.Text + "</body><active xmlns='http://jabber.org/protocol/chatstates' /><x xmlns='jabber:x:event'><composing /></x></message>");
       }

       private void textBox14_KeyDown_1(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               button9_Click(sender, e);
               this.textBox14.Clear();
               this.textBox15.Focus();
           }
           if (e.KeyCode == Keys.Enter)
           {
               button18_Click(sender, e);
           }
       }

       private void button10_Click(object sender, EventArgs e)
       {
           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.textBox15.Text + "</body></message>'");

           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox6.Text + "</body></message>'");
           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox7.Text + "</body></message>'");
           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
           this.db6.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox6.Text + "</body></message>'");
           this.db6.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox6.Text + "'></presence>");
       
       }


       private void button19_Click(object sender, EventArgs e)
       {
           for (int a = 0; a < this.listBox6.Items.Count; a++)
               this.db6.Send("<message xmlns='jabber:client' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.listBox6.Items[a].ToString() + "'  type='chat' id=''><body>" + this.richTextBox7.Text + "</body><active xmlns='http://jabber.org/protocol/chatstates' /><x xmlns='jabber:x:event'><composing /></x></message>");
       }


       private void textBox15_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               button10_Click(sender, e);
               this.textBox15.Clear();
               this.textBox16.Focus();
           }
           if (e.KeyCode == Keys.Enter)
           {
               button19_Click(sender, e);
           }
       }

       private void button11_Click(object sender, EventArgs e)
       {
           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.textBox16.Text + "</body></message>'");

           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox6.Text + "</body></message>'");
           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox7.Text + "</body></message>'");
           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db7.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");

           this.db7.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox7.Text + "'></presence>");
       
       }

       private void button20_Click(object sender, EventArgs e)
       {
           for (int a = 0; a < this.listBox7.Items.Count; a++)
               this.db7.Send("<message xmlns='jabber:client' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.listBox7.Items[a].ToString() + "'  type='chat' id=''><body>" + this.richTextBox2.Text + "</body><active xmlns='http://jabber.org/protocol/chatstates' /><x xmlns='jabber:x:event'><composing /></x></message>");
       }


       private void textBox16_KeyDown_1(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               button11_Click(sender, e);
               this.textBox16.Clear();
               this.textBox17.Focus();
           }
           if (e.KeyCode == Keys.Enter)
           {
               button20_Click(sender, e);
           }
       }

       private void button12_Click(object sender, EventArgs e)
       {
           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.textBox17.Text + "</body></message>'");

           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");
           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox6.Text + "</body></message>'");
           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox7.Text + "</body></message>'");
           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox2.Text + "</body></message>'");
           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox3.Text + "</body></message>'");
           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox4.Text + "</body></message>'");
           this.db8.Send("<message to='" + this.textBox18.Text + "@conference.nimbuzz.com' type='groupchat'><body>" + this.richTextBox5.Text + "</body></message>'");

           this.db8.Send("<presence type='unavailable' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.textBox8.Text + "'></presence>");
       }

       private void button21_Click(object sender, EventArgs e)
       {
           for (int a = 0; a < this.listBox8.Items.Count; a++)
               this.db8.Send("<message xmlns='jabber:client' to='" + this.textBox18.Text + "@conference.nimbuzz.com/" + this.listBox8.Items[a].ToString() + "'  type='chat' id=''><body>" + this.richTextBox5.Text + "</body><active xmlns='http://jabber.org/protocol/chatstates' /><x xmlns='jabber:x:event'><composing /></x></message>");
       }


       private void textBox17_KeyDown_1(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               button12_Click(sender, e);
               this.textBox17.Clear();
           }
           if (e.KeyCode == Keys.Enter)
           {
               button21_Click(sender, e);
           }
       }

       private void textBox15_TextChanged(object sender, EventArgs e)
       {

       }

       private void button1_Click(object sender, EventArgs e)
       {
           Stream myStream;
           OpenFileDialog openFileDialog1 = new OpenFileDialog();

           if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           {
               if ((myStream = openFileDialog1.OpenFile()) != null)
               {
                   string strfilename = openFileDialog1.FileName;
                   string filetext = File.ReadAllText(strfilename);
                   richTextBox1.Text = filetext;
               }
           }
       }

       private void button13_Click(object sender, EventArgs e)
       {
           db1.Close();
           db2.Close();
           db3.Close();
           db4.Close();
           db5.Close();
           db6.Close();
           db7.Close();
           db8.Close();
           listBox1.Items.Clear();
           listBox2.Items.Clear();
           listBox3.Items.Clear();
           listBox4.Items.Clear();
           listBox5.Items.Clear();
           listBox6.Items.Clear();
           listBox7.Items.Clear();
           listBox8.Items.Clear();
       }

       private void groupBox1_Enter(object sender, EventArgs e)
       {

       }

       private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {
           linkLabel1.LinkVisited = true;
           System.Diagnostics.Process.Start("http://dbh4ck.blogspot.in");
       }

       private void Form1_Load(object sender, EventArgs e)
       {

       }

       private void textBox1_TextChanged(object sender, EventArgs e)
       {

       }

       

      

      

       
       
      
       

       

      
      

       

      

 
    }
}

// ##### CODED BY DB~@NC #####
// ##### OCT., 2015 #####