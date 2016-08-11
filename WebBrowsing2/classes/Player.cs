using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AxWMPLib;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Security.Principal;
using Microsoft.Win32;

namespace Bogatinovski_Player
{
    enum MediaState
    {
        Repeat, Shuffle, Normal
    }

    class Player
    {
        private List<Playlist> playlists;
        private Playlist nowPlaying;
        private Playlist previewPlaylist;
        private Form2 form;
        private Song currentSong;
        private OpenFileDialog openFileDialog1;
        private String songDisplayName;
        private MediaStateHandler mediaStateHandler;
        private MediaState mediaState;
        private Timer volumeTimer;
        private Timer volumeTimer2;
        private int volumeValue;
        private LyricsSearcher lyricsSearcher;
        public static string playlistsFolder = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "Playlists\\");
        public static string playlistsTxt = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "Playlists.txt");
        public static string nowPlayingPath = playlistsFolder + "Now Playing.pl";
        public static string songsbookPath = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "Songsbook.sb");
       
        public Player(Form2 form, List<String> songs)
        {
            setForm(form);
            mediaStateHandler = new MediaStateHandler(this);
            playlists = new List<Playlist>();
            setMediaState(MediaState.Normal);
            setOpenFileDialog();
            addPlaylistsToTheList();
            initializeVolumeTimers();
            createSongsBook();
            SetCurrentEffectPreset(3);
            addInitialSongsToNowPlaying(songs);
            initializeLyricsSearcher();
        }

        public LyricsSearcher getLyricsSearcher()
        {
            return this.lyricsSearcher;
        }
        private void initializeLyricsSearcher()
        {
            lyricsSearcher = new StupidLyricsSearcher(form.browser, this);
        }

        private void initializeVolumeTimers()
        {
            volumeTimer = new Timer();
            volumeTimer.Interval = 10;
            volumeTimer.Tick += new EventHandler(volumeTimer_Tick);

            volumeTimer2 = new Timer();
            volumeTimer2.Interval = 5;
            volumeTimer2.Tick += new EventHandler(volumeTimer2_Tick);
        }

        private void volumeTimer2_Tick(object sender, EventArgs e)
        {
            if (form.axWindowsMediaPlayer1.settings.volume != 0)
                form.axWindowsMediaPlayer1.settings.volume -= 1;
            else
            {
                form.axWindowsMediaPlayer1.settings.volume = 0;
                form.axWindowsMediaPlayer1.URL = currentSong.getPath();
               // form.label3.Text = form.axWindowsMediaPlayer1.currentMedia.durationString + " \\";
                form.delayTimer1.Start();
                volumeUp();
                volumeTimer2.Stop();
            }
        }

        private void volumeTimer_Tick(object sender, EventArgs e)
        {
            if (form.axWindowsMediaPlayer1.settings.volume < volumeValue)
                form.axWindowsMediaPlayer1.settings.volume += 1;
            else
            {
                form.axWindowsMediaPlayer1.settings.volume = volumeValue;
                volumeTimer.Stop();
            }
        }

        public void volumeUp()
        {
            form.axWindowsMediaPlayer1.settings.volume = 0;
            volumeTimer.Start();
        }

        private void createNowPlayingFromArguments(List<String> songs)
        {
            Playlist playlist = new Playlist("Now Playing");
            foreach (String song in songs)
                playlist.addSongs(new Song(song));

            this.setNowPlaying(playlist);
            
            //playPlaylistFromBegining();
        }

        private void addInitialSongsToNowPlaying(List<String> songs)
        {
            if (songs.Count > 0)
            {
                createNowPlayingFromArguments(songs);
                return;
            }

            if (!File.Exists(Player.nowPlayingPath))
                return;
            
            XmlDocument document = new XmlDocument();
            document.Load(Player.nowPlayingPath);
            nowPlaying = new Playlist("Now Playing");

            foreach(XmlNode node in document.SelectNodes("/Playlist/Song"))
                nowPlaying.addSongs(new Song(node.InnerText));
          
            form.NowPlayingListBox.Items.AddRange(nowPlaying.getSongs().ToArray());
            if (form.NowPlayingListBox.Items.Count == 0)
                return;
            form.NowPlayingListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Gi cita playlistite od fajlot i gi dodava vo ListBoxot za playlisti
        /// </summary>
        private void addPlaylistsToTheList()
        {

            if (!File.Exists(Player.playlistsTxt))
                return;
            string[] files = File.ReadAllLines(playlistsTxt);
            foreach (String file in files)
            {
                Playlist playlist = new Playlist(file);
                form.PlaylistsListBox.Items.Add(playlist);
            }
        }

        public Form2 getForm()
        {
            return this.form;
        }
        private void setForm(Form2 form)
        {
            this.form = form;
        }

        public MediaState getMediaState()
        {
            return this.mediaState;
        }
        public void setMediaState(MediaState state)
        {
            this.mediaState = state;
        }
        private void setOpenFileDialog()
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
        }

        private void resetSongDisplayName()
        {
            songDisplayName = "";
            for (int i = 0; i < 50; i++)
                songDisplayName += " ";
            songDisplayName += currentSong.getName();
            form.displaySongTimer.Start();
        }

        public void PlaySong()
        {
            form.label10.Text = (form.NowPlayingListBox.Items.IndexOf(currentSong)+1).ToString();
            lyricsSearcher.SearchForLyrics();
            handleVolume();
            resetSongDisplayName();
            form.NowPlayingListBox.Refresh();
        }

        private void handleVolume()
        {
            volumeTimer2.Start();
            volumeValue = form.axWindowsMediaPlayer1.settings.volume;
        }

        private void playCurrentSong()
        {
            try
            {

                resetSongDisplayName();
                // form.axWindowsMediaPlayer1.URL = currentSong.getPath();
                // form.axWindowsMediaPlayer1.Ctlcontrols.stop();
                handleVolume();
                form.setHorizontalExtent(form.NowPlayingListBox);
                //  form.delayTimer1.Start();
                form.label10.Text = (form.NowPlayingListBox.SelectedIndex + 1).ToString();
                form.NowPlayingListBox.Refresh();
                form.PlaylistsListBox.Refresh();
                lyricsSearcher.SearchForLyrics();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public MediaStateHandler getMediaStateHandler()
        {
            return this.mediaStateHandler;
        }

        public void HandleMediaState()
        {
            mediaStateHandler.HandleMediaState();
        }

        public Song getCurrentSong()
        {
            return currentSong;
        }

        public void setCurrentSong(Song value)
        {
            this.currentSong = value;
        }
        public String getSongDisplayName()
        {
            return this.songDisplayName;
        }
        public void setSongDisplayName(String value)
        {
            this.songDisplayName = value;
        }

        public void playPlaylistFromBegining()
        {
            if (nowPlaying.getSongs().Count == 0)
                return;

            currentSong = nowPlaying.getSongs()[0];
            setSongDisplayName(currentSong.getName());
            form.NowPlayingListBox.SelectedItem = currentSong;
            form.NowPlayingListBox.SelectedIndex = 0;
            playCurrentSong();
        }

        public void playSelectedSong(ListBox fromWhichListbox)
        {
            if ((Song)fromWhichListbox.SelectedItem != null)
                currentSong = (Song)fromWhichListbox.SelectedItem;

               playCurrentSong();
        }

        public Playlist getPreviewPlaylist()
        {
            return this.previewPlaylist;
        }

        public Playlist getNowPlaying()
        {
            return nowPlaying;
        }

        public void setNowPlaying(Playlist value)
        {
            this.nowPlaying = value;
            form.NowPlayingListBox.Items.Clear();
            form.NowPlayingListBox.Items.AddRange(nowPlaying.getSongs().ToArray());
            
            //// Tuka treba da se zapise vo fajl nowplaying 
            writeNowPlayingToFile();
        }

        private void writeNowPlayingToFile()
        {
            XmlDocument document = new XmlDocument();
            File.Delete(Player.nowPlayingPath);
         
            XmlElement playlist = document.CreateElement("Playlist");
            document.AppendChild(playlist);
            XmlElement name = document.CreateElement("Name");
            name.InnerText = "Now Playing";
            playlist.AppendChild(name);
            foreach(Song song in this.nowPlaying.getSongs())
            {
                XmlElement songNode = document.CreateElement("Song");
                songNode.InnerText = song.getPath();
                playlist.AppendChild(songNode);
            }

            document.Save(Player.nowPlayingPath);
       
        }

        public void addPlaylist(Playlist playlist)
        {
            this.playlists.Add(playlist);
        }

        public void NextSong()
        {
            this.mediaStateHandler.NextSong();
        }

        public void PreviousSong()
        {
            this.mediaStateHandler.PreviousSong();
        }

        /// <summary>
        /// Ja menuva Preview playlistata, gi cita pesnite za taa lista od nejziniot fajl i gi stava vo memorija
        /// </summary>
        public void changePreviewPlaylist()
        {
            if(previewPlaylist!=null)
                this.previewPlaylist.setSongs(new List<Song>());
            this.previewPlaylist = (Playlist)form.PlaylistsListBox.SelectedItem;
            if (previewPlaylist != null)
                 readSongsToCurrentPlaylist();
        }

        /// <summary>
        /// Gi vcituva pesnite od fajlot na listata i gi dodava vo LibraryListBox vo Form2
        /// </summary>
        private void readSongsToCurrentPlaylist()
        {
            bool result = this.previewPlaylist.createPlaylist();
            if(!result)
            {
                form.PlaylistsListBox.Items.Clear();
                this.addPlaylistsToTheList();
                return;
            }
            form.LibraryListBox.Items.Clear();
            form.LibraryListBox.Items.AddRange(previewPlaylist.getSongs().ToArray());
        }

        public void createPlaylist()
        {
            String playlistName = "";
            DialogResult dialog = Class1.InputBox("Create new Playlist", "Playlist name", ref playlistName);
            if (dialog != DialogResult.OK || playlistName == "")
                return;

            if (!Directory.Exists(playlistsFolder))
                Directory.CreateDirectory(playlistsFolder);

            if (File.Exists(playlistsFolder + playlistName + ".pl"))
            {
                MessageBox.Show("The playlist already exist");
                return;
            }

            Playlist newPlaylist = new Playlist(playlistName);
            using(FileStream stream = File.Create(newPlaylist.getFilePath()))
            {
                stream.Close();
            }

            dialog = openFileDialog1.ShowDialog();
            if (dialog == System.Windows.Forms.DialogResult.OK)
            {
                List<Song> songs = new List<Song>();
                foreach (String file in openFileDialog1.FileNames)
                {
                    songs.Add(new Song(file));
                }

                addSongsToSongsBook(songs);
                newPlaylist.setSongs(songs);
            }

            newPlaylist.writePlaylistToFile();
            newPlaylist.setSongs(new List<Song>());
            /// Ja dodava novata playlista vo txt fajlot so site playlisti
            addPlaylistNameToTheList(newPlaylist.getName());
            form.PlaylistsListBox.Items.Add(newPlaylist);
            form.PlaylistsListBox.SelectedItem = newPlaylist;
        }

        private void createSongsBook()
        {
            if(!File.Exists(Player.songsbookPath))
            {
                XmlDocument document = new XmlDocument();
                XmlElement songsbook = document.CreateElement("Songsbook");
                songsbook.InnerText = " ";
                document.AppendChild(songsbook);
                document.Save(Player.songsbookPath);
            }
        }

        /// <summary>
        /// Gi dodava novite pesni vo Songsbook-ot koj sto sluzi za pobrzo prebaruvanje na pesnite
        /// </summary>
        /// <param name="songs">Pesnite sto treba da se dodadat vo Songsbook-ot</param>
        public void addSongsToSongsBook(List<Song> songs)
        {
            XmlDocument document = new XmlDocument();
            document.Load(Player.songsbookPath);
            foreach(Song song in songs)
            {
               
                XmlNode node = document.SelectSingleNode("/Songsbook");
                XmlElement songNode = document.CreateElement("Song");
                songNode.InnerText = song.getPath();
                songNode.SetAttribute("Name", song.getName());
                node.AppendChild(songNode);
            }
            document.Save(Player.songsbookPath);
        }

        /// <summary>
        /// Gi brise pesnite od songsbook-ot
        /// </summary>
        /// <param name="songs">Pesnite sto treba da se izbrisat</param>
        public void deleteSongsFromSongsBook(List<Song> songs)
        {
            XmlDocument document = new XmlDocument();
            document.Load(songsbookPath);
            for (int i = songs.Count - 1; i >= 0; i--)
            {
                Song song = songs[i];

                foreach (XmlNode node in document.SelectNodes("/Songsbook/Song"))
                {
                    if (node.InnerText.Equals(song.getPath()))
                    {
                        document.SelectSingleNode("/Songsbook").RemoveChild(node);
                    }
                }
            }

            document.Save(songsbookPath);
        }

        public void viewAllSongsFromLibrary()
        {
            if (previewPlaylist == null)
                previewPlaylist = new Playlist("Preview Playlist");
          
            List<Song> songsToAdd = new List<Song>();

            XmlDocument document = new XmlDocument();
            document.Load(songsbookPath);
            foreach (XmlNode node in document.SelectNodes("/Songsbook/Song"))
                songsToAdd.Add(new Song(node.InnerText));

            previewPlaylist.setSongs(songsToAdd);
            form.LibraryListBox.Items.Clear();
            form.LibraryListBox.Items.AddRange(previewPlaylist.getSongs().ToArray<Song>());
            form.showLibraryListBox();
        }

        private void addPlaylistNameToTheList(String name)
        {
            if(!File.Exists(playlistsTxt))
                using(FileStream stream = File.Create(playlistsTxt))
                {
                    stream.Close();
                }
            
            using(StreamWriter sw = File.AppendText(playlistsTxt))
            {
                sw.WriteLine(name);
                sw.Close();
            }
        }

        public void searchSong(String search)
        {
            XmlDocument document = new XmlDocument();
            document.Load(Player.songsbookPath);
            List<Song> songs = new List<Song>();
            foreach(XmlNode node in document.SelectNodes("/Songsbook/Song"))
            {
                string nodeName = node.InnerText.ToLower();
                if (nodeName.ToLower().Contains(search))
                    songs.Add(new Song(node.InnerText));
            }

            previewPlaylist = new Playlist("Search Songs", songs);
            form.LibraryListBox.Items.Clear();
            form.LibraryListBox.Items.AddRange(songs.ToArray<Song>());
        }


        public void SetCurrentEffectPreset(int value)
        {
            WindowsIdentity identiry = WindowsIdentity.GetCurrent();
            String path = String.Format(@"{0}\Software\Microsoft\MediaPlayer\Preferences", identiry.User.Value);
            RegistryKey key = Registry.Users.OpenSubKey(path, true);
            if (key == null)
                throw new Exception("Registry key not found!");
            key.SetValue("CurrentEffectPreset", value, RegistryValueKind.DWord);
        }

        public void deletePlaylist(Playlist p)
        {
            string[] files = File.ReadAllLines(Player.playlistsTxt);
            File.Delete(Player.playlistsTxt);
            List<String> newList = new List<string>();
            foreach (String s in files)
                if (!s.Equals(p.getName()))
                    newList.Add(s);
            File.WriteAllLines(Player.playlistsTxt, newList);
            File.Delete(p.getFilePath());
            form.PlaylistsListBox.Items.Remove(p);
            form.LibraryListBox.Items.Clear();
        }
    }
}
