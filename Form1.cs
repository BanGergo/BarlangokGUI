namespace BarlangokGUI
{
    public partial class Form1 : Form
    {
        List<Barlang> lista = new List<Barlang>();
        void betoltes()
        {
            FileStream fs = new FileStream("..\\..\\..\\src\\barlangok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Barlang(sr.ReadLine()));
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btkeres_Click(object sender, EventArgs e)
        {
            bool b = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (txazon.Text.ToString() == lista[i].Azon.ToString())
                {
                    b = true;
                    lbnev.Text = lista[i].Nev;
                    txhossz.Text = lista[i].Hossz.ToString();
                    txmely.Text = lista[i].Melyseg.ToString();
                    btmentes.Enabled = true;
                }
            }
            if (b == false)
            {
                MessageBox.Show("Ezzel az azonosítóval nem létezik barlang!", "Hiba!", MessageBoxButtons.OK);
                txazon.Clear();
                txazon.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
            btmentes.Enabled = false;
        }

        private void btmentes_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("barlangok.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write($"\n{txazon.Text};{lbnev.Text};{txhossz.Text};{txmely};telepules;vedettseg");

            sw.Close();
            fs.Close();
        }
    }
}
