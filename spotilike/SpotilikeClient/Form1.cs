using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotilikeClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            generateHeader();
            generatePlayer_layout();

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

            Button play = new Button();
            play.Text = ">";
            this.play_panel.Controls.Add(play);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
