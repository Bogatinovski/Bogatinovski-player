using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bogatinovski_Player
{
    class Song
    {
        private string path;
        private string name;
        public bool isPlaying = true;

        public Song(string path)
        {
            this.path = path;
            setName();
        }

        public Song(Song s)
        {
            this.path = s.path;
            this.name = s.name;
        }
        private void setName()
        {
            string[] a = path.Split('\\');
            name = a[a.Length - 1];
        }

        public String viewFilePath()
        {
            return this.path;
        }

        public void openFileLocation()
        {
            Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + path));
        }

        public String getName()
        {
            return this.name;
        }
        public String getPath()
        {
            return this.path;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
