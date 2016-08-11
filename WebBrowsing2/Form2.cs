using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Xml;
using System.Collections;
using System.Diagnostics;
using AxWMPLib;

namespace Bogatinovski_Player
{
    public partial class Form2 : Form
    {
        #region Fields
        /// <summary>
        /// Promenliva sto pokazuva dali da se minimizira prozorecot so lista od playlisti
        /// </summary>
        bool playlistsOff = true;

        /// <summary>
        /// Konstanta sto pokazuva so koja brzina se zatvara prozorecot so lista od playlisti
        /// </summary>
        const int speed = 10;

        /// <summary>
        /// Promenliva sto proveruva dali menito e Dock ili Auto Hide
        /// </summary>
        bool menuOnTop = true;

        /// <summary>
        /// Na kolku pikseli od gorniot rab na programot da se pusta menito
        /// </summary>
        int menuSensitivity = 3;


        public bool lyricsOn = false;
        bool showVisualization = false;
        Panel lyricsPanel;
        Player mediaPlayer;
        public WebBrowser browser;

        #endregion
       
        public Form2(List<String> args)
        {
            InitializeComponent();
            mediaPlayer = new Player(this, args);
            setHorizontalExtent(PlaylistsListBox);
            setHorizontalExtent(LibraryListBox);
            setHorizontalExtent(NowPlayingListBox);
            showNowPlaying();
            if (args.Count > 0)
                mediaPlayer.playPlaylistFromBegining();
            DoubleBuffered = true;
        }


        /// <summary>
        /// Go mesti playerot da bide ili da ne bide fullscreen
        /// </summary>
        private void axWindowsMediaPlayer1_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            try
            {
                if (axWindowsMediaPlayer1.fullScreen == false)
                    axWindowsMediaPlayer1.fullScreen = true;
                else
                    axWindowsMediaPlayer1.fullScreen = false;
            }
            catch { }
        }
  
