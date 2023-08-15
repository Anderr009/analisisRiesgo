using System.Reflection;
using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.Models;
using WinFormsApp1.Models.Agresion;
using WinFormsApp1.Models.Extension;
using WinFormsApp1.Models.Funcion;
using WinFormsApp1.Models.Profundidad;
using WinFormsApp1.Models.Riesgo;
using WinFormsApp1.Models.Vulnerabilidad;

namespace WinFormsApp1
{
    public partial class AnalisisRiesgo : Form
    {
        public AnalisisRiesgo()
        {
            InitializeComponent();
        }

        private void AnalisisRiesgo_Load(object sender, EventArgs e)
        {
            RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
            List<Riesgo> riesgos = riesgoCtrl.getRiesgos();
            dataGridView1.DataSource = riesgos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del Form2
            Fase2 form2 = new Fase2();

            // Mostrar el Form2
            form2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new Riesgo object and set its properties
            Riesgo risk = new Riesgo();
            //risk.Id = textBox6;
            risk.analist = txtAnalista.Text;
            risk.active = txtActivo.Text;
            risk.risk = txtRiesgo.Text;
            risk.damage = txtDano.Text;

            // Save the Riesgo object to the database
            RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
            bool result = riesgoCtrl.insertRiesgo(risk);

            // Display a message to the user
            if (result)
            {
                MessageBox.Show("El riesgo se ha guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al guardar el riesgo.");
            }

            List<Riesgo> riesgos = riesgoCtrl.getRiesgos();
            dataGridView1.DataSource = riesgos;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
            //List<Riesgo> riesgos = riesgoCtrl.getRiesgos();
            //dataGridView1.DataSource = riesgos;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnalisisRiesgo_Load_1(object sender, EventArgs e)
        {
            RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
            List<Riesgo> riesgos = riesgoCtrl.getRiesgos();
            dataGridView1.DataSource = riesgos;
            dataGridView_1.DataSource = riesgos;

            // Call the function for dataGridView2
            ConfigureDataGridView(dataGridView2);

            // Call the function for dataGridView_2
            //ConfigureDataGridView(dataGridView_2);
        }

        private void ConfigureDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = false;

            // Define the columns
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "Id";
            dataGridView.Columns.Add(idColumn);

            DataGridViewTextBoxColumn activeColumn = new DataGridViewTextBoxColumn();
            activeColumn.Name = "extension";
            activeColumn.HeaderText = "extension";
            activeColumn.DataPropertyName = "extension";
            dataGridView.Columns.Add(activeColumn);

            DataGridViewTextBoxColumn riskColumn = new DataGridViewTextBoxColumn();
            riskColumn.Name = "funcion";
            riskColumn.HeaderText = "funcion";
            riskColumn.DataPropertyName = "funcion";
            dataGridView.Columns.Add(riskColumn);

            DataGridViewTextBoxColumn damageColumn = new DataGridViewTextBoxColumn();
            damageColumn.Name = "profundidad";
            damageColumn.HeaderText = "profundidad";
            damageColumn.DataPropertyName = "profundidad";
            dataGridView.Columns.Add(damageColumn);

            DataGridViewTextBoxColumn analistColumn = new DataGridViewTextBoxColumn();
            analistColumn.Name = "vuln";
            analistColumn.HeaderText = "vuln";
            analistColumn.DataPropertyName = "vuln";
            dataGridView.Columns.Add(analistColumn);

            //DataGridViewTextBoxColumn valorationColumn = new DataGridViewTextBoxColumn();
            //valorationColumn.Name = "Valoration";
            //valorationColumn.HeaderText = "Valoration";
            //valorationColumn.DataPropertyName = "valoration";
            //dataGridView.Columns.Add(valorationColumn);

            // Set the data source
            using (var context = new Context())
            {
                var query = from r in context.riesgo
                            join sube in context.extension on r.Id equals sube.id into extGroup
                            from sube in extGroup.DefaultIfEmpty()
                            join subf in context.funcion on r.Id equals subf.id into funcGroup
                            from subf in funcGroup.DefaultIfEmpty()
                            join subp in context.profundidad on r.Id equals subp.id into profGroup
                            from subp in profGroup.DefaultIfEmpty()
                            join subv in context.vuln on r.Id equals subv.id into vulnGroup
                            from subv in vulnGroup.DefaultIfEmpty()
                            select new
                            {
                                r.Id,
                                ExtensionValoration = sube != null ? sube.valoration : 0,
                                FuncionValoration = subf != null ? subf.valoration : 0,
                                ProfundidadValoration = subp != null ? subp.valoration : 0,
                                VulnValoration = subv != null ? subv.valoration : 0
                            };

                var result = query.OrderBy(r => r.Id).ToList();
                dataGridView.DataSource = result;
            }

        }

        private void btnGuardarF2_Click(object sender, EventArgs e)
        {
            Extension extension = new Extension();
            extension.valoration = int.Parse(txtExtencion.Text);
            new ExtensionCtrl().insertExtension(extension);
            //
            Profundidad prof = new Profundidad();
            prof.valoration = int.Parse(txtProfundidad.Text);
            new ProfundidadCtrl().insertProfundidad(prof);
            //
            Vulnerabilidad vuln = new Vulnerabilidad();
            vuln.valoration = int.Parse(txtVulnerabilidad.Text);
            new VulnerabilidadCtrl().insertVulnerabilidad(vuln);
            //
            Funcion func = new Funcion();
            func.valoration = int.Parse(txtFuncion.Text);
            new FuncionCtrl().insertFuncion(func);
            //
            Agresion agr = new Agresion();
            agr.valoration = int.Parse(txtAgresion.Text);
            new AgresionCtrl().insertAgresion(agr);
            //
            Sustitucion sus = new Sustitucion();
            sus.valoration = int.Parse(txtSustitucion.Text);
            new SustitucionCtrl().inserSustitucion(sus);
        }
    }
}