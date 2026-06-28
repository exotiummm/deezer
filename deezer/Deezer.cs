using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string query = tbArtist.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Введите имя исполнителя / название группы!");
            }
            else
            {
                btnArtistSearch.Enabled = false;
                lbArtists.Items.Clear();

                try
                {
                    List<Models.Artist> artists = await _client.SearchArtistAsync(query);

                    if (artists.Count == 0)
                    {
                        lbArtists.Items.Add("Ничего не найдено");
                    }
                    else
                    {
                        foreach (var artist in artists)
                        {
                            lbArtists.Items.Add($"{artist.Name}, фанатов: {artist.Fans}");
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
    }
}
