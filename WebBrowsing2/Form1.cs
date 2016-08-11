using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;
using System.Media;
using System.Security.Permissions;
using System.IO;
using System.Text.RegularExpressions;

namespace Bogatinovski_Player
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Form1 : Form
    {
     
        string homePage = "http://bogatinovski.weebly.com/";
        string currentPage;
        bool busy = false;
        WebBrowser browser1 = new WebBrowser();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            InitializeBrowser();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            browser1.Size = new Size(this.Width, this.Height);
        }

        /// <summary>
        /// Mu pravi update na lyricsot vo zavisnot od toa dali e smeneta pesnata koja sto sviri
        /// </summary>
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Class1.newSong == true)
            {
                browser1.Navigate(Class1.site);
                currentPage = Class1.site;
                timer4.Enabled = true;
            }
        }

        /// <summary>
        /// Ovoj metod zabelezuva koda korisnikot ja napustil Form1 a pritoa ne e smeneta nova pesna za da znae da ne go 
        /// menja i lyricsot
        /// </summary>
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Class1.newSong = false;
        }

        /// <summary>
        /// Go loadira browserot, go nosi na homepage. Ovoj metod se povikuva samo ednas vo loadiranje na formata
        /// </summary>
        private void InitializeBrowser()
        {
            browser1.Location = new Point(5, 5);
            browser1.Size = this.Size;
            browser1.ScriptErrorsSuppressed = true;
            this.Controls.Add(browser1);
            browser1.SendToBack();
            browser1.Navigate(Class1.site);
            browser1.Navigated += new WebBrowserNavigatedEventHandler(browser1_navigate);
        }

        private void browser1_navigate(object sender, EventArgs e)
        {
            if (browser1.Url.ToString().Contains("youtube"))
                button5.Visible = true;
            else button5.Visible = false;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            currentPage = Class1.site;
            browser1.Navigate(homePage);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            browser1.Navigate(currentPage);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentPage = "http://www.youtube.com/";
            browser1.Navigate(currentPage);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Location.Y < 5)
            {
                busy = true;
                button1.Location = new Point(button1.Location.X, button1.Location.Y + 5);
                button2.Location = new Point(button2.Location.X, button2.Location.Y + 5);
                button3.Location = new Point(button3.Location.X, button3.Location.Y + 5);
                button4.Location = new Point(button4.Location.X, button4.Location.Y + 5);
                button5.Location = new Point(button5.Location.X, button5.Location.Y + 10);
            }
            else
            {
                timer1.Enabled = false;
                busy = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (button1.Location.Y > -40)
            {
                busy = true;
                button1.Location = new Point(button1.Location.X, button1.Location.Y - 5);
                button2.Location = new Point(button2.Location.X, button2.Location.Y - 5);
                button3.Location = new Point(button3.Location.X, button3.Location.Y - 5);
                button4.Location = new Point(button4.Location.X, button4.Location.Y - 5);
                button5.Location = new Point(button5.Location.X, button5.Location.Y - 10);
            }
            else
            {
                timer2.Enabled = false;
                busy = false;
            }
                
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.X < 30 && e.Y < 30)
            {
                if (button1.Location.Y < 0)
                {
                    if (!busy)
                        timer1.Enabled = true;
                }
                else
                {
                    if (!busy)
                        timer2.Enabled = true;
                }

            }

        }

        /// <summary>
        /// Gi mesti kopcinjata na svojata pocetna pozicija
        /// </summary>
        private void InitializeButtons()
        {
            button1.Location = new Point(button1.Location.X, -35);
            button2.Location = new Point(button2.Location.X, -35);
            button3.Location = new Point(button3.Location.X, -35);
            button4.Location = new Point(button4.Location.X, -35);
            button5.Location = new Point(button5.Location.X, -35);
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void OpenLyricsAutomatically()
        {
            HtmlElementCollection html = browser1.Document.GetElementsByTagName("a");

            string text = "";
            for (int i = 0; i < html.Count; i++)
            {
                text = html[i].GetAttribute("href");
                if (!text.ToLower().Contains("google") && !text.ToLower().Contains("youtube") &&
                    !text.ToLower().Contains("blogger") && !text.ToLower().Contains("advanced_search")
                    && !string.IsNullOrWhiteSpace(text))
                    break;
            }

            browser1.Navigate(text);
           
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            OpenLyricsAutomatically();
            timer4.Enabled = false;
        }

       
        /*private void button6_Click(object sender, EventArgs e)
        {
            string text = "";
            HtmlElementCollection content = browser1.Document.GetElementsByTagName("p");
            foreach (HtmlElement h in content)
                text += h.InnerText;

            File.WriteAllText(@"C:\Users\Dejan\Desktop\file.txt",text);
        }*/
    
  
    }
}
