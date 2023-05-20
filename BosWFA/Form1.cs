namespace BosWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void duvar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (object o in lstNokta.Items)
            {
                Nokta n = (Nokta)o;


                Brush fircam = new SolidBrush(n.Renk);
                g.FillEllipse(fircam, n.X, n.Y, n.Boyut, n.Boyut);

            }

        }


        // Ekle butonu ile nud lardan al�nan de�erlerle nokta objesini olu�turduk. ve listbox a att�k
        public void duvar_MouseClick(object sender, MouseEventArgs e)
        {
            nudX.Value = e.X;
            nudY.Value = e.Y;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            nudBoyut.Value = trackBar1.Value;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int x = (int)nudX.Value;
            int y = (int)nudY.Value;
            int boyut = (int)nudBoyut.Value;
            Color renk = pboRenk.BackColor;

            Nokta nokta = new Nokta(x, y, boyut, renk);
            lstNokta.Items.Add(nokta);
            duvar.Refresh();

        }

        private void pboRenk_Click(object sender, EventArgs e)
        {
            ColorDialog cdi = new ColorDialog();
            cdi.ShowDialog();
            pboRenk.BackColor = cdi.Color;
        }


    }
}