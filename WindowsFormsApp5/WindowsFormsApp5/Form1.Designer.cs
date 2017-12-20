namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çizimKalınlığıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kenarYakalamaMesafesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.ızgaraBoyutuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.çizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzÇizgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yakalamaNoktalarınıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kenarYakalamayıAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orthoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 434);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.çizToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.açToolStripMenuItem,
            this.çıkToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.açToolStripMenuItem.Text = "Aç";
            // 
            // çıkToolStripMenuItem
            // 
            this.çıkToolStripMenuItem.Name = "çıkToolStripMenuItem";
            this.çıkToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.çıkToolStripMenuItem.Text = "Çık";
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çizimKalınlığıToolStripMenuItem,
            this.renkToolStripMenuItem,
            this.kenarYakalamaMesafesiToolStripMenuItem,
            this.ızgaraBoyutuToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.düzenleToolStripMenuItem.Text = "Düzen";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // çizimKalınlığıToolStripMenuItem
            // 
            this.çizimKalınlığıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.çizimKalınlığıToolStripMenuItem.Name = "çizimKalınlığıToolStripMenuItem";
            this.çizimKalınlığıToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.çizimKalınlığıToolStripMenuItem.Text = "Çizim Kalınlığı";
            this.çizimKalınlığıToolStripMenuItem.Click += new System.EventHandler(this.çizimKalınlığıToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "2";
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.renkToolStripMenuItem.Text = "Renk";
            this.renkToolStripMenuItem.Click += new System.EventHandler(this.renkToolStripMenuItem_Click);
            // 
            // kenarYakalamaMesafesiToolStripMenuItem
            // 
            this.kenarYakalamaMesafesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.kenarYakalamaMesafesiToolStripMenuItem.Name = "kenarYakalamaMesafesiToolStripMenuItem";
            this.kenarYakalamaMesafesiToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.kenarYakalamaMesafesiToolStripMenuItem.Text = "Kenar yakalama mesafesi";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
            // 
            // ızgaraBoyutuToolStripMenuItem
            // 
            this.ızgaraBoyutuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
            this.ızgaraBoyutuToolStripMenuItem.Name = "ızgaraBoyutuToolStripMenuItem";
            this.ızgaraBoyutuToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ızgaraBoyutuToolStripMenuItem.Text = "Izgara Boyutu";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox3.TextChanged += new System.EventHandler(this.toolStripTextBox3_TextChanged);
            // 
            // çizToolStripMenuItem
            // 
            this.çizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzÇizgiToolStripMenuItem,
            this.kareToolStripMenuItem,
            this.daireToolStripMenuItem,
            this.elipsToolStripMenuItem});
            this.çizToolStripMenuItem.Name = "çizToolStripMenuItem";
            this.çizToolStripMenuItem.Size = new System.Drawing.Size(41, 24);
            this.çizToolStripMenuItem.Text = "Çiz";
            // 
            // düzÇizgiToolStripMenuItem
            // 
            this.düzÇizgiToolStripMenuItem.Checked = true;
            this.düzÇizgiToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.düzÇizgiToolStripMenuItem.Name = "düzÇizgiToolStripMenuItem";
            this.düzÇizgiToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.düzÇizgiToolStripMenuItem.Text = "Düz Çizgi";
            this.düzÇizgiToolStripMenuItem.Click += new System.EventHandler(this.düzÇizgiToolStripMenuItem_Click);
            // 
            // kareToolStripMenuItem
            // 
            this.kareToolStripMenuItem.Name = "kareToolStripMenuItem";
            this.kareToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.kareToolStripMenuItem.Text = "Kare";
            // 
            // daireToolStripMenuItem
            // 
            this.daireToolStripMenuItem.Name = "daireToolStripMenuItem";
            this.daireToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.daireToolStripMenuItem.Text = "Daire";
            // 
            // elipsToolStripMenuItem
            // 
            this.elipsToolStripMenuItem.Name = "elipsToolStripMenuItem";
            this.elipsToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.elipsToolStripMenuItem.Text = "Elips";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yakalamaNoktalarınıGösterToolStripMenuItem,
            this.kenarYakalamayıAçToolStripMenuItem,
            this.orthoToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // yakalamaNoktalarınıGösterToolStripMenuItem
            // 
            this.yakalamaNoktalarınıGösterToolStripMenuItem.Checked = true;
            this.yakalamaNoktalarınıGösterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yakalamaNoktalarınıGösterToolStripMenuItem.Name = "yakalamaNoktalarınıGösterToolStripMenuItem";
            this.yakalamaNoktalarınıGösterToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.yakalamaNoktalarınıGösterToolStripMenuItem.Text = "Yakalama noktalarını göster";
            this.yakalamaNoktalarınıGösterToolStripMenuItem.Click += new System.EventHandler(this.yakalamaNoktalarınıGösterToolStripMenuItem_Click);
            // 
            // kenarYakalamayıAçToolStripMenuItem
            // 
            this.kenarYakalamayıAçToolStripMenuItem.Name = "kenarYakalamayıAçToolStripMenuItem";
            this.kenarYakalamayıAçToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.kenarYakalamayıAçToolStripMenuItem.Text = "Kenar yakalamayı aç";
            this.kenarYakalamayıAçToolStripMenuItem.Click += new System.EventHandler(this.kenarYakalamayıAçToolStripMenuItem_Click);
            // 
            // orthoToolStripMenuItem
            // 
            this.orthoToolStripMenuItem.Name = "orthoToolStripMenuItem";
            this.orthoToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.orthoToolStripMenuItem.Text = "Ortho";
            this.orthoToolStripMenuItem.Click += new System.EventHandler(this.orthoToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(1006, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1052, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CAD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzÇizgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çizimKalınlığıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem yakalamaNoktalarınıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kenarYakalamayıAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orthoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem kenarYakalamaMesafesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem ızgaraBoyutuToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
    }
}

