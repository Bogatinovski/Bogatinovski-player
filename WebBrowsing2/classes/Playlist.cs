using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Bogatinovski_Player
{
    class Playlist
    {
      
        protected List<Song> songs;
        protected String name;
        protected String filePath;

        public Playlist(String name)
        {
            setName(name);
            setFilePath();
            songs = new List<Song>();         
        }
        public Playlist(String name, params Song[] songs) : this(name)
        {
            this.songs.AddRange(songs);
        }

        public Playlist(String name, List<Song> songs)
            : this(name)
        {
            this.songs.AddRange(songs);
        }

        public void addSongs(List<Song> songs)
        {
            this.songs.AddRange(songs);
        }

        public void addSongs(params Song[] songs)
        {
            this.songs.AddRange(songs);
        }


        public void delteSongs(params Song[] songs)
        {
            foreach (Song song in songs)
                this.songs.Remove(song);
            deleteSongsFromFile(songs);
        }

        public void setName(String value)
        {
            if (!value.Contains(".pl"))
                this.name = value + ".pl";
            else this.name = value;
        }

        public String getName()
        {
            return this.name;
        }

        public List<Song> getSongs()
        {
            return this.songs;
        }

        public void setSongs(List<Song> songs)
        {
            this.songs = songs;
        }

        private void setFilePath()
        {
            this.filePath = Player.playlistsFolder + this.name;
        }

        public String getFilePath()
        {
            return this.filePath;
        }

        public void renamePlaylist(String newName)
        {
            String oldName = this.name;
            String oldPath = this.filePath;
            setName(newName);
            XmlDocument document = new XmlDocument();
            document.Load(this.filePath);
            document.SelectSingleNode("/Playlist/Name").InnerText = name;
            document.Save(filePath);

            FileInfo file = new FileInfo(filePath);
            file.MoveTo(file.FullName.Replace(oldName, name));
            this.filePath = file.FullName;

            List<String> playlists = File.ReadAllLines(Player.playlistsTxt).ToList<String>();
            for (int i = 0; i < playlists.Count; i++)
                if (playlists[i] == oldName)
                {
                    playlists[i] = name;
                    break;
                }
                          
            File.WriteAllLines(Player.playlistsTxt, playlists.ToArray());
        }

        /// <summary>
        /// Go cita svojot xml fajl i ja polni listata so pesni
        /// </summary>
        public bool createPlaylist()
        {
            if(!File.Exists(this.filePath))
            {
                DialogResult result = MessageBox.Show("Delete playlist from library?",
                    "The playlist file does not exit! ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(result == DialogResult.Yes)
                {
                    List<String> playlists = File.ReadAllLines(Player.playlistsTxt).ToList<String>();
                    for (int i = 0; i < playlists.Count; i++)
                        if (playlists[i] == this.name)
                            playlists.RemoveAt(i);

                    File.WriteAllLines(Player.playlistsTxt, playlists.ToArray());
                }
                return false;
            }
            XmlDocument document = new XmlDocument();
            document.Load(this.filePath);
            foreach (XmlNode node in document.SelectNodes("/Playlist/Song"))
                this.songs.Add(new Song(node.InnerText));
            return true;
        }

        /// <summary>
        /// Ja zacuvuva listata so pesni vo svojot xml fajl
        /// </summary>
        public void writePlaylistToFile()
        {
            XmlDocument document = new XmlDocument();
            XmlElement playlist = document.CreateElement("Playlist");
            document.AppendChild(playlist);
            XmlElement name = document.CreateElement("Name");
            XmlText nameNode = document.CreateTextNode(this.name);
            name.AppendChild(nameNode);
            playlist.AppendChild(name);
            
            foreach(Song song in this.songs)
            {
                XmlElement songNode = document.CreateElement("Song");
                XmlText songPath = document.CreateTextNode(song.getPath());
                songNode.AppendChild(songPath);
                playlist.AppendChild(songNode);
            }

            document.Save(this.filePath);
        }

        public int getSongsCount()
        {
            return songs.Count;
        }

        /// <summary>
        /// Gi zapisuva novodoadenite pesni vo xml fajlot
        /// </summary>
        public void writeNewSongsToFile(List<Song> newSongs)
        {
            XmlDocument document = new XmlDocument();
            document.Load(this.filePath);
            foreach(Song song in newSongs)
            {
                XmlElement songNode = document.CreateElement("Song");
                songNode.InnerText = song.getPath();
                document.SelectSingleNode("Playlist").AppendChild(songNode);
            }
            document.Save(this.filePath);
        }

        /// <summary>
        /// Gi brise selektiranite pesni od xml fajlot
        /// </summary>
        /// <param name="songs">Pesnite sto treba da se izbrisat</param>
        protected void deleteSongsFromFile(params Song[] songs)
        {
            XmlDocument document = new XmlDocument();
            document.Load(this.filePath);
            for (int i = songs.Length - 1; i >= 0; i--)
            {
                Song song = songs[i];

                foreach (XmlNode node in document.SelectNodes("/Playlist/Song"))
                {
                    if (node.InnerText.Equals(song.getPath()))
                    {
                        document.SelectSingleNode("Playlist").RemoveChild(node);
                    }
                }                
            }

            document.Save(this.filePath);
        }

        public override string ToString()
        {
            return this.name.Substring(0, this.name.Length-3);
        }


    }
}
