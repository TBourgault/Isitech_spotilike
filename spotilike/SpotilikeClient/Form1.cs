using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using SpotilikeClient.DAO;
using SpotilikeClient.Models;

namespace SpotilikeClient
{
    public partial class Form1 : Form
    {
        private SoundPlayer simpleSound = new SoundPlayer();
        private string[] musics = new string[5];
        private int key_music_played = 0;

        string path = Application.ExecutablePath;
        private MusiqueDAO musiqueDAO = new MusiqueDAO();
        private AlbumDAO albumDAO = new AlbumDAO();
        private ArtisteDAO artisteDAO = new ArtisteDAO();
        private StyleDAO styleDAO = new StyleDAO();
        private List<Musique> titres = new List<Musique>();
        private static string[] titles = new string[5];

        public Form1()
        {
            InitializeComponent();
            generateHeader();
            generatePlayer_layout();
            this.titres = musiqueDAO.findAll();

            // générer les paths
            path = Directory.GetParent(path).ToString();
            path = Directory.GetParent(path).ToString();
            path = Directory.GetParent(path).ToString();
            path = path + "\\Resources\\";

            generateLine();
            foreach (Musique m in this.titres)
            {     
                musics[m.getId()] = path + m.getPath();
                titles[m.getId()] = m.getTitle();
            }
        }

        private void generateLine()
        {
            int i = 0;
            int j = 35;
            foreach (Musique m in titres)
            {

                this.list_panel.Controls.Add(new Label() { Text = m.getTitle(), Location = new Point(0, j) });
                this.list_panel.Controls.Add(new Label() { Text = m.getAlbum().getTitle(), Location = new Point(100, j) });
                this.list_panel.Controls.Add(new Label() { Text = m.getArtiste().getFullName("medium"), Location = new Point(200, j) });
                this.list_panel.Controls.Add(new Label() { Text = string.Format("{0:N2}", m.getAlbum().getDuration()), Location = new Point(300, j) });
                this.musics[i] = path + m.getPath();
                i++;
                j += 25;
            }
        }

        private void generateHeader()
        {
            Label label_title = new Label();
            label_title.Text = "Titre";
            label_title.Width = 100;
            label_title.Location = new Point(0, 10);
            label_title.Font = new Font(Label.DefaultFont, FontStyle.Bold);

            Label label_album = new Label();
            label_album.Text = "Album";
            label_album.Width = 100;
            label_album.Location = new Point(100, 10);
            label_album.Font = new Font(Label.DefaultFont, FontStyle.Bold);

            Label label_artiste = new Label();
            label_artiste.Text = "Artiste";
            label_artiste.Width = 100;
            label_artiste.Location = new Point(200, 10);
            label_artiste.Font = new Font(Label.DefaultFont, FontStyle.Bold);

            Label label_duration = new Label();
            label_duration.Text = "Durée";
            label_duration.Width = 100;
            label_duration.Location = new Point(300, 10);
            label_duration.Font = new Font(Label.DefaultFont, FontStyle.Bold);

            this.list_panel.Controls.Add(label_title);
            this.list_panel.Controls.Add(label_album);
            this.list_panel.Controls.Add(label_artiste);
            this.list_panel.Controls.Add(label_duration);
        }


        private void generatePlayer_layout()
        {
            this.play_panel.Controls.Add(BTNNext);
            this.play_panel.Controls.Add(BTNStop);
            this.play_panel.Controls.Add(BTNPlay);
            this.play_panel.Controls.Add(BTNBack);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.simpleSound.Tag.ToString());
        }

        private void BTNPlay_Click(object sender, EventArgs e)
        {
            this.key_music_played = generateRandom();
            this.lab_titre.Text = titles[key_music_played];
            this.simpleSound.SoundLocation = musics[key_music_played];
            this.simpleSound.Play();

        }

        private void BTNStop_Click(object sender, EventArgs e)
        {
            this.simpleSound.Stop();
            this.lab_titre.Text = "Aucun titre en cours de lecture";
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.key_music_played = ((this.key_music_played - 1) < 0) ? (this.key_music_played + this.musics.Length) - 1 : this.key_music_played - 1;
            this.simpleSound.SoundLocation = musics[this.key_music_played];
            this.lab_titre.Text = titles[key_music_played];
            this.simpleSound.Play();
        }

        private void BTNNext_Click(object sender, EventArgs e)
        {
            this.key_music_played = ((this.key_music_played + 1) > this.musics.Length - 1) ? (this.key_music_played - this.musics.Length) + 1 : this.key_music_played + 1;
            this.simpleSound.SoundLocation = musics[this.key_music_played];
            this.lab_titre.Text = titles[key_music_played];
            this.simpleSound.Play();

        }

        private int generateRandom()
        {
            Random aleatoire = new Random();
            int tailleArray = this.musics.Length;
            int randomKey = aleatoire.Next(tailleArray - 1);

            return randomKey;
        }
    }
}
