namespace deezer
{
    partial class Deezer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.btnArtistSearch = new System.Windows.Forms.Button();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.lbAlbums = new System.Windows.Forms.ListBox();
            this.btnAlbumSearch = new System.Windows.Forms.Button();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.lbTracks = new System.Windows.Forms.ListBox();
            this.btnTrackSearch = new System.Windows.Forms.Button();
            this.tbTrack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbArtist
            // 
            this.tbArtist.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbArtist.Location = new System.Drawing.Point(13, 12);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(432, 36);
            this.tbArtist.TabIndex = 0;
            // 
            // btnArtistSearch
            // 
            this.btnArtistSearch.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnArtistSearch.Location = new System.Drawing.Point(13, 54);
            this.btnArtistSearch.Name = "btnArtistSearch";
            this.btnArtistSearch.Size = new System.Drawing.Size(432, 42);
            this.btnArtistSearch.TabIndex = 1;
            this.btnArtistSearch.Text = "Найти исполнителя";
            this.btnArtistSearch.UseVisualStyleBackColor = true;
            this.btnArtistSearch.Click += new System.EventHandler(this.btnArtistSearch_Click);
            // 
            // lbArtists
            // 
            this.lbArtists.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.ItemHeight = 18;
            this.lbArtists.Location = new System.Drawing.Point(13, 102);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.Size = new System.Drawing.Size(432, 544);
            this.lbArtists.TabIndex = 2;
            // 
            // lbAlbums
            // 
            this.lbAlbums.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAlbums.FormattingEnabled = true;
            this.lbAlbums.ItemHeight = 18;
            this.lbAlbums.Location = new System.Drawing.Point(451, 102);
            this.lbAlbums.Name = "lbAlbums";
            this.lbAlbums.Size = new System.Drawing.Size(432, 544);
            this.lbAlbums.TabIndex = 5;
            // 
            // btnAlbumSearch
            // 
            this.btnAlbumSearch.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAlbumSearch.Location = new System.Drawing.Point(451, 54);
            this.btnAlbumSearch.Name = "btnAlbumSearch";
            this.btnAlbumSearch.Size = new System.Drawing.Size(432, 42);
            this.btnAlbumSearch.TabIndex = 4;
            this.btnAlbumSearch.Text = "Найти альбом";
            this.btnAlbumSearch.UseVisualStyleBackColor = true;
            this.btnAlbumSearch.Click += new System.EventHandler(this.btnAlbumSearch_Click);
            // 
            // tbAlbum
            // 
            this.tbAlbum.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAlbum.Location = new System.Drawing.Point(451, 12);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(432, 36);
            this.tbAlbum.TabIndex = 3;
            // 
            // lbTracks
            // 
            this.lbTracks.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTracks.FormattingEnabled = true;
            this.lbTracks.ItemHeight = 18;
            this.lbTracks.Location = new System.Drawing.Point(889, 102);
            this.lbTracks.Name = "lbTracks";
            this.lbTracks.Size = new System.Drawing.Size(432, 544);
            this.lbTracks.TabIndex = 8;
            // 
            // btnTrackSearch
            // 
            this.btnTrackSearch.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrackSearch.Location = new System.Drawing.Point(889, 54);
            this.btnTrackSearch.Name = "btnTrackSearch";
            this.btnTrackSearch.Size = new System.Drawing.Size(432, 42);
            this.btnTrackSearch.TabIndex = 7;
            this.btnTrackSearch.Text = "Найти песню";
            this.btnTrackSearch.UseVisualStyleBackColor = true;
            this.btnTrackSearch.Click += new System.EventHandler(this.btnTrackSearch_Click);
            // 
            // tbTrack
            // 
            this.tbTrack.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTrack.Location = new System.Drawing.Point(889, 12);
            this.tbTrack.Name = "tbTrack";
            this.tbTrack.Size = new System.Drawing.Size(432, 36);
            this.tbTrack.TabIndex = 6;
            // 
            // Deezer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 668);
            this.Controls.Add(this.lbTracks);
            this.Controls.Add(this.btnTrackSearch);
            this.Controls.Add(this.tbTrack);
            this.Controls.Add(this.lbAlbums);
            this.Controls.Add(this.btnAlbumSearch);
            this.Controls.Add(this.tbAlbum);
            this.Controls.Add(this.lbArtists);
            this.Controls.Add(this.btnArtistSearch);
            this.Controls.Add(this.tbArtist);
            this.Name = "Deezer";
            this.Text = "Deezer Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.Button btnArtistSearch;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.ListBox lbAlbums;
        private System.Windows.Forms.Button btnAlbumSearch;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.ListBox lbTracks;
        private System.Windows.Forms.Button btnTrackSearch;
        private System.Windows.Forms.TextBox tbTrack;
    }
}