        /// <summary>
        /// Proveruva dali pesnata sto e pustena zavrsila i ako zavrsila se pusta narednata pesna
        /// </summary>
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
                mediaPlayer.HandleMediaState();
        }    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
              Search();
        }

        /// <summary>
        /// Ovoj metod proveruva niz site playlisti dali ima nekoja pesna 
        /// </summary>
        private void Search()
        {
        }

        /// <summary>
        /// Proveruva dali da go pojavi ili da go trgne menito gore
        /// </summary>
        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            HandleMenu(e);
        }

        /// <summary>
        /// Maximizes the menu
        /// </summary>
        private void ShowMenu()
        {
            NowPlayingListBox.Location = new Point(NowPlayingListBox.Location.X, Menu.Size.Height);
            PlaylistsListBox.Location = new Point(PlaylistsListBox.Location.X,  Menu.Size.Height);
            LibraryListBox.Location = new Point(LibraryListBox.Location.X,  Menu.Size.Height);

            Menu.Visible = true;
            ResetSearchFont();
        }

        /// <summary>
        /// Minimizes the Menu
        /// </summary>
        private void HideMenu()
        {
            NowPlayingListBox.Location = new Point(NowPlayingListBox.Location.X, 0);
            PlaylistsListBox.Location = new Point(PlaylistsListBox.Location.X,0);
            LibraryListBox.Location = new Point(LibraryListBox.Location.X, 0);

            Menu.Visible = false;
        }

        /// <summary>
        /// Proveruva dali da go pojavi ili da go trgne menito gore
        /// </summary>
        private void PlaylistListBox_MouseMove(object sender, MouseEventArgs e)
        {
            HandleMenu(e);
        }

        /// <summary>
        /// Shows or Hides the menu
        /// </summary>
        void HandleMenu(MouseEventArgs e)
        {
            if (menuOnTop == false)
                if (e.Y < menuSensitivity && Menu.Visible == false)
                    ShowMenu();

                else if (e.Y > menuSensitivity && Menu.Visible == true)
                    HideMenu();
        }

        /// <summary>
        /// Dock Menu
        /// </summary>
        private void dockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuOnTop == false)
            {
                menuOnTop = true;
                ShowMenu();
                autoHideToolStripMenuItem.Checked = false;
            }
        }

        /// <summary>
        /// Auto Hide Menu
        /// </summary>
        private void autoHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuOnTop == true)
            {
                menuOnTop = false;
                HideMenu();
                dockToolStripMenuItem.Checked = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Playlist Window On/Off
        /// </summary>
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
                // Proveruva dali e otvorena i ja zatvara 
                if (playlistsOff && timer2.Enabled == false && timer1.Enabled == false)
                {
                    NowPlayingListBox.Size = new Size(NowPlayingListBox.Size.Width + 25, NowPlayingListBox.Size.Height);
                    LibraryListBox.Size = new Size(LibraryListBox.Size.Width + 25, LibraryListBox.Size.Height);
                    PlaylistsListBox.Size = new Size(PlaylistsListBox.Size.Width + 25, PlaylistsListBox.Size.Height);
                    timer1.Start();
                    return;
                }
                // Ja otvara
                else if(!playlistsOff && timer1.Enabled == false && timer2.Enabled == false)
                {
                    NowPlayingListBox.Size = new Size(NowPlayingListBox.Size.Width + 25, NowPlayingListBox.Size.Height);
                    LibraryListBox.Size = new Size(LibraryListBox.Size.Width + 25, LibraryListBox.Size.Height);
                    PlaylistsListBox.Size = new Size(PlaylistsListBox.Size.Width + 25, PlaylistsListBox.Size.Height);
                    timer2.Start();
                    return;
                }
            
        }

        private void CloseListBox(ListBox list)
        {
            list.Location = new Point(list.Location.X - speed, list.Location.Y);
            list.Size = new Size(list.Size.Width + speed, list.Size.Height);
        }
        /// <summary>
        /// Ja zatvara kontrolata (listboxot) so listata na playlisti
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PlaylistsListBox.Size.Width+PlaylistsListBox.Location.X  > 0)
            {
                PlaylistsListBox.Location = new Point(PlaylistsListBox.Location.X - speed, PlaylistsListBox.Location.Y);
                CloseListBox(NowPlayingListBox);
                CloseListBox(LibraryListBox);
            }
            else
            {
                PlaylistsListBox.Location = new Point(-PlaylistsListBox.Size.Width, PlaylistsListBox.Location.Y);
                PlaylistsListBox.Size = new Size(PlaylistsListBox.Size.Width - 25, PlaylistsListBox.Size.Height);
                NowPlayingListBox.Size = new Size(this.Width - 17, PlaylistsListBox.Size.Height);
                NowPlayingListBox.Location = new Point(0, NowPlayingListBox.Location.Y);
                LibraryListBox.Size = NowPlayingListBox.Size;
                LibraryListBox.Location = NowPlayingListBox.Location;
                playlistsOff = false;
                timer1.Enabled = false; 
            }
        }

        private void OpenListBox(ListBox list)
        {
            list.Location = new Point(list.Location.X + speed, list.Location.Y);
            list.Size = new Size(list.Size.Width - speed, list.Size.Height);
        }
        /// <summary>
        /// Ja otvara kontrolata (listboxot) so playlisti
        /// </summary>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (PlaylistsListBox.Location.X < 0)
            {
                PlaylistsListBox.Location = new Point(PlaylistsListBox.Location.X + speed, PlaylistsListBox.Location.Y);
                OpenListBox(NowPlayingListBox);
                OpenListBox(LibraryListBox);
            }
            else
            {
                PlaylistsListBox.Location = new Point(0, PlaylistsListBox.Location.Y);
                PlaylistsListBox.Size = new Size(PlaylistsListBox.Size.Width - 25, PlaylistsListBox.Size.Height);
                NowPlayingListBox.Location = new Point(PlaylistsListBox.Size.Width, NowPlayingListBox.Location.Y);
                NowPlayingListBox.Size = new Size(this.Size.Width - NowPlayingListBox.Location.X - 17, PlaylistsListBox.Size.Height);
                LibraryListBox.Size = NowPlayingListBox.Size;
                LibraryListBox.Location = NowPlayingListBox.Location;
                playlistsOff = true;
                timer2.Stop();
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
                searchTextBox.Font = new Font("Microsoft Sans Serif", 8.5f ,FontStyle.Regular);
            }
        }

        private void ResetSearchFont()
        {
            searchTextBox.ForeColor = Color.Gray;
            searchTextBox.Text = "Search";
            searchTextBox.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Italic);
        }

        private void Form2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Form2_DragDrop(object sender, DragEventArgs e)
        {
            string[] songs = (string[])e.Data.GetData(DataFormats.FileDrop, false);
       
            if(mediaPlayer.getNowPlaying()==null)
            {
                Playlist playlist = new Playlist("Now Playing");
                foreach (String song in songs)
                    playlist.addSongs(new Song(song));

                mediaPlayer.setNowPlaying(playlist);
            }
            else
            {
                Playlist playlist = new Playlist("Now Playing");
                playlist.addSongs(mediaPlayer.getNowPlaying().getSongs());
                foreach (String song in songs)
                    playlist.addSongs(new Song(song));

                mediaPlayer.setNowPlaying(playlist);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryListBox.Visible = false;
        }

        private void listBox2_MouseMove(object sender, MouseEventArgs e)
        {
            HandleMenu(e);
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTimerOn.Enabled = true;
            offToolStripMenuItem5.Checked = false;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTimerOff.Enabled = true;
            onToolStripMenuItem.Checked = false;
        }

        private void SearchTimerOn_Tick(object sender, EventArgs e)
        {
            if (searchTextBox.Location.Y < 1)
                searchTextBox.Location = new Point(searchTextBox.Location.X, searchTextBox.Location.Y + 1);
            else
            {
                searchTextBox.Location = new Point(searchTextBox.Location.X, 1);
                SearchTimerOn.Enabled = false;
            }
        }


        private void SearchTimerOff_Tick(object sender, EventArgs e)
        {
            if (searchTextBox.Location.Y > -30)
                searchTextBox.Location = new Point(searchTextBox.Location.X, searchTextBox.Location.Y - 1);
            else
            {
                searchTextBox.Location = new Point(searchTextBox.Location.X, -30);
                SearchTimerOff.Enabled = false;
            }
        }

        private void listBox2_MouseUp(object sender, MouseEventArgs e)
        {
            SelectItemWIthRightClick(sender, e);   
        }

        private void PlaylistListBox_MouseUp(object sender, MouseEventArgs e)
        {
            SelectItemWIthRightClick(sender, e);  
        }

        void SelectItemWIthRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int item = ((ListBox)sender).IndexFromPoint(e.X, e.Y);
                if (item >= 0)
                {
                    ((ListBox)sender).SelectedIndex = item;
                    contextMenuStrip1.Show(((ListBox)sender), e.Location);
                }
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            ResetGUIElements();           
        }

        private void ResetGUIElements()
        {
            if (lyricsOn)
            {
                LibraryListBox.MaximumSize = NowPlayingListBox.MaximumSize = PlaylistsListBox.MaximumSize = new Size(200, 400);
                axWindowsMediaPlayer1.MaximumSize = new Size(400, axWindowsMediaPlayer1.MaximumSize.Height);
            }
            else
            {
                PlaylistsListBox.MaximumSize = NowPlayingListBox.MaximumSize = axWindowsMediaPlayer1.MaximumSize
                    = LibraryListBox.MaximumSize = new Size(2000, 400);
            }
                
            
            if(lyricsOn)
            {
                lyricsPanel.Location = new Point(400, NowPlayingListBox.Location.Y);
                lyricsPanel.Size = new Size(this.Width-lyricsPanel.Location.X, this.Size.Height);
            }
            int height = Menu.Location.Y + Menu.Size.Height;
            PlaylistsListBox.Size = new Size(this.Size.Width / 2, 2 * this.Size.Height / 3);
            if (!playlistsOff)
            {
                PlaylistsListBox.Location = new Point(-PlaylistsListBox.Size.Width, height);
                NowPlayingListBox.Size = new Size(this.Width - 17, PlaylistsListBox.Size.Height);
                NowPlayingListBox.Location = new Point(0, height);
            }
            else
            {

                PlaylistsListBox.Location = new Point(0, height);
                NowPlayingListBox.Location = new Point(PlaylistsListBox.Size.Width - 2, height);
                NowPlayingListBox.Size = new Size(this.Size.Width - NowPlayingListBox.Location.X - 17, PlaylistsListBox.Size.Height);
            }

            if (this.Size.Width > 420)
            {
                int offset = 0;
                if (!playlistsOff)
                    offset = 100;
                searchTextBox.Location = new Point(this.Size.Width - searchTextBox.Size.Width / 2 - NowPlayingListBox.Size.Width / 2 + offset, searchTextBox.Location.Y);
            }
            else
                searchTextBox.Location = new Point(this.Size.Width - searchTextBox.Size.Width - 20, searchTextBox.Location.Y);

            LibraryListBox.Size = NowPlayingListBox.Size;
            LibraryListBox.Location = NowPlayingListBox.Location;
            textBox2.Location = new Point(axWindowsMediaPlayer1.Right - textBox2.Size.Width - 35, axWindowsMediaPlayer1.Bottom - textBox2.Size.Height - 5);
            label3.Location = new Point(axWindowsMediaPlayer1.Right -label3.Width-35, axWindowsMediaPlayer1.Bottom- label3.Height-47);
            label1.Location = new Point(LibraryListBox.Location.X + (LibraryListBox.Width-label1.Width)/2, label1.Location.Y);
            handleVisualizationAndInfoPanel(height);
            label11.Location = new Point(textBox2.Location.X + textBox2.Size.Width+2, textBox2.Location.Y+textBox2.Size.Height/2-label11.Size.Height/2);
            button2.Location = new Point(button2.Location.X, axWindowsMediaPlayer1.Bottom-30);
            button1.Location = new Point(button1.Location.X, axWindowsMediaPlayer1.Bottom - 30);
        }

        private void handleVisualizationAndInfoPanel(int height)
        {
            if (showVisualization)
                axWindowsMediaPlayer1.Size = new Size(axWindowsMediaPlayer1.Size.Width, axWindowsMediaPlayer1.Bottom - PlaylistsListBox.Bottom);
            else
                axWindowsMediaPlayer1.Size = new Size(axWindowsMediaPlayer1.Size.Width, axWindowsMediaPlayer1.MinimumSize.Height);
            

            infoPanel.Size = new Size(this.Width, axWindowsMediaPlayer1.Location.Y - PlaylistsListBox.Size.Height -height);
            infoPanel.Location = new Point(0, PlaylistsListBox.Height + height);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ResetGUIElements();
        }

        private void createPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediaPlayer.createPlaylist();
            showLibraryListBox();
        }

        private void showNowPlaying()
        {
            this.Text = "Now Playing";
            label1.Text = "Go to library";
            label9.Text = (NowPlayingListBox.SelectedIndex + 1).ToString();
            label7.Text = (mediaPlayer.getNowPlaying() == null ? (0).ToString() :
            (mediaPlayer.getNowPlaying().getSongs().Count).ToString());
            NowPlayingListBox.BringToFront();
        }

        public void showLibraryListBox()
        {
            this.Text = "Library";
            label1.Text = "Go to now playing";
            label9.Text = (LibraryListBox.SelectedIndex + 1).ToString();
            label7.Text = (mediaPlayer.getPreviewPlaylist() == null ? (0).ToString() :
            (mediaPlayer.getPreviewPlaylist().getSongs().Count).ToString());
            LibraryListBox.BringToFront();
        }

        private void PlaylistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediaPlayer.changePreviewPlaylist();
            label7.Text = LibraryListBox.Items.Count.ToString();
            setHorizontalExtent(LibraryListBox);
        }
        
        public void setHorizontalExtent(ListBox listbox)
        {
            using (Graphics g = listbox.CreateGraphics())
            {
                SizeF size;
                int width = 0;
                foreach (Object s in listbox.Items)
                {
                    size = g.MeasureString(s.ToString(), LibraryListBox.Font);
                    if (size.Width > width)
                    {
                        width = (int)size.Width;
                    }
                }
            }

            listbox.HorizontalExtent = Width + 2;
        }
        private void PlaylistsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (PlaylistsListBox.SelectedItem == null || mediaPlayer.getPreviewPlaylist()==null)
                return;
                mediaPlayer.setNowPlaying((Playlist)PlaylistsListBox.SelectedItem);
                mediaPlayer.playPlaylistFromBegining();
                setSongsInNowPlayingLabel();

                label9.Text = (NowPlayingListBox.SelectedIndex + 1).ToString();
                showNowPlaying();
        }

        private void setSongsInNowPlayingLabel()
        {
            label8.Text = mediaPlayer.getNowPlaying().getSongsCount().ToString();
        }

        private void PlaylistsListBox_Click(object sender, EventArgs e)
        {
            showLibraryListBox();
        }

        private void NowPlayingListBox_DoubleClick(object sender, EventArgs e)
        {
            mediaPlayer.playSelectedSong((ListBox)sender);
            label8.Text = (mediaPlayer.getNowPlaying().getSongs().Count).ToString();
        }

        private void LibraryListBox_DoubleClick(object sender, EventArgs e)
        {
            if (LibraryListBox.SelectedItem == null)
                return;

                mediaPlayer.setNowPlaying(mediaPlayer.getPreviewPlaylist());
                NowPlayingListBox.Items.Clear();
                NowPlayingListBox.Items.AddRange(mediaPlayer.getNowPlaying().getSongs().ToArray());
                showNowPlaying();
                mediaPlayer.playSelectedSong((ListBox)sender);
                setSongsInNowPlayingLabel();
                label10.Text = (LibraryListBox.SelectedIndex+1).ToString();
                label8.Text = (mediaPlayer.getNowPlaying().getSongs().Count).ToString();
            
        }

        public void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            Brush brush = Brushes.White;
            Color backColor;
            bool changeBrush = false;
            backColor = Color.FromArgb(255,200, 200, 200);
            String listBoxName = ((ListBox)sender).Name;
            ListBox listbox = (ListBox)sender;
            /// ************
            /// Ako e PlaylistsListBox ili NowPlayingListBox ja menuva pozadinata na aktivnite elementi
            /// t.e. Vo PlaylistsListBox ja menuva pozadinata na playlistata od koja sto momentalno sviri pesna
            /// Vo NowPlayingListBox ja menuva pozadinata na pesnata sto momentalno sviri
            /// Color backColor e bojata na pozadinata
            if (listBoxName.Equals("NowPlayingListBox"))
            {
                Song song = (Song)((ListBox)sender).Items[e.Index];
                if (song!=null && mediaPlayer.getCurrentSong()!=null&&listbox.Items.IndexOf(song).Equals(listbox.Items.IndexOf(mediaPlayer.getCurrentSong())))
                {
                    changeBrush = true;
                    e = new DrawItemEventArgs(e.Graphics,
                                e.Font,
                                e.Bounds,
                                e.Index,
                                e.State,
                                e.ForeColor,
                                backColor);
                }

            }
            else if (listBoxName.Equals("PlaylistsListBox"))
            {
                Playlist playlist = (Playlist)((ListBox)sender).Items[e.Index];
                if (mediaPlayer.getNowPlaying() != null && listbox.Items.IndexOf(playlist).Equals(listbox.Items.IndexOf(mediaPlayer.getNowPlaying())))
                {
                    changeBrush = true;
                    e = new DrawItemEventArgs(e.Graphics,
                                e.Font,
                                e.Bounds,
                                e.Index,
                                e.State,
                                e.ForeColor,
                                backColor);
                }
            }
            //// ****************************

            //if the item state is selected them change the back color 
           
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {

                    brush = Brushes.Black;
                    e = new DrawItemEventArgs(e.Graphics,
                                      e.Font,
                                      e.Bounds,
                                      e.Index,
                                      e.State ^ DrawItemState.Selected, e.ForeColor,
                                       Color.FromArgb(255,250,182,28));//Choose the color
                }
                else brush = Brushes.White;

                /// Vo koja boja da se smenat bukvite za aktivniot item
                if (changeBrush)
                    brush = Brushes.Black;

                // Draw the background of the ListBox control for each item.
                e.DrawBackground();
                // Draw the current item text

                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString() , e.Font, brush, e.Bounds, StringFormat.GenericDefault);
                // If the ListBox has focus, draw a focus rectangle around the selected item.
                e.DrawFocusRectangle();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Go to now playing")
                showNowPlaying();
            else showLibraryListBox();
            label1.Location = new Point(LibraryListBox.Location.X + (LibraryListBox.Width - label1.Width) / 2, label1.Location.Y);
           
        }

        private void displaySongTimer_Tick(object sender, EventArgs e)
        {
            String songName = mediaPlayer.getSongDisplayName();
            String newName = "";

            if (songName.Length == 1)
            {
                int counter = textBox2.Size.Width/3;
                for (int i = 0; i < counter; i++)
                    newName += " ";
                if(mediaPlayer.getCurrentSong()!=null)
                    newName += mediaPlayer.getCurrentSong().getName();
            }
            else newName = songName.Substring(1, songName.Length - 1);
            mediaPlayer.setSongDisplayName(newName);
            textBox2.Text = mediaPlayer.getSongDisplayName();
        }

        private void delayTimer1_Tick(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.currentMedia!=null)
            {
                label3.Text = axWindowsMediaPlayer1.currentMedia.durationString + @"  \";
                delayTimer1.Stop();
            }
          
        }

        private void LibraryListBox_Click(object sender, EventArgs e)
        {
            label9.Text = (LibraryListBox.SelectedIndex+1).ToString();
            label7.Text = (mediaPlayer.getPreviewPlaylist() == null ? (0).ToString() :
                (mediaPlayer.getPreviewPlaylist().getSongs().Count).ToString());
        }

        private void NowPlayingListBox_Click(object sender, EventArgs e)
        {
            label9.Text = (NowPlayingListBox.SelectedIndex+1).ToString();
            label7.Text = (NowPlayingListBox.Items.Count).ToString();
        }

       
        private void textBox1_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
        }

        private void searchTextBox_Click_1(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search")
            {
                searchTextBox.Text = "";
                label9.Visible = false;
                searchTextBox.ForeColor = Color.Black;
                searchTextBox.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            }
        }

        private void visualizationTimer_Tick(object sender, EventArgs e)
        {
            if(showVisualization)
            {
                axWindowsMediaPlayer1.Size = new Size(axWindowsMediaPlayer1.Size.Width, axWindowsMediaPlayer1.Size.Height + 3);
                if (axWindowsMediaPlayer1.Size.Height >= axWindowsMediaPlayer1.Bottom - PlaylistsListBox.Bottom)
                {
                    axWindowsMediaPlayer1.Size = new Size(axWindowsMediaPlayer1.Size.Width, axWindowsMediaPlayer1.Bottom - PlaylistsListBox.Bottom);
                    visualizationTimer.Stop();
                }
            }
            else
            {
                axWindowsMediaPlayer1.Size = new Size(axWindowsMediaPlayer1.Size.Width, axWindowsMediaPlayer1.Size.Height - 3);
              
                if (axWindowsMediaPlayer1.Size.Height <= axWindowsMediaPlayer1.MinimumSize.Height)
                {
                    ResetGUIElements();
                    axWindowsMediaPlayer1.Size = new Size(axWindowsMediaPlayer1.Size.Width, axWindowsMediaPlayer1.MinimumSize.Height);
                    visualizationTimer.Stop();
                }
            }
                
                
        }

        private void zdcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    ListBox source = (ListBox)owner.SourceControl;
                    Song song = (Song)source.SelectedItem;
                   
                    if(song!=null)
                        song.openFileLocation();
                }
            }
        }


        private void viewFullPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    ListBox source = (ListBox)owner.SourceControl;
                    Song song = (Song)source.SelectedItem;
                    if(song != null)
                        MessageBox.Show(song.getPath());
                }
            }
        }

        private void deleteSongFromPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    ListBox source = (ListBox)owner.SourceControl;

                    Playlist playlist = null;
                    Song song = null;
        
                    if (source.Name == "NowPlayingListBox")
                        playlist = mediaPlayer.getNowPlaying();
                    else if (source.Name == "LibraryListBox")
                        playlist = mediaPlayer.getPreviewPlaylist();

                    ListBox.SelectedObjectCollection items = source.SelectedItems;
                    List<Song> songs = new List<Song>();
                    foreach (Song item in items)
                        songs.Add(item);

                    mediaPlayer.deleteSongsFromSongsBook(songs);
                    playlist.delteSongs(songs.ToArray());
                    for (int i = items.Count - 1; i >= 0; i--)
                    {
                        song = (Song)items[i];
                        source.Items.Remove(song);
                    }

                    /// Update i na fajlot vo nowPlaying
                    if (source.Name == "NowPlayingListBox")
                        mediaPlayer.setNowPlaying(playlist);


                }
            }
        }

        private void onToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mediaPlayer.setMediaState(MediaState.Repeat);
            onToolStripMenuItem5.Checked = true;
            offToolStripMenuItem1.Checked = false;
            offToolStripMenuItem5.Checked = false;
        }

        private void onToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mediaPlayer.setMediaState(MediaState.Shuffle);
            onToolStripMenuItem4.Checked = true;
            offToolStripMenuItem2.Checked = false;
            offToolStripMenuItem4.Checked = false;
        }

        private void offToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mediaPlayer.setMediaState(MediaState.Normal);
            offToolStripMenuItem4.Checked = true;
            onToolStripMenuItem2.Checked = false;
            onToolStripMenuItem4.Checked = false;
        }

        private void offToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mediaPlayer.setMediaState(MediaState.Normal);
            offToolStripMenuItem5.Checked = true;
            onToolStripMenuItem1.Checked = false;
            onToolStripMenuItem5.Checked = false;
        }

        private void playSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    ListBox source = (ListBox)owner.SourceControl;
                    if(source.SelectedItems.Count>0)
                    {
                        ListBox.SelectedObjectCollection items = source.SelectedItems;
                        List<Song> songs = new List<Song>();
                        
                        foreach(Song item in items)
                        {
                            songs.Add((Song)item);
                        }

                        if (mediaPlayer.getNowPlaying() != null)
                            mediaPlayer.setNowPlaying(new Playlist("Now Playing", songs));
                        else mediaPlayer.setNowPlaying(new Playlist("Now Playing", songs));
                        NowPlayingListBox.Items.Clear();
                        NowPlayingListBox.Items.AddRange(songs.ToArray());
                        mediaPlayer.playPlaylistFromBegining();
                        setSongsInNowPlayingLabel();
                        label9.Text = (NowPlayingListBox.SelectedIndex + 1).ToString();
                        showNowPlaying();

                    }
                }
            }
        }

        private void goToNowPlayingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showNowPlaying();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            showVisualization = !showVisualization;
            visualizationTimer.Start();
            if(showVisualization)
            {
                label11.Text = "On";
                label11.ForeColor = Color.Lime;
            }
            else
            {
                label11.Text = "Off";
                label11.ForeColor = Color.White;
            }
        }

        private void onToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            showVisualization = true;
            offToolStripMenuItem3.Checked = false;
            visualizationTimer.Start();
        }

        private void offToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            showVisualization = false;
            onToolStripMenuItem3.Checked = false;
            visualizationTimer.Start();
        }

        private void repeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    ListBox source = (ListBox)owner.SourceControl;
                    ListBox.SelectedObjectCollection items = source.SelectedItems;
                    List<Song> songs = new List<Song>();

                    foreach (Song item in items)
                        songs.Add((Song)item);


                    List<Song> songRef = null;
                    if(source.Name=="LibraryListBox")
                        songRef = mediaPlayer.getPreviewPlaylist().getSongs();
                    else if (source.Name == "NowPlayingListBox")
                        songRef = mediaPlayer.getNowPlaying().getSongs();

                    foreach (Song song in songs)
                    {
                        songRef.Remove(song);
                        source.Items.Remove(song);
                    }
                }
            }
        }

        private void onToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            mediaPlayer.setMediaState(MediaState.Shuffle);
            onToolStripMenuItem2.Checked = true;
            offToolStripMenuItem4.Checked = false;
            offToolStripMenuItem2.Checked = false;
        }

        private void offToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            mediaPlayer.setMediaState(MediaState.Normal);
            offToolStripMenuItem2.Checked = true;
            onToolStripMenuItem4.Checked = false;
            onToolStripMenuItem2.Checked = false;
        }

        private void onToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            mediaPlayer.setMediaState(MediaState.Repeat);
            onToolStripMenuItem1.Checked = true;
            offToolStripMenuItem5.Checked = false;
            offToolStripMenuItem1.Checked = false;
        }

        private void offToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            mediaPlayer.setMediaState(MediaState.Normal);
            offToolStripMenuItem1.Checked = true;
            onToolStripMenuItem5.Checked = false;
            onToolStripMenuItem1.Checked = false;
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem == null)
                return;
            
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner == null)
                    return;

               ListBox source = (ListBox)owner.SourceControl;
               if (source.SelectedItem == null)
                   return;

               Playlist playlist = (Playlist)source.SelectedItem;
               if (playlist == null)
                   return;

               String playlistName = null;
               DialogResult dialog = Class1.InputBox("Rename Playlist", "Playlist name", ref playlistName, playlist.getName());
               if (dialog != DialogResult.OK || playlistName == "")
                   return;

               playlist.renamePlaylist(playlistName);
        }

        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    ListBox source = (ListBox)owner.SourceControl;
                    if (source.SelectedItem == null)
                        return;
                    
                    Playlist playlist = (Playlist)source.SelectedItem;

                    DialogResult result = openFileDialog1.ShowDialog();
                    if(result == System.Windows.Forms.DialogResult.OK)
                    {
                        if (openFileDialog1.FileNames == null || openFileDialog1.FileNames.Length == 0)
                            return;

                        List<Song> songs = new List<Song>();
                        foreach (String file in openFileDialog1.FileNames)
                            songs.Add(new Song(file));

                        playlist.addSongs(songs);
                        playlist.writeNewSongsToFile(songs);
                        LibraryListBox.Items.AddRange(songs.ToArray());
                        NowPlayingListBox.Refresh();
                        mediaPlayer.addSongsToSongsBook(songs);
                    }
                    
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mediaPlayer.NextSong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mediaPlayer.PreviousSong();
        }

        private void goToLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLibraryListBox();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    ListBox source = (ListBox)owner.SourceControl;
                    if (source.SelectedItem == null)
                        return;

                    Playlist playlist = (Playlist)source.SelectedItem;

                    DialogResult result = MessageBox.Show("Delete the selected playlist?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        mediaPlayer.deleteSongsFromSongsBook(playlist.getSongs());
                        mediaPlayer.deletePlaylist(playlist);
                    }
                  

                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            if (search.Length > 1)
            {
                showLibraryListBox();
                mediaPlayer.searchSong(search);
            }
               
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetCurrentEffectPreset(new Random().Next(30));
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoPanel.Refresh();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"D:\Documents\Programiranje\C # projects\LyricsSearcher\LyricsSearcher\bin\Debug\LyricsSearcher.exe";
            
            string arguments = "eminem+mockingbird+lyrics true";
            arguments += " " +this.Location.X + "+" + this.Location.Y;
           
            Process process = new Process();
            process.StartInfo.FileName = path;
            process.StartInfo.Arguments = arguments;
            process.Start();
        }

        private void stupidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!lyricsOn)
                createLyricsPanel();
            else
                destroyLyricsPanel();
            
            ResetGUIElements();
        }
        private void smartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!lyricsOn)
                createLyricsPanel();
            else
                destroyLyricsPanel();

            ResetGUIElements();
        }

        private void createLyricsPanel()
        {
            this.Size = new Size(this.Size.Width + 400, this.Size.Height);
            lyricsPanel = new Panel();
            lyricsPanel.BackColor = Color.White;
            lyricsPanel.BorderStyle = BorderStyle.Fixed3D;
            lyricsOn = true;
            this.Controls.Add(lyricsPanel);
            lyricsPanel.BringToFront();

            browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.ScrollBarsEnabled = true;
            browser.ScriptErrorsSuppressed = true;
            lyricsPanel.Controls.Add(browser);
            mediaPlayer.getLyricsSearcher().setBrowser(this.browser);
            if (mediaPlayer.getCurrentSong() != null)
                mediaPlayer.getLyricsSearcher().SearchForLyrics();
                
            // browser.Navigate(defaultUrl);
        }
        private void destroyLyricsPanel()
        {
            this.Size = new Size(this.Size.Width-lyricsPanel.Size.Width, this.Size.Height);
            lyricsOn = false;
            lyricsPanel.Controls.Remove(browser);
            browser.Stop();
            browser.Dispose();
            browser = null;
            this.Controls.Remove(lyricsPanel);
            lyricsPanel.Dispose();
            lyricsPanel = null;
        }

        private void allSongsFromLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediaPlayer.viewAllSongsFromLibrary();
            
        }

      

    }
}
