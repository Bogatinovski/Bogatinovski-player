namespace Bogatinovski_Player
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.PlaylistsListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizationOnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.goToNowPlayingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goToLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stupidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NowPlayingListBox = new System.Windows.Forms.ListBox();
            this.LibraryListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zdcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFullPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSongFromPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.playSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTimerOn = new System.Windows.Forms.Timer(this.components);
            this.SearchTimerOff = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.displaySongTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.delayTimer1 = new System.Windows.Forms.Timer(this.components);
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.visualizationTimer = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.allSongsFromLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.Menu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaylistsListBox
            // 
            this.PlaylistsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PlaylistsListBox.ContextMenuStrip = this.contextMenuStrip2;
            this.PlaylistsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PlaylistsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistsListBox.ForeColor = System.Drawing.Color.White;
            this.PlaylistsListBox.FormattingEnabled = true;
            this.PlaylistsListBox.HorizontalScrollbar = true;
            this.PlaylistsListBox.ItemHeight = 18;
            this.PlaylistsListBox.Location = new System.Drawing.Point(0, 0);
            this.PlaylistsListBox.MaximumSize = new System.Drawing.Size(2000, 400);
            this.PlaylistsListBox.Name = "PlaylistsListBox";
            this.PlaylistsListBox.Size = new System.Drawing.Size(177, 400);
            this.PlaylistsListBox.TabIndex = 6;
            this.PlaylistsListBox.Click += new System.EventHandler(this.PlaylistsListBox_Click);
            this.PlaylistsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.PlaylistsListBox.SelectedIndexChanged += new System.EventHandler(this.PlaylistsListBox_SelectedIndexChanged);
            this.PlaylistsListBox.DoubleClick += new System.EventHandler(this.PlaylistsListBox_DoubleClick);
            this.PlaylistsListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.addFilesToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(121, 70);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.addFilesToolStripMenuItem.Text = "Add files";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.BackgroundImage = global::Bogatinovski_Player.Properties.Resources.menu;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.Gold;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryToolStripMenuItem,
            this.libraryToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(484, 25);
            this.Menu.TabIndex = 22;
            this.Menu.Text = "menuStrip1";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.visualizationOnOffToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.libraryToolStripMenuItem.Text = "Player";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dockToolStripMenuItem,
            this.autoHideToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItem2.Text = "Show Menu";
            // 
            // dockToolStripMenuItem
            // 
            this.dockToolStripMenuItem.Checked = true;
            this.dockToolStripMenuItem.CheckOnClick = true;
            this.dockToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dockToolStripMenuItem.Name = "dockToolStripMenuItem";
            this.dockToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.dockToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dockToolStripMenuItem.Text = "Dock";
            this.dockToolStripMenuItem.Click += new System.EventHandler(this.dockToolStripMenuItem_Click);
            // 
            // autoHideToolStripMenuItem
            // 
            this.autoHideToolStripMenuItem.CheckOnClick = true;
            this.autoHideToolStripMenuItem.Name = "autoHideToolStripMenuItem";
            this.autoHideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.autoHideToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.autoHideToolStripMenuItem.Text = "Auto Hide";
            this.autoHideToolStripMenuItem.Click += new System.EventHandler(this.autoHideToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItem4.Text = "Playlists On/Off";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItem5.Text = "Search Toolbar";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Checked = true;
            this.onToolStripMenuItem.CheckOnClick = true;
            this.onToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.CheckOnClick = true;
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // visualizationOnOffToolStripMenuItem
            // 
            this.visualizationOnOffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem3,
            this.offToolStripMenuItem3});
            this.visualizationOnOffToolStripMenuItem.Name = "visualizationOnOffToolStripMenuItem";
            this.visualizationOnOffToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.visualizationOnOffToolStripMenuItem.Text = "Visualizations";
            // 
            // onToolStripMenuItem3
            // 
            this.onToolStripMenuItem3.CheckOnClick = true;
            this.onToolStripMenuItem3.Name = "onToolStripMenuItem3";
            this.onToolStripMenuItem3.Size = new System.Drawing.Size(96, 22);
            this.onToolStripMenuItem3.Text = "On";
            this.onToolStripMenuItem3.Click += new System.EventHandler(this.onToolStripMenuItem3_Click);
            // 
            // offToolStripMenuItem3
            // 
            this.offToolStripMenuItem3.Checked = true;
            this.offToolStripMenuItem3.CheckOnClick = true;
            this.offToolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offToolStripMenuItem3.Name = "offToolStripMenuItem3";
            this.offToolStripMenuItem3.Size = new System.Drawing.Size(96, 22);
            this.offToolStripMenuItem3.Text = "Off";
            this.offToolStripMenuItem3.Click += new System.EventHandler(this.offToolStripMenuItem3_Click);
            // 
            // libraryToolStripMenuItem1
            // 
            this.libraryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPlaylistToolStripMenuItem,
            this.shuffleToolStripMenuItem,
            this.repeatToolStripMenuItem2,
            this.goToNowPlayingToolStripMenuItem1,
            this.goToLibraryToolStripMenuItem,
            this.allSongsFromLibraryToolStripMenuItem});
            this.libraryToolStripMenuItem1.Name = "libraryToolStripMenuItem1";
            this.libraryToolStripMenuItem1.Size = new System.Drawing.Size(64, 21);
            this.libraryToolStripMenuItem1.Text = "Library";
            // 
            // createPlaylistToolStripMenuItem
            // 
            this.createPlaylistToolStripMenuItem.Name = "createPlaylistToolStripMenuItem";
            this.createPlaylistToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.createPlaylistToolStripMenuItem.Text = "Create new playlist";
            this.createPlaylistToolStripMenuItem.Click += new System.EventHandler(this.createPlaylistToolStripMenuItem_Click);
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem2,
            this.offToolStripMenuItem2});
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.shuffleToolStripMenuItem.Text = "Shuffle";
            // 
            // onToolStripMenuItem2
            // 
            this.onToolStripMenuItem2.CheckOnClick = true;
            this.onToolStripMenuItem2.Name = "onToolStripMenuItem2";
            this.onToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.onToolStripMenuItem2.Text = "On";
            this.onToolStripMenuItem2.Click += new System.EventHandler(this.onToolStripMenuItem2_Click);
            // 
            // offToolStripMenuItem2
            // 
            this.offToolStripMenuItem2.Checked = true;
            this.offToolStripMenuItem2.CheckOnClick = true;
            this.offToolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offToolStripMenuItem2.Name = "offToolStripMenuItem2";
            this.offToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.offToolStripMenuItem2.Text = "Off";
            this.offToolStripMenuItem2.Click += new System.EventHandler(this.offToolStripMenuItem2_Click);
            // 
            // repeatToolStripMenuItem2
            // 
            this.repeatToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem5,
            this.offToolStripMenuItem5});
            this.repeatToolStripMenuItem2.Name = "repeatToolStripMenuItem2";
            this.repeatToolStripMenuItem2.Size = new System.Drawing.Size(212, 22);
            this.repeatToolStripMenuItem2.Text = "Repeat";
            // 
            // onToolStripMenuItem5
            // 
            this.onToolStripMenuItem5.CheckOnClick = true;
            this.onToolStripMenuItem5.Name = "onToolStripMenuItem5";
            this.onToolStripMenuItem5.Size = new System.Drawing.Size(96, 22);
            this.onToolStripMenuItem5.Text = "On";
            this.onToolStripMenuItem5.Click += new System.EventHandler(this.onToolStripMenuItem5_Click);
            // 
            // offToolStripMenuItem5
            // 
            this.offToolStripMenuItem5.Checked = true;
            this.offToolStripMenuItem5.CheckOnClick = true;
            this.offToolStripMenuItem5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offToolStripMenuItem5.Name = "offToolStripMenuItem5";
            this.offToolStripMenuItem5.Size = new System.Drawing.Size(96, 22);
            this.offToolStripMenuItem5.Text = "Off";
            this.offToolStripMenuItem5.Click += new System.EventHandler(this.offToolStripMenuItem5_Click);
            // 
            // goToNowPlayingToolStripMenuItem1
            // 
            this.goToNowPlayingToolStripMenuItem1.Name = "goToNowPlayingToolStripMenuItem1";
            this.goToNowPlayingToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.goToNowPlayingToolStripMenuItem1.Text = "Go to now playing";
            this.goToNowPlayingToolStripMenuItem1.Click += new System.EventHandler(this.goToNowPlayingToolStripMenuItem1_Click);
            // 
            // goToLibraryToolStripMenuItem
            // 
            this.goToLibraryToolStripMenuItem.Name = "goToLibraryToolStripMenuItem";
            this.goToLibraryToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.goToLibraryToolStripMenuItem.Text = "Go to library";
            this.goToLibraryToolStripMenuItem.Click += new System.EventHandler(this.goToLibraryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internalToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.helpToolStripMenuItem.Text = "Lyrics";
            // 
            // internalToolStripMenuItem
            // 
            this.internalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smartToolStripMenuItem,
            this.stupidToolStripMenuItem});
            this.internalToolStripMenuItem.Name = "internalToolStripMenuItem";
            this.internalToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.internalToolStripMenuItem.Text = "Internal";
            // 
            // smartToolStripMenuItem
            // 
            this.smartToolStripMenuItem.Name = "smartToolStripMenuItem";
            this.smartToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.smartToolStripMenuItem.Text = "Smart";
            this.smartToolStripMenuItem.Click += new System.EventHandler(this.smartToolStripMenuItem_Click);
            // 
            // stupidToolStripMenuItem
            // 
            this.stupidToolStripMenuItem.Name = "stupidToolStripMenuItem";
            this.stupidToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.stupidToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.stupidToolStripMenuItem.Text = "Stupid";
            this.stupidToolStripMenuItem.Click += new System.EventHandler(this.stupidToolStripMenuItem_Click);
            // 
            // NowPlayingListBox
            // 
            this.NowPlayingListBox.BackColor = System.Drawing.Color.Black;
            this.NowPlayingListBox.ContextMenuStrip = this.contextMenuStrip2;
            this.NowPlayingListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NowPlayingListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NowPlayingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.NowPlayingListBox.ForeColor = System.Drawing.Color.White;
            this.NowPlayingListBox.FormattingEnabled = true;
            this.NowPlayingListBox.HorizontalScrollbar = true;
            this.NowPlayingListBox.ItemHeight = 18;
            this.NowPlayingListBox.Location = new System.Drawing.Point(173, 0);
            this.NowPlayingListBox.Name = "NowPlayingListBox";
            this.NowPlayingListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.NowPlayingListBox.Size = new System.Drawing.Size(224, 400);
            this.NowPlayingListBox.TabIndex = 3;
            this.NowPlayingListBox.Click += new System.EventHandler(this.NowPlayingListBox_Click);
            this.NowPlayingListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.NowPlayingListBox.DoubleClick += new System.EventHandler(this.NowPlayingListBox_DoubleClick);
            this.NowPlayingListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlaylistListBox_MouseMove);
            this.NowPlayingListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlaylistListBox_MouseUp);
            // 
            // LibraryListBox
            // 
            this.LibraryListBox.BackColor = System.Drawing.Color.Black;
            this.LibraryListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.LibraryListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LibraryListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LibraryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LibraryListBox.ForeColor = System.Drawing.Color.White;
            this.LibraryListBox.FormattingEnabled = true;
            this.LibraryListBox.HorizontalScrollbar = true;
            this.LibraryListBox.ItemHeight = 18;
            this.LibraryListBox.Location = new System.Drawing.Point(173, -6);
            this.LibraryListBox.MaximumSize = new System.Drawing.Size(2000, 400);
            this.LibraryListBox.Name = "LibraryListBox";
            this.LibraryListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LibraryListBox.Size = new System.Drawing.Size(224, 400);
            this.LibraryListBox.TabIndex = 25;
            this.LibraryListBox.Click += new System.EventHandler(this.LibraryListBox_Click);
            this.LibraryListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.LibraryListBox.DoubleClick += new System.EventHandler(this.LibraryListBox_DoubleClick);
            this.LibraryListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseMove);
            this.LibraryListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.LightYellow;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zdcToolStripMenuItem,
            this.viewFullPathToolStripMenuItem,
            this.deleteSongFromPlaylistToolStripMenuItem,
            this.repeatToolStripMenuItem,
            this.repeatToolStripMenuItem1,
            this.shuffleToolStripMenuItem1,
            this.playSelectionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 158);
            // 
            // zdcToolStripMenuItem
            // 
            this.zdcToolStripMenuItem.Name = "zdcToolStripMenuItem";
            this.zdcToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.zdcToolStripMenuItem.Text = "Open File Location";
            this.zdcToolStripMenuItem.Click += new System.EventHandler(this.zdcToolStripMenuItem_Click);
            // 
            // viewFullPathToolStripMenuItem
            // 
            this.viewFullPathToolStripMenuItem.Name = "viewFullPathToolStripMenuItem";
            this.viewFullPathToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.viewFullPathToolStripMenuItem.Text = "View Full Path";
            this.viewFullPathToolStripMenuItem.Click += new System.EventHandler(this.viewFullPathToolStripMenuItem_Click);
            // 
            // deleteSongFromPlaylistToolStripMenuItem
            // 
            this.deleteSongFromPlaylistToolStripMenuItem.Name = "deleteSongFromPlaylistToolStripMenuItem";
            this.deleteSongFromPlaylistToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.deleteSongFromPlaylistToolStripMenuItem.Text = "Delete Songs From Library";
            this.deleteSongFromPlaylistToolStripMenuItem.Click += new System.EventHandler(this.deleteSongFromPlaylistToolStripMenuItem_Click);
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.repeatToolStripMenuItem.Text = "Delete Songs From List";
            this.repeatToolStripMenuItem.Click += new System.EventHandler(this.repeatToolStripMenuItem_Click);
            // 
            // repeatToolStripMenuItem1
            // 
            this.repeatToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem1,
            this.offToolStripMenuItem1});
            this.repeatToolStripMenuItem1.Name = "repeatToolStripMenuItem1";
            this.repeatToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.repeatToolStripMenuItem1.Text = "Repeat";
            // 
            // onToolStripMenuItem1
            // 
            this.onToolStripMenuItem1.CheckOnClick = true;
            this.onToolStripMenuItem1.Name = "onToolStripMenuItem1";
            this.onToolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem1.Text = "On";
            this.onToolStripMenuItem1.Click += new System.EventHandler(this.onToolStripMenuItem1_Click);
            // 
            // offToolStripMenuItem1
            // 
            this.offToolStripMenuItem1.Checked = true;
            this.offToolStripMenuItem1.CheckOnClick = true;
            this.offToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offToolStripMenuItem1.Name = "offToolStripMenuItem1";
            this.offToolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem1.Text = "Off";
            this.offToolStripMenuItem1.Click += new System.EventHandler(this.offToolStripMenuItem1_Click);
            // 
            // shuffleToolStripMenuItem1
            // 
            this.shuffleToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem4,
            this.offToolStripMenuItem4});
            this.shuffleToolStripMenuItem1.Name = "shuffleToolStripMenuItem1";
            this.shuffleToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.shuffleToolStripMenuItem1.Text = "Shuffle";
            // 
            // onToolStripMenuItem4
            // 
            this.onToolStripMenuItem4.CheckOnClick = true;
            this.onToolStripMenuItem4.Name = "onToolStripMenuItem4";
            this.onToolStripMenuItem4.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem4.Text = "On";
            this.onToolStripMenuItem4.Click += new System.EventHandler(this.onToolStripMenuItem4_Click);
            // 
            // offToolStripMenuItem4
            // 
            this.offToolStripMenuItem4.Checked = true;
            this.offToolStripMenuItem4.CheckOnClick = true;
            this.offToolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offToolStripMenuItem4.Name = "offToolStripMenuItem4";
            this.offToolStripMenuItem4.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem4.Text = "Off";
            this.offToolStripMenuItem4.Click += new System.EventHandler(this.offToolStripMenuItem4_Click);
            // 
            // playSelectionToolStripMenuItem
            // 
            this.playSelectionToolStripMenuItem.Name = "playSelectionToolStripMenuItem";
            this.playSelectionToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.playSelectionToolStripMenuItem.Text = "Play Selection";
            this.playSelectionToolStripMenuItem.Click += new System.EventHandler(this.playSelectionToolStripMenuItem_Click);
            // 
            // SearchTimerOn
            // 
            this.SearchTimerOn.Interval = 1;
            this.SearchTimerOn.Tick += new System.EventHandler(this.SearchTimerOn_Tick);
            // 
            // SearchTimerOff
            // 
            this.SearchTimerOff.Interval = 1;
            this.SearchTimerOff.Tick += new System.EventHandler(this.SearchTimerOff_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Go to now playing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(219, 576);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 27;
            // 
            // displaySongTimer
            // 
            this.displaySongTimer.Interval = 120;
            this.displaySongTimer.Tick += new System.EventHandler(this.displaySongTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(323, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "00:00  \\";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 549);
            this.axWindowsMediaPlayer1.MinimumSize = new System.Drawing.Size(0, 62);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(484, 62);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.DoubleClickEvent += new AxWMPLib._WMPOCXEvents_DoubleClickEventHandler(this.axWindowsMediaPlayer1_DoubleClickEvent);
            // 
            // delayTimer1
            // 
            this.delayTimer1.Tick += new System.EventHandler(this.delayTimer1_Tick);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Black;
            this.infoPanel.BackgroundImage = global::Bogatinovski_Player.Properties.Resources.abstract723;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPanel.Controls.Add(this.label10);
            this.infoPanel.Controls.Add(this.label9);
            this.infoPanel.Controls.Add(this.label8);
            this.infoPanel.Controls.Add(this.label7);
            this.infoPanel.Controls.Add(this.label6);
            this.infoPanel.Controls.Add(this.label5);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Location = new System.Drawing.Point(0, 400);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(397, 124);
            this.infoPanel.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(181, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(181, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(181, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(181, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Selected song index:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Current playing song index:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Songs in  now playing:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Selected playlist songs:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.searchTextBox.ForeColor = System.Drawing.Color.Gray;
            this.searchTextBox.Location = new System.Drawing.Point(240, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(141, 20);
            this.searchTextBox.TabIndex = 35;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click_1);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // visualizationTimer
            // 
            this.visualizationTimer.Interval = 1;
            this.visualizationTimer.Tick += new System.EventHandler(this.visualizationTimer_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(370, 577);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "Off";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(84, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 22);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(58, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 22);
            this.button2.TabIndex = 38;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // allSongsFromLibraryToolStripMenuItem
            // 
            this.allSongsFromLibraryToolStripMenuItem.Name = "allSongsFromLibraryToolStripMenuItem";
            this.allSongsFromLibraryToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.allSongsFromLibraryToolStripMenuItem.Text = "All songs from library";
            this.allSongsFromLibraryToolStripMenuItem.Click += new System.EventHandler(this.allSongsFromLibraryToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.PlaylistsListBox);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.LibraryListBox);
            this.Controls.Add(this.NowPlayingListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(900, 10);
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(413, 650);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bogatinovski player";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form2_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form2_DragEnter);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.contextMenuStrip2.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public System.Windows.Forms.ListBox PlaylistsListBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ListBox NowPlayingListBox;
        public System.Windows.Forms.ListBox LibraryListBox;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.Timer SearchTimerOn;
        private System.Windows.Forms.Timer SearchTimerOff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zdcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFullPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSongFromPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Timer displaySongTimer;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Timer delayTimer1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.ToolStripMenuItem visualizationOnOffToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Timer visualizationTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem playSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToNowPlayingToolStripMenuItem1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem goToLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stupidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSongsFromLibraryToolStripMenuItem;
    }
}