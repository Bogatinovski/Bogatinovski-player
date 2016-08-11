using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Bogatinovski_Player
{
    class StupidLyricsSearcher : LyricsSearcher
    {
        private Timer timer;

        public StupidLyricsSearcher(WebBrowser browser, Player player)
            : base(browser, player)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_tick);
        }


        private void fetchGoogleResults()
        {
            try
            {
                System.Windows.Forms.HtmlDocument document = browser.Document;
                HtmlElementCollection lis = document.GetElementById("rso").Children;
                foreach (HtmlElement li in lis)
                {
                    HtmlElement a = li.FirstChild.GetElementsByTagName("h3")[0].FirstChild;
                    if (isValidUrl(a.GetAttribute("href")))
                    {
                        browser.Navigate(a.GetAttribute("href"));
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                
                     MessageBox.Show(ex.Message);
                
                   
            }
            
        }

        public override void SearchForLyrics()
        {
            if (!player.getForm().lyricsOn || player.getCurrentSong() == null)
                return;
            base.SearchForLyrics();
         
            timer.Start();
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            fetchGoogleResults();
            timer.Stop();
        }

        protected override bool isValidUrl(string url)
        {
            foreach (String link in lyricsPages)
                if (url.ToLower().Contains(link))
                    return true;

            if (url.Contains("youtube.com"))
                return false;
            return false;
        }
    }
}
