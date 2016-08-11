using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bogatinovski_Player
{
    class SmartLyricsSearcher : LyricsSearcher
    {

        public SmartLyricsSearcher(WebBrowser browser, Player player)
            : base(browser, player)
        {

        }

        protected override bool isValidUrl(string url)
        {
            throw new NotImplementedException();
        }

    }
}
