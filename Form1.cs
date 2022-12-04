namespace VoziloKolekcije
{
    public partial class Form1 : Form
    {

        List<Vozilo> listaVozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            int kontrola = 0;
            if (Convert.ToInt32(txtBrojKotaca.Text) % 2 != 0)
            {
                MessageBox.Show("Unesite paran broj kotaèa!",
                    "Greška", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                kontrola = 1;
            }
            if (kontrola == 0)
            {

                try
                {
                    Vozilo vozilo = new Vozilo(txtModel.Text,
                        Convert.ToInt32(txtGodinaProizvodnje.Text),
                        Convert.ToInt32(txtBrojKotaca.Text));
                    txtBrojKotaca.Clear();
                    txtGodinaProizvodnje.Clear();
                    txtModel.Clear();
                    listaVozila.Add(vozilo);
                }
                catch (Exception greska)
                {
                    MessageBox.Show("Pogrešan unos!\r\n" + greska.Message,
                        "Greška", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach (Vozilo vozilo in listaVozila)
            {
                if (vozilo.BrojKotaca == 2)
                {
                    vozilo.Kategorija = "Motocikl";
                }
                else if (vozilo.BrojKotaca == 4)
                {
                    vozilo.Kategorija = "Automobil";
                }
                else if (vozilo.BrojKotaca > 4)
                {
                    vozilo.Kategorija = "Kamion";
                }
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();
            foreach (Vozilo vozilo in listaVozila)
            {
                txtIspis.AppendText(vozilo.ToString());
            }
        }
    }
}