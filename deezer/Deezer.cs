using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static deezer.Models;

namespace deezer
{
    public partial class Deezer : Form
    {
        public Deezer()
        {
            InitializeComponent();
        }

        private readonly Client _client = new Client();

        private async void btnArtistSearch_Click(object sender, EventArgs e)
        {
            string query = tbSearchBar.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Введите имя исполнителя / название группы!");
            }
            else
            {
                btnArtistSearch.Enabled = false;
                lbArtistsAlbums.Items.Clear();

                try
                {
                    List<Models.Artist> artists = await _client.SearchArtistAsync(query);

                    if (artists.Count == 0)
                    {
                        lbArtistsAlbums.Items.Add("Ничего не найдено");
                    }
                    else
                    {
                        foreach (var artist in artists)
                        {
                            lbArtistsAlbums.Items.Add(artist);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
                finally
                {
                    btnArtistSearch.Enabled = true;
                }
            }
        }

        private async void btnAlbumSearch_Click(object sender, EventArgs e)
        {
            string query = tbSearchBar.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Введите название альбома!");
            }
            else
            {
                btnAlbumSearch.Enabled = false;
                lbArtistsAlbums.Items.Clear();

                try
                {
                    List<Models.Album> albums = await _client.SearchAlbumAsync(query);

                    if (albums.Count == 0)
                    {
                        lbArtistsAlbums.Items.Add("Ничего не найдено");
                    }
                    else
                    {
                        foreach (var album in albums)
                        {
                            lbArtistsAlbums.Items.Add(album);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
                finally
                {
                    btnAlbumSearch.Enabled = true;
                }
            }
        }

        private async void btnTrackSearch_Click(object sender, EventArgs e)
        {
            string query = tbSearchBar.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Введите название песни!");
            }
            else
            {
                btnTrackSearch.Enabled = false;
                lbTracks.Items.Clear();

                try
                {
                    List<Models.Track> tracks = await _client.SearchTrackAsync(query);

                    if (tracks.Count == 0)
                    {
                        lbTracks.Items.Add("Ничего не найдено");
                    }
                    else
                    {
                        foreach (var track in tracks)
                        {
                            lbTracks.Items.Add(track);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
                finally
                {
                    btnTrackSearch.Enabled = true;
                }
            }
        }

        private void lbTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTracks.SelectedIndex < 0)
            {
                return;
            }

            Models.Track selectedTrack = (Models.Track)lbTracks.SelectedItem;

            if (!string.IsNullOrEmpty(selectedTrack.Preview))
            {
                webBrowserPreview.Url = new Uri(selectedTrack.Preview);
            }
            else
            {
                MessageBox.Show("У данной песни нет превью");
            }
        }

        private async void lbArtistsAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (lbArtistsAlbums.SelectedIndex < 0)
            {
                return;
            }

            lbTracks.Items.Clear();
            var selectedModel = lbArtistsAlbums.SelectedItem;
            
            if (selectedModel is Models.Album album)
            {
                try
                {
                    btnTrackSearch.Enabled = false;

                    List<Models.Track> tracks = await _client.LoadAlbumTracklist(album.Id);

                    if (tracks.Count == 0)
                    {
                        lbTracks.Items.Add("Ничего не найдено");
                    }
                    else
                    {
                        foreach (var track in tracks)
                        {
                            lbTracks.Items.Add(track);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
                finally
                {
                    btnTrackSearch.Enabled = true;
                }
            }
        }
    }
}
