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
            // Deezer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 668);
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
    }
}

