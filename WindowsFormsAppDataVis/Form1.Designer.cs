namespace WindowsFormsAppDataVis
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.recordInfos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxMinColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaxColor = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(32, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // recordInfos
            // 
            this.recordInfos.Location = new System.Drawing.Point(257, 24);
            this.recordInfos.Name = "recordInfos";
            this.recordInfos.Size = new System.Drawing.Size(453, 22);
            this.recordInfos.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(56, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.Location = new System.Drawing.Point(684, 144);
            this.trackBarAlpha.Maximum = 255;
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(104, 56);
            this.trackBarAlpha.TabIndex = 3;
            this.trackBarAlpha.Value = 127;
            this.trackBarAlpha.Scroll += new System.EventHandler(this.trackBarAlpha_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(684, 235);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "alpha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "red";
            // 
            // pictureBoxMinColor
            // 
            this.pictureBoxMinColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBoxMinColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMinColor.Location = new System.Drawing.Point(645, 312);
            this.pictureBoxMinColor.Name = "pictureBoxMinColor";
            this.pictureBoxMinColor.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxMinColor.TabIndex = 8;
            this.pictureBoxMinColor.TabStop = false;
            this.pictureBoxMinColor.Click += new System.EventHandler(this.pictureBoxMinColor_Click);
            // 
            // pictureBoxMaxColor
            // 
            this.pictureBoxMaxColor.BackColor = System.Drawing.Color.Red;
            this.pictureBoxMaxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMaxColor.Location = new System.Drawing.Point(720, 312);
            this.pictureBoxMaxColor.Name = "pictureBoxMaxColor";
            this.pictureBoxMaxColor.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxMaxColor.TabIndex = 9;
            this.pictureBoxMaxColor.TabStop = false;
            this.pictureBoxMaxColor.Click += new System.EventHandler(this.pictureBoxMaxColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 627);
            this.Controls.Add(this.pictureBoxMaxColor);
            this.Controls.Add(this.pictureBoxMinColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.trackBarAlpha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.recordInfos);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox recordInfos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarAlpha;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxMinColor;
        private System.Windows.Forms.PictureBox pictureBoxMaxColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

