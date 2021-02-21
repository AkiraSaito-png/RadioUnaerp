
namespace UI
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tilePodcast = new MetroFramework.Controls.MetroTile();
            this.tileProgramas = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = global::SimpleProgram.Properties.Resources.user;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleProgram.Properties.Resources.radiologo1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTile1, "metroTile1");
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.TileImage = global::SimpleProgram.Properties.Resources.relatorio;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // tilePodcast
            // 
            this.tilePodcast.ActiveControl = null;
            this.tilePodcast.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.tilePodcast, "tilePodcast");
            this.tilePodcast.Name = "tilePodcast";
            this.tilePodcast.TileImage = global::SimpleProgram.Properties.Resources.microphone;
            this.tilePodcast.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePodcast.UseSelectable = true;
            this.tilePodcast.UseTileImage = true;
            // 
            // tileProgramas
            // 
            this.tileProgramas.ActiveControl = null;
            this.tileProgramas.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.tileProgramas, "tileProgramas");
            this.tileProgramas.Name = "tileProgramas";
            this.tileProgramas.TileImage = global::SimpleProgram.Properties.Resources.icons8_collaboration_64__1_;
            this.tileProgramas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileProgramas.UseSelectable = true;
            this.tileProgramas.UseTileImage = true;
            this.tileProgramas.Click += new System.EventHandler(this.tileProgramas_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTile2, "metroTile2");
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.TileImage = global::SimpleProgram.Properties.Resources.play;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // FrmMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.tilePodcast);
            this.Controls.Add(this.tileProgramas);
            this.Name = "FrmMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileProgramas;
        private MetroFramework.Controls.MetroTile tilePodcast;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}

