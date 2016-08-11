using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bogatinovski_Player
{

    abstract class LyricsSearcher
    {
        static string defaultUrl = "https://www.google.com/search?q=";

        protected WebBrowser browser;
        protected Player player;
        protected List<String> lyricsPages;

        public LyricsSearcher(WebBrowser browser, Player player)
        {
            this.player = player;
            this.browser = browser;
            initializeLyricsPages();
        }

        public virtual void SearchForLyrics()
        {
            if (!player.getForm().lyricsOn || player.getCurrentSong()==null)
                return;
            browser.Stop();
            string url = defaultUrl + player.getCurrentSong().getName().Replace(".mp3", " ") + "lyrics";
            this.browser = player.getForm().browser;
            browser.Navigate(url);
        }

        protected void initializeLyricsPages()
        {
            lyricsPages = new List<string>();
            lyricsPages.AddRange(new string[]{"azlyrics.com", "lyrics.com", "lyricsfreak.com", "lyricstime.com", "metrolyrics.com",
            "lyricsmode.com", "rapgenius.com", "songmeanings.com", "www.sing365.com", "tekstovi-pesama.com", "lyricstime.com", 
            "lyricstranslations.com", "tekstovi.net", "www.tekstovipjesamalyrics.com", "justsomelyrics.com"});
        }

        public void setBrowser(WebBrowser browser)
        {
            this.browser = browser;
        }

        protected abstract bool isValidUrl(String url);
    }
}
