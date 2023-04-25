namespace _210601029_Simel_Yüksel_Ödev1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxBilgi = new System.Windows.Forms.GroupBox();
            this.maskedTxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.btnCalis = new System.Windows.Forms.Button();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.tabSonuc = new System.Windows.Forms.TabControl();
            this.tabTek = new System.Windows.Forms.TabPage();
            this.listViewTek = new System.Windows.Forms.ListView();
            this.tabCift = new System.Windows.Forms.TabPage();
            this.listViewCift = new System.Windows.Forms.ListView();
            this.tabAsal = new System.Windows.Forms.TabPage();
            this.listViewAsal = new System.Windows.Forms.ListView();
            this.tabMukemmel = new System.Windows.Forms.TabPage();
            this.listViewMukemmel = new System.Windows.Forms.ListView();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBoxBilgi.SuspendLayout();
            this.tabSonuc.SuspendLayout();
            this.tabTek.SuspendLayout();
            this.tabCift.SuspendLayout();
            this.tabAsal.SuspendLayout();
            this.tabMukemmel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBilgi
            // 
            this.groupBoxBilgi.Controls.Add(this.btnTemizle);
            this.groupBoxBilgi.Controls.Add(this.maskedTxtBaslangic);
            this.groupBoxBilgi.Controls.Add(this.maskedTxtBitis);
            this.groupBoxBilgi.Controls.Add(this.btnCalis);
            this.groupBoxBilgi.Controls.Add(this.lblBitis);
            this.groupBoxBilgi.Controls.Add(this.lblBaslangic);
            this.groupBoxBilgi.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBilgi.Name = "groupBoxBilgi";
            this.groupBoxBilgi.Size = new System.Drawing.Size(923, 139);
            this.groupBoxBilgi.TabIndex = 0;
            this.groupBoxBilgi.TabStop = false;
            this.groupBoxBilgi.Text = "Giriş Bilgileri";
            // 
            // maskedTxtBaslangic
            // 
            this.maskedTxtBaslangic.BeepOnError = true;
            this.maskedTxtBaslangic.Location = new System.Drawing.Point(115, 60);
            this.maskedTxtBaslangic.Mask = "0000";
            this.maskedTxtBaslangic.Name = "maskedTxtBaslangic";
            this.maskedTxtBaslangic.Size = new System.Drawing.Size(125, 27);
            this.maskedTxtBaslangic.TabIndex = 6;
            // 
            // maskedTxtBitis
            // 
            this.maskedTxtBitis.BeepOnError = true;
            this.maskedTxtBitis.Location = new System.Drawing.Point(424, 60);
            this.maskedTxtBitis.Mask = "0000";
            this.maskedTxtBitis.Name = "maskedTxtBitis";
            this.maskedTxtBitis.Size = new System.Drawing.Size(125, 27);
            this.maskedTxtBitis.TabIndex = 5;
            // 
            // btnCalis
            // 
            this.btnCalis.Location = new System.Drawing.Point(633, 59);
            this.btnCalis.Name = "btnCalis";
            this.btnCalis.Size = new System.Drawing.Size(94, 29);
            this.btnCalis.TabIndex = 4;
            this.btnCalis.Text = "Çalıştır";
            this.btnCalis.UseVisualStyleBackColor = true;
            this.btnCalis.Click += new System.EventHandler(this.btnCalis_Click);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(381, 63);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(37, 20);
            this.lblBitis.TabIndex = 1;
            this.lblBitis.Text = "Bitiş";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(37, 63);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(72, 20);
            this.lblBaslangic.TabIndex = 0;
            this.lblBaslangic.Text = "Başlangıç";
            // 
            // tabSonuc
            // 
            this.tabSonuc.Controls.Add(this.tabTek);
            this.tabSonuc.Controls.Add(this.tabCift);
            this.tabSonuc.Controls.Add(this.tabAsal);
            this.tabSonuc.Controls.Add(this.tabMukemmel);
            this.tabSonuc.Location = new System.Drawing.Point(12, 197);
            this.tabSonuc.Name = "tabSonuc";
            this.tabSonuc.SelectedIndex = 0;
            this.tabSonuc.Size = new System.Drawing.Size(923, 281);
            this.tabSonuc.TabIndex = 5;
            // 
            // tabTek
            // 
            this.tabTek.Controls.Add(this.listViewTek);
            this.tabTek.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabTek.Location = new System.Drawing.Point(4, 29);
            this.tabTek.Name = "tabTek";
            this.tabTek.Padding = new System.Windows.Forms.Padding(3);
            this.tabTek.Size = new System.Drawing.Size(915, 248);
            this.tabTek.TabIndex = 0;
            this.tabTek.Text = "Tek Sayılar";
            this.tabTek.UseVisualStyleBackColor = true;
            // 
            // listViewTek
            // 
            this.listViewTek.Location = new System.Drawing.Point(24, 21);
            this.listViewTek.Name = "listViewTek";
            this.listViewTek.Size = new System.Drawing.Size(864, 203);
            this.listViewTek.TabIndex = 0;
            this.listViewTek.UseCompatibleStateImageBehavior = false;
            // 
            // tabCift
            // 
            this.tabCift.Controls.Add(this.listViewCift);
            this.tabCift.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabCift.Location = new System.Drawing.Point(4, 29);
            this.tabCift.Name = "tabCift";
            this.tabCift.Padding = new System.Windows.Forms.Padding(3);
            this.tabCift.Size = new System.Drawing.Size(915, 248);
            this.tabCift.TabIndex = 1;
            this.tabCift.Text = "Çift Sayılar";
            this.tabCift.UseVisualStyleBackColor = true;
            // 
            // listViewCift
            // 
            this.listViewCift.Location = new System.Drawing.Point(23, 24);
            this.listViewCift.Name = "listViewCift";
            this.listViewCift.Size = new System.Drawing.Size(866, 202);
            this.listViewCift.TabIndex = 0;
            this.listViewCift.UseCompatibleStateImageBehavior = false;
            // 
            // tabAsal
            // 
            this.tabAsal.Controls.Add(this.listViewAsal);
            this.tabAsal.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabAsal.Location = new System.Drawing.Point(4, 29);
            this.tabAsal.Name = "tabAsal";
            this.tabAsal.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsal.Size = new System.Drawing.Size(915, 248);
            this.tabAsal.TabIndex = 2;
            this.tabAsal.Text = "Asal Sayılar";
            this.tabAsal.UseVisualStyleBackColor = true;
            // 
            // listViewAsal
            // 
            this.listViewAsal.Location = new System.Drawing.Point(23, 24);
            this.listViewAsal.Name = "listViewAsal";
            this.listViewAsal.Size = new System.Drawing.Size(868, 201);
            this.listViewAsal.TabIndex = 0;
            this.listViewAsal.UseCompatibleStateImageBehavior = false;
            // 
            // tabMukemmel
            // 
            this.tabMukemmel.Controls.Add(this.listViewMukemmel);
            this.tabMukemmel.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabMukemmel.Location = new System.Drawing.Point(4, 29);
            this.tabMukemmel.Name = "tabMukemmel";
            this.tabMukemmel.Padding = new System.Windows.Forms.Padding(3);
            this.tabMukemmel.Size = new System.Drawing.Size(915, 248);
            this.tabMukemmel.TabIndex = 3;
            this.tabMukemmel.Text = "Mükemmel Sayılar";
            this.tabMukemmel.UseVisualStyleBackColor = true;
            // 
            // listViewMukemmel
            // 
            this.listViewMukemmel.Location = new System.Drawing.Point(23, 24);
            this.listViewMukemmel.Name = "listViewMukemmel";
            this.listViewMukemmel.Size = new System.Drawing.Size(868, 200);
            this.listViewMukemmel.TabIndex = 0;
            this.listViewMukemmel.UseCompatibleStateImageBehavior = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(781, 59);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(94, 29);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 490);
            this.Controls.Add(this.tabSonuc);
            this.Controls.Add(this.groupBoxBilgi);
            this.Name = "Form1";
            this.Text = "Ödev1";
            this.groupBoxBilgi.ResumeLayout(false);
            this.groupBoxBilgi.PerformLayout();
            this.tabSonuc.ResumeLayout(false);
            this.tabTek.ResumeLayout(false);
            this.tabCift.ResumeLayout(false);
            this.tabAsal.ResumeLayout(false);
            this.tabMukemmel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxBilgi;
        private Button btnCalis;
        private Label lblBitis;
        private Label lblBaslangic;
        private TabControl tabSonuc;
        private TabPage tabTek;
        private ListView listViewTek;
        private TabPage tabCift;
        private ListView listViewCift;
        private TabPage tabAsal;
        private TabPage tabMukemmel;
        private ListView listViewAsal;
        private ListView listViewMukemmel;
        private MaskedTextBox maskedTxtBaslangic;
        private MaskedTextBox maskedTxtBitis;
        private NotifyIcon notifyIcon;
        private Button btnTemizle;
    }
}