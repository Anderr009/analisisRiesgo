using WinFormsApp1.Controller;
using WinFormsApp1.Models.Riesgo;

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

        private void button2_Click(object sender, EventArgs e)
        {
            txtAnalista.Text = riesgoCtrl.prueba();
            //String analista = txtAnalista.Text;
            //String damage = txtDamage.Text;
            //String activo = txtActivo.Text;
            //String risk = txtRiesgo.Text;
            //Riesgo riesgo = new Riesgo{ 
            //    analist = analista,
            //    damage = damage,
            //    risk = risk,
            //    active = activo
            //};
            //riesgoCtrl.insertRiesgo(riesgo);
            //txtAnalista.Text = "";
            //txtDamage.Text = "";
            //txtActivo.Text = "";
            //txtRiesgo.Text = "";
        }
    }
}