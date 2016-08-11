using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AxWMPLib;
using System.Windows.Forms;

namespace Bogatinovski_Player
{
    class MediaStateHandler
    {
        private Player player;
        private Form2 form;
        private Timer timer;

        public MediaStateHandler(Player player)
        {
            setPlayer(player);
            this.form = player.getForm();
            this.initializeTimer();
        }

        private void initializeTimer()
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(Timer_Tick);
        }


        private void setPlayer(Player value)
        {
            this.player = value;
        }

        public void HandleMediaState()
        {
            timer.Start();   
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DoTheJob();
            timer.Stop();
        }

        private void DoTheJob()
        {
           
            switch(player.getMediaState())
            {
                case MediaState.Normal:
                    ManageNormalState();
                    break;
                case MediaState.Repeat:
                    ManageRepeatState();
                    break;
                case MediaState.Shuffle:
                    ManageShuffleState();
                    break;
            }
            
        }

        private void ManageShuffleState()
        {
            int index = new Random().Next(form.NowPlayingListBox.Items.Count);
            player.setCurrentSong((Song)form.NowPlayingListBox.Items[index]);
            player.PlaySong();
        }

        private void ManageRepeatState()
        {
            if (player.getCurrentSong() != null)
                player.PlaySong();
        }

        private void ManageNormalState()
        {
            NextSong();
        }

        public void NextSong()
        {
            if (player.getCurrentSong() == null)
                return;

            ListBox listBox = form.NowPlayingListBox;

            if (listBox.Items.IndexOf(player.getCurrentSong()) == listBox.Items.Count - 1)
                player.setCurrentSong((Song)listBox.Items[0]);
            else
                player.setCurrentSong((Song)listBox.Items[listBox.Items.IndexOf(player.getCurrentSong())+1]);
            player.PlaySong();
        }

       public void PreviousSong()
        {
            if (player.getCurrentSong() == null)
                return;

            ListBox listBox = form.NowPlayingListBox;
           
           if (listBox.Items.IndexOf(player.getCurrentSong())==0)
                player.setCurrentSong((Song)listBox.Items[listBox.Items.Count - 1]);
            else player.setCurrentSong((Song)listBox.Items[listBox.Items.IndexOf(player.getCurrentSong()) - 1]);
            player.PlaySong();
        }
    }
}
