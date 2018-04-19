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

namespace SpotilikeClient
{
    public partial class Form1 : Form
    {
        private SoundPlayer simpleSound = new SoundPlayer();
        private string[] musics = new string[5];
        private int key_music_played = 0;
        //C:\Users\abt\Desktop\Isitech_spotilike\spotilike\SpotilikeClient\Resources\VALDMDR.wav", @"C:\Users\abt\Desktop\Isitech_spotilike\spotilike\SpotilikeClient\Resources\Fusil.wav", @"C:\Users\abt\Desktop\Isitech_spotilike\spotilike\SpotilikeClient\Resources\DuaLupa.wav", @"C:\Users\abt\Desktop\Isitech_spotilike\spotilike\SpotilikeClient\

        string path = Application.ExecutablePath;

        public Form1()
        {
            InitializeComponent();
            generateHeader();
            generatePlayer_layout();
            

            path = Directory.GetParent(path).ToString();
            path = Directory.GetParent(path).ToString();
            path = Directory.GetParent(path).ToString();
            path = path + "\\Resources\\";

            musics[0] = path + "BattleRoyal.wav";
            musics[1] = path + "VALDMDR.wav";
            musics[2] = path + "LikeIDo.wav";
            musics[3] = path + "Fusil.wav";
            musics[4] = path + "DuaLupa.wav";

            System.Console.WriteLine(musics[0]);


            //Button play1 = new Button();
            //this.dataGridView1.Rows.Add("a", "b");




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void generateHeader()
        {
            Label label_title = new Label();
            label_title.Text = "Titre";
            label_title.Width = 100;
            label_title.Location = new Point(0, 0);

            Label label_album = new Label();
            label_album.Text = "Album";
            label_album.Width = 100;
            label_album.Location = new Point(100, 0);

            Label label_artiste = new Label();
            label_artiste.Text = "Artiste";
            label_artiste.Width = 100;
            label_artiste.Location = new Point(200, 0);

            Label label_duration = new Label();
            label_duration.Text = "Durée";
            label_duration.Width = 100;
            label_duration.Location = new Point(300, 0);

            Label label_action = new Label();
            label_action.Text = "Action";
            label_action.Width = 100;
            label_action.Location = new Point(400, 0);

            this.list_panel.Controls.Add(label_title);
            this.list_panel.Controls.Add(label_album);
            this.list_panel.Controls.Add(label_artiste);
            this.list_panel.Controls.Add(label_duration);
            this.list_panel.Controls.Add(label_action);
        }


        private void generatePlayer_layout()
        {
            Label title = new Label();
            title.Text = "Lecture";
            this.play_panel.Controls.Add(BTNNext);
            this.play_panel.Controls.Add(BTNStop);
            this.play_panel.Controls.Add(BTNPlay);
            this.play_panel.Controls.Add(BTNBack);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.simpleSound.Tag.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNPlay_Click(object sender, EventArgs e)
        {
            // SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\abt\Desktop\Isitech_spotilike\spotilike\SpotilikeClient\Resources\LikeIDo.wav");
            // Générer un random int de la taille du tableau
            this.key_music_played = generateRandom();
            this.simpleSound.SoundLocation = musics[key_music_played];
            this.simpleSound.Play();

            //SoundPlayer player = new SoundPlayer("C:\\bass.wav");

        }

        private void BTNStop_Click(object sender, EventArgs e)
        {
            this.simpleSound.Stop();
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.key_music_played = ((this.key_music_played - 1) < 0) ? (this.key_music_played + this.musics.Length) - 1 : this.key_music_played-1;
            this.simpleSound.SoundLocation = musics[this.key_music_played];
            this.simpleSound.Play();
        }

        private void BTNNext_Click(object sender, EventArgs e)
        {
            this.key_music_played = ((this.key_music_played + 1) > this.musics.Length - 1) ? (this.key_music_played - this.musics.Length) + 1 : this.key_music_played + 1;
            this.simpleSound.SoundLocation = musics[this.key_music_played];
            this.simpleSound.Play();

        }

        private int generateRandom()
        {
            Random aleatoire = new Random();
            int tailleArray = this.musics.Length;
            int randomKey = aleatoire.Next(tailleArray-1);
           
            return randomKey;
        }
    }
}
