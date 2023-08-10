namespace WinFormsApp1
{
    public partial class Fase1 : Form
    {
        public Fase1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del Form2
            Fase2 form2 = new Fase2();

            // Mostrar el Form2
            form2.Show();
        }
    }
}