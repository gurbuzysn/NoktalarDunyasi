namespace BosWFA
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
            duvar = new Panel();
            nudX = new NumericUpDown();
            label1 = new Label();
            nudY = new NumericUpDown();
            label2 = new Label();
            nudBoyut = new NumericUpDown();
            label3 = new Label();
            btnEkle = new Button();
            lstNokta = new ListBox();
            pboRenk = new PictureBox();
            label4 = new Label();
            colorDialog = new ColorDialog();
            trackBar1 = new TrackBar();
            btnBeniSasirt = new Button();
            ((System.ComponentModel.ISupportInitialize)nudX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBoyut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboRenk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // duvar
            // 
            duvar.BackColor = Color.White;
            duvar.Location = new Point(12, 12);
            duvar.Name = "duvar";
            duvar.Size = new Size(500, 500);
            duvar.TabIndex = 0;
            duvar.Paint += duvar_Paint;
            duvar.MouseClick += duvar_MouseClick;
            // 
            // nudX
            // 
            nudX.Location = new Point(578, 13);
            nudX.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudX.Name = "nudX";
            nudX.Size = new Size(353, 23);
            nudX.TabIndex = 1;
            nudX.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(524, 15);
            label1.Name = "label1";
            label1.Size = new Size(17, 19);
            label1.TabIndex = 2;
            label1.Text = "X";
            // 
            // nudY
            // 
            nudY.Location = new Point(578, 42);
            nudY.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudY.Name = "nudY";
            nudY.Size = new Size(353, 23);
            nudY.TabIndex = 1;
            nudY.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(524, 44);
            label2.Name = "label2";
            label2.Size = new Size(17, 19);
            label2.TabIndex = 2;
            label2.Text = "Y";
            // 
            // nudBoyut
            // 
            nudBoyut.Location = new Point(578, 71);
            nudBoyut.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudBoyut.Name = "nudBoyut";
            nudBoyut.Size = new Size(353, 23);
            nudBoyut.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(524, 73);
            label3.Name = "label3";
            label3.Size = new Size(45, 19);
            label3.TabIndex = 2;
            label3.Text = "Boyut";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(535, 171);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 46);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstNokta
            // 
            lstNokta.FormattingEnabled = true;
            lstNokta.ItemHeight = 15;
            lstNokta.Location = new Point(535, 223);
            lstNokta.Name = "lstNokta";
            lstNokta.Size = new Size(396, 289);
            lstNokta.TabIndex = 4;
            // 
            // pboRenk
            // 
            pboRenk.BackColor = Color.Red;
            pboRenk.Cursor = Cursors.Hand;
            pboRenk.Location = new Point(883, 107);
            pboRenk.Name = "pboRenk";
            pboRenk.Size = new Size(35, 32);
            pboRenk.TabIndex = 11;
            pboRenk.TabStop = false;
            pboRenk.Click += pboRenk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(879, 142);
            label4.Name = "label4";
            label4.Size = new Size(39, 19);
            label4.TabIndex = 2;
            label4.Text = "Renk";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(524, 107);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(322, 45);
            trackBar1.TabIndex = 12;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // btnBeniSasirt
            // 
            btnBeniSasirt.Location = new Point(692, 171);
            btnBeniSasirt.Name = "btnBeniSasirt";
            btnBeniSasirt.Size = new Size(124, 46);
            btnBeniSasirt.TabIndex = 3;
            btnBeniSasirt.Text = "BENİ ŞAŞIRT";
            btnBeniSasirt.UseVisualStyleBackColor = true;
            btnBeniSasirt.Click += btnBeniSasirt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 599);
            Controls.Add(trackBar1);
            Controls.Add(pboRenk);
            Controls.Add(lstNokta);
            Controls.Add(btnBeniSasirt);
            Controls.Add(btnEkle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudBoyut);
            Controls.Add(nudY);
            Controls.Add(nudX);
            Controls.Add(duvar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Noktalar Dünyasi";
            ((System.ComponentModel.ISupportInitialize)nudX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBoyut).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboRenk).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel duvar;
        private NumericUpDown nudX;
        private Label label1;
        private NumericUpDown nudY;
        private Label label2;
        private NumericUpDown nudBoyut;
        private Label label3;
        private Button btnEkle;
        private ListBox lstNokta;
        private PictureBox pboRenk;
        private Label label4;
        private ColorDialog colorDialog;
        private TrackBar trackBar1;
        private Button btnBeniSasirt;
    }
}