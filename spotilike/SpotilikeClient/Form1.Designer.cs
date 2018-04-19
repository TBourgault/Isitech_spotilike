namespace SpotilikeClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trierParToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musiqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.artisteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list_panel = new System.Windows.Forms.Panel();
            this.play_panel = new System.Windows.Forms.Panel();
            this.BTNPlay = new System.Windows.Forms.Button();
            this.BTNStop = new System.Windows.Forms.Button();
            this.BTNBack = new System.Windows.Forms.Button();
            this.BTNNext = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.play_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trierParToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.aboutToolStripMenuItem.Text = "Bibliothèque";
            // 
            // trierParToolStripMenuItem
            // 
            this.trierParToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musiqueToolStripMenuItem,
            this.artisteToolStripMenuItem,
            this.styleToolStripMenuItem});
            this.trierParToolStripMenuItem.Name = "trierParToolStripMenuItem";
            this.trierParToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.trierParToolStripMenuItem.Text = "Trier par ...";
            // 
            // musiqueToolStripMenuItem
            // 
            this.musiqueToolStripMenuItem.Name = "musiqueToolStripMenuItem";
            this.musiqueToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.musiqueToolStripMenuItem.Text = "Musique";
            // 
            // artisteToolStripMenuItem
            // 
            this.artisteToolStripMenuItem.Name = "artisteToolStripMenuItem";
            this.artisteToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.artisteToolStripMenuItem.Text = "Artiste";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couleursToolStripMenuItem,
            this.ajouterToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // couleursToolStripMenuItem
            // 
            this.couleursToolStripMenuItem.Name = "couleursToolStripMenuItem";
            this.couleursToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.couleursToolStripMenuItem.Text = "Couleurs";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musiqueToolStripMenuItem1,
            this.artisteToolStripMenuItem1,
            this.genreToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.ajouterToolStripMenuItem.Text = "Ajouter ...";
            // 
            // musiqueToolStripMenuItem1
            // 
            this.musiqueToolStripMenuItem1.Name = "musiqueToolStripMenuItem1";
            this.musiqueToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.musiqueToolStripMenuItem1.Text = "Musique";
            // 
            // artisteToolStripMenuItem1
            // 
            this.artisteToolStripMenuItem1.Name = "artisteToolStripMenuItem1";
            this.artisteToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.artisteToolStripMenuItem1.Text = "Artiste";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // list_panel
            // 
            this.list_panel.Location = new System.Drawing.Point(12, 31);
            this.list_panel.Name = "list_panel";
            this.list_panel.Size = new System.Drawing.Size(715, 429);
            this.list_panel.TabIndex = 2;
            // 
            // play_panel
            // 
            this.play_panel.Controls.Add(this.BTNPlay);
            this.play_panel.Controls.Add(this.BTNStop);
            this.play_panel.Controls.Add(this.BTNBack);
            this.play_panel.Controls.Add(this.BTNNext);
            this.play_panel.Location = new System.Drawing.Point(733, 31);
            this.play_panel.Name = "play_panel";
            this.play_panel.Size = new System.Drawing.Size(237, 429);
            this.play_panel.TabIndex = 3;
            // 
            // BTNPlay
            // 
            this.BTNPlay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNPlay.Image = ((System.Drawing.Image)(resources.GetObject("BTNPlay.Image")));
            this.BTNPlay.Location = new System.Drawing.Point(23, 310);
            this.BTNPlay.Name = "BTNPlay";
            this.BTNPlay.Size = new System.Drawing.Size(59, 53);
            this.BTNPlay.TabIndex = 3;
            this.BTNPlay.UseVisualStyleBackColor = false;
            this.BTNPlay.Click += new System.EventHandler(this.BTNPlay_Click);
            // 
            // BTNStop
            // 
            this.BTNStop.Image = ((System.Drawing.Image)(resources.GetObject("BTNStop.Image")));
            this.BTNStop.Location = new System.Drawing.Point(148, 310);
            this.BTNStop.Name = "BTNStop";
            this.BTNStop.Size = new System.Drawing.Size(57, 53);
            this.BTNStop.TabIndex = 4;
            this.BTNStop.UseVisualStyleBackColor = true;
            this.BTNStop.Click += new System.EventHandler(this.BTNStop_Click);
            // 
            // BTNBack
            // 
            this.BTNBack.Image = ((System.Drawing.Image)(resources.GetObject("BTNBack.Image")));
            this.BTNBack.Location = new System.Drawing.Point(23, 369);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(59, 55);
            this.BTNBack.TabIndex = 1;
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // BTNNext
            // 
            this.BTNNext.Image = ((System.Drawing.Image)(resources.GetObject("BTNNext.Image")));
            this.BTNNext.Location = new System.Drawing.Point(148, 369);
            this.BTNNext.Name = "BTNNext";
            this.BTNNext.Size = new System.Drawing.Size(57, 56);
            this.BTNNext.TabIndex = 2;
            this.BTNNext.UseVisualStyleBackColor = true;
            this.BTNNext.Click += new System.EventHandler(this.BTNNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(982, 570);
            this.Controls.Add(this.play_panel);
            this.Controls.Add(this.list_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Spotilike";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.play_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trierParToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musiqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem artisteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn album;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewButtonColumn action;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel list_panel;
        private System.Windows.Forms.Panel play_panel;
        private System.Windows.Forms.Button BTNStop;
        private System.Windows.Forms.Button BTNPlay;
        private System.Windows.Forms.Button BTNNext;
        private System.Windows.Forms.Button BTNBack;
    }
}

