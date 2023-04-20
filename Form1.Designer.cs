namespace TaikoDifficulty
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
            this.lvSongDiffs = new System.Windows.Forms.ListView();
            this.lvCol0 = new System.Windows.Forms.ColumnHeader();
            this.lvCol1 = new System.Windows.Forms.ColumnHeader();
            this.lvCol2 = new System.Windows.Forms.ColumnHeader();
            this.lvCol3 = new System.Windows.Forms.ColumnHeader();
            this.lvCol4 = new System.Windows.Forms.ColumnHeader();
            this.lvCol5 = new System.Windows.Forms.ColumnHeader();
            this.lvCol6 = new System.Windows.Forms.ColumnHeader();
            this.btGetSongs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSongDiffs
            // 
            this.lvSongDiffs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvCol0,
            this.lvCol1,
            this.lvCol2,
            this.lvCol3,
            this.lvCol4,
            this.lvCol5,
            this.lvCol6});
            this.lvSongDiffs.Location = new System.Drawing.Point(12, 12);
            this.lvSongDiffs.Name = "lvSongDiffs";
            this.lvSongDiffs.Size = new System.Drawing.Size(560, 466);
            this.lvSongDiffs.TabIndex = 0;
            this.lvSongDiffs.UseCompatibleStateImageBehavior = false;
            this.lvSongDiffs.View = System.Windows.Forms.View.Details;
            // 
            // lvCol0
            // 
            this.lvCol0.Text = "No";
            this.lvCol0.Width = 40;
            // 
            // lvCol1
            // 
            this.lvCol1.Text = "Song Name";
            this.lvCol1.Width = 230;
            // 
            // lvCol2
            // 
            this.lvCol2.Text = "Kantan";
            this.lvCol2.Width = 55;
            // 
            // lvCol3
            // 
            this.lvCol3.Text = "Hutsuu";
            this.lvCol3.Width = 55;
            // 
            // lvCol4
            // 
            this.lvCol4.Text = "Muzu";
            this.lvCol4.Width = 55;
            // 
            // lvCol5
            // 
            this.lvCol5.Text = "Oni";
            this.lvCol5.Width = 55;
            // 
            // lvCol6
            // 
            this.lvCol6.Text = "Ura";
            this.lvCol6.Width = 55;
            // 
            // btGetSongs
            // 
            this.btGetSongs.Location = new System.Drawing.Point(497, 484);
            this.btGetSongs.Name = "btGetSongs";
            this.btGetSongs.Size = new System.Drawing.Size(75, 23);
            this.btGetSongs.TabIndex = 1;
            this.btGetSongs.Text = "Get Songs";
            this.btGetSongs.UseVisualStyleBackColor = true;
            this.btGetSongs.Click += new System.EventHandler(this.btGetSongs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btGetSongs);
            this.Controls.Add(this.lvSongDiffs);
            this.Name = "Form1";
            this.Text = "TaikoDifficulty";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvSongDiffs;
        private ColumnHeader lvCol0;
        private ColumnHeader lvCol1;
        private ColumnHeader lvCol2;
        private ColumnHeader lvCol3;
        private ColumnHeader lvCol4;
        private ColumnHeader lvCol5;
        private ColumnHeader lvCol6;
        private Button btGetSongs;
    }
}