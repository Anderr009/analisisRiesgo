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
using WinFormsApp1.Models.Sustitucion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp1.Libs;

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

            AnalisisRiesgo_Load_2(sender, e);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
            //List<Riesgo> riesgos = riesgoCtrl.getRiesgos();
            //dataGridView1.DataSource = riesgos;
        }


        private void ConfigureDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = false;

        }


        private void btnGuardar_Click(object sender, EventArgs e)
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

            AnalisisRiesgo_Load_2(sender, e);
        }

        private void ConfigurarDataGridView(DataGridView dgv, IEnumerable<object> dataSource)
        {
            dgv.DataSource = dataSource;

            dgv.Columns["ValorationAgresion"].HeaderText = "A";
            dgv.Columns["ValorationExtension"].HeaderText = "E";
            dgv.Columns["ValorationFuncion"].HeaderText = "F";
            dgv.Columns["ValorationProfundidad"].HeaderText = "P";
            dgv.Columns["ValorationSustitucion"].HeaderText = "S";
            dgv.Columns["ValorationVulnerabilidad"].HeaderText = "V";
        }

        private void ConfigurarDataGridView3()
        {
            dataGridView3.Columns.Add("Index", "id");
            dataGridView3.Columns.Add("CaractRisk", "CaR");
            dataGridView3.Columns.Add("ProbRisk", "PR");
            dataGridView3.Columns.Add("CuantRisk", "CR"); 
            
            dataGridView_3.Columns.Add("Index", "id");
            dataGridView_3.Columns.Add("CaractRisk", "CaR");
            dataGridView_3.Columns.Add("ProbRisk", "PR");
            dataGridView_3.Columns.Add("CuantRisk", "CR");
        }

        private void MostrarClasificacionEnDataGridView()
        {
            Utilities utilities = new Utilities();
            string[] clasificacionData = utilities.clasfRisk();
            int[] cuantRisk = utilities.CuantRisk();

            RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
            List<Riesgo> riesgos = riesgoCtrl.getRiesgos();

            for (int i = 0; i < clasificacionData.Length; i++)
            {
                int riesgoId = riesgos[i].Id; // Obtén el ID correspondiente de la lista de riesgos

                dataGridView4.Rows.Add(riesgoId, cuantRisk[i], clasificacionData[i]);
            }
            dataGridView4.SelectionChanged += (sender, e) =>
            {
                dataGridView4.ClearSelection();
            };

            dataGridView4.CellMouseDown += (sender, e) =>
            {
                if (e.RowIndex != -1)
                {
                    dataGridView4.Rows[e.RowIndex].Selected = false;
                }
            };
        }

        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que sea una fila válida
            {
                DataGridViewRow row = dataGridView4.Rows[e.RowIndex];
                string clasificacion = row.Cells["Clasificacion"].Value.ToString();

                if (clasificacion == "Muy pequeño")
                {
                    row.DefaultCellStyle.BackColor = Color.Green; // Fila verde
                }
                else if (clasificacion == "Pequeño" || clasificacion == "Normal")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow; // Fila amarilla
                }
                else if (clasificacion == "Grande" || clasificacion == "Elevado")
                {
                    row.DefaultCellStyle.BackColor = Color.Red; // Fila roja
                }
            }
        }



        private void AnalisisRiesgo_Load_2(object sender, EventArgs e)
        {
            RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
            List<Riesgo> riesgos = riesgoCtrl.getRiesgos();
            dataGridView1.DataSource = riesgos;
            dataGridView_1.DataSource = riesgos;
            dataGridView__1.DataSource = riesgos;

            // Call the function for dataGridView2
            //ConfigureDataGridView(dataGridView2);

            AgresionCtrl agresionCtrl = new AgresionCtrl();
            ExtensionCtrl extensionCtrl = new ExtensionCtrl();
            FuncionCtrl funcionCtrl = new FuncionCtrl();
            ProfundidadCtrl profundidadCtrl = new ProfundidadCtrl();
            SustitucionCtrl sustitucionCtrl = new SustitucionCtrl();
            VulnerabilidadCtrl vulnerabilidadCtrl = new VulnerabilidadCtrl();

            List<Agresion> agresiones = agresionCtrl.getAgresiones();
            List<Extension> extensiones = extensionCtrl.getExtensiones();
            List<Funcion> funciones = funcionCtrl.getFunciones();
            List<Profundidad> profundidades = profundidadCtrl.getProfundidad();
            List<Sustitucion> Sustituciones = sustitucionCtrl.getSustituciones();
            List<Vulnerabilidad> vulnerabilidades = vulnerabilidadCtrl.getVulnerabilidades();

            // Combinar los datos en una lista de objetos anónimos
            var combinedData = new List<object>();

            foreach (var riesgo in riesgos)
            {
                var agresion = agresiones.FirstOrDefault(a => a.id == riesgo.Id);
                var extension = extensiones.FirstOrDefault(e => e.id == riesgo.Id);
                var funcion = funciones.FirstOrDefault(f => f.id == riesgo.Id);
                var profundidad = profundidades.FirstOrDefault(p => p.id == riesgo.Id);
                var sustitucion = Sustituciones.FirstOrDefault(s => s.id == riesgo.Id);
                var vulnerabilidad = vulnerabilidades.FirstOrDefault(v => v.id == riesgo.Id);

                if (agresion != null && extension != null && funcion != null &&
                    profundidad != null && sustitucion != null && vulnerabilidad != null)
                {
                    combinedData.Add(new
                    {
                        ID = riesgo.Id,
                        ValorationAgresion = agresion.valoration,
                        ValorationExtension = extension.valoration,
                        ValorationFuncion = funcion.valoration,
                        ValorationProfundidad = profundidad.valoration,
                        ValorationSustitucion = sustitucion.valoration,
                        ValorationVulnerabilidad = vulnerabilidad.valoration
                    });
                }
            }
            // Limpia las DataGridViews antes de asignar nuevos datos
            dataGridView2.DataSource = null;
            dataGridView_2.DataSource = null;
            dataGridView__2.DataSource = null;

            ConfigurarDataGridView(dataGridView2, combinedData);
            ConfigurarDataGridView(dataGridView_2, combinedData);
            ConfigurarDataGridView(dataGridView__2, combinedData);

            dataGridView3.DataSource = null;
            dataGridView_3.DataSource = null;
            dataGridView3.Columns.Clear();
            dataGridView_3.Columns.Clear();
            Utilities utilities = new Utilities();

            int[] caractRisk = utilities.CaractRiesg();
            int[] probRisk = utilities.ProbRisk();
            int[] cuantRisk = utilities.CuantRisk();

            dataGridView3.Refresh();
            ConfigurarDataGridView3();  

            for (int i = 0; i < caractRisk.Length; i++)
            {
                int riesgoId = riesgos[i].Id; // Obtén el ID correspondiente de la lista de riesgos
                dataGridView3.Rows.Add(riesgoId, caractRisk[i], probRisk[i], cuantRisk[i]);
            }

            for (int j = 0; j < caractRisk.Length; j++)
            {
                int riesgoId = riesgos[j].Id; // Obtén el ID correspondiente de la lista de riesgos
                dataGridView_3.Rows.Add(riesgoId, caractRisk[j], probRisk[j], cuantRisk[j]);
            }


            txtFuncion.Enabled = false;
            txtSustitucion.Enabled = false;
            txtProfundidad.Enabled = false;
            txtExtencion.Enabled = false;
            txtAgresion.Enabled = false;
            txtVulnerabilidad.Enabled = false;


            dataGridView4.DataSource = null;
            dataGridView4.Columns.Clear();
            dataGridView4.Columns.Add("Index", "ID");
            dataGridView4.Columns.Add("CuantRisk", "CR");
            dataGridView4.Columns.Add("Clasificacion", "Clasificacion");


            dataGridView4.Refresh();
            MostrarClasificacionEnDataGridView();
            
            dataGridView4.CellFormatting += dataGridView4_CellFormatting!;
            
        }

        private bool IsValidNumber(string text, int minValue, int maxValue)
        {
            if (int.TryParse(text, out int number))
            {
                return number >= minValue && number <= maxValue;
            }
            return false;
        }

        private void btnGuardarF2_Click_1(object sender, EventArgs e)
        {
            int minValue = 1;
            int maxValue = 5;

            if (IsValidNumber(txtFuncion.Text, minValue, maxValue) &&
                IsValidNumber(txtSustitucion.Text, minValue, maxValue) &&
                IsValidNumber(txtProfundidad.Text, minValue, maxValue) &&
                IsValidNumber(txtExtencion.Text, minValue, maxValue) &&
                IsValidNumber(txtAgresion.Text, minValue, maxValue) &&
                IsValidNumber(txtVulnerabilidad.Text, minValue, maxValue))
            {
                FuncionCtrl funcionCtrl = new FuncionCtrl();
                SustitucionCtrl sustitucionCtrl = new SustitucionCtrl();
                ProfundidadCtrl profundidadCtrl = new ProfundidadCtrl();
                ExtensionCtrl extensionCtrl = new ExtensionCtrl();
                AgresionCtrl agresionCtrl = new AgresionCtrl();
                VulnerabilidadCtrl vulnerabilidadCtrl = new VulnerabilidadCtrl();

                int funcionVal = int.Parse(txtFuncion.Text);
                int sustitucionVal = int.Parse(txtSustitucion.Text);
                int profundidadVal = int.Parse(txtProfundidad.Text);
                int extensionVal = int.Parse(txtExtencion.Text);
                int agresionVal = int.Parse(txtAgresion.Text);
                int vulnerabilidadVal = int.Parse(txtVulnerabilidad.Text);

                Funcion funcion = new Funcion { valoration = funcionVal };
                Sustitucion sustitucion = new Sustitucion { valoration = sustitucionVal };
                Profundidad profundidad = new Profundidad { valoration = profundidadVal };
                Extension extension = new Extension { valoration = extensionVal };
                Agresion agresion = new Agresion { valoration = agresionVal };
                Vulnerabilidad vulnerabilidad = new Vulnerabilidad { valoration = vulnerabilidadVal };

                bool funcionInserted = funcionCtrl.insertFuncion(funcion);
                bool sustitucionInserted = sustitucionCtrl.inserSustitucion(sustitucion);
                bool profundidadInserted = profundidadCtrl.insertProfundidad(profundidad);
                bool extensionInserted = extensionCtrl.insertExtension(extension);
                bool agresionInserted = agresionCtrl.insertAgresion(agresion);
                bool vulnerabilidadInserted = vulnerabilidadCtrl.insertVulnerabilidad(vulnerabilidad);

                if (funcionInserted && sustitucionInserted && profundidadInserted &&
                    extensionInserted && agresionInserted && vulnerabilidadInserted)
                {
                    MessageBox.Show("Datos guardados exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al guardar los datos.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos en el rango de 1 a 5 en los campos.");
            }

            AnalisisRiesgo_Load_2(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRid.Text = dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAnalista.Text = "";
            txtActivo.Text = "";
            txtRiesgo.Text = "";
            txtDano.Text = "";
            txtId.Text = "";
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
                Riesgo riesgo = riesgoCtrl.getRiesgoById(id);

                if (riesgo != null)
                {
                    txtAnalista.Text = riesgo.analist;
                    txtActivo.Text = riesgo.active;
                    txtRiesgo.Text = riesgo.risk;
                    txtDano.Text = riesgo.damage;
                }
                else
                {
                    txtAnalista.Text = "";
                    txtActivo.Text = "";
                    txtRiesgo.Text = "";
                    txtDano.Text = "";
                }
            }
            else
            {
                txtAnalista.Text = "";
                txtActivo.Text = "";
                txtRiesgo.Text = "";
                txtDano.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
                Riesgo riesgo = riesgoCtrl.getRiesgoById(id);

                if (riesgo != null)
                {
                    txtAnalista.Text = riesgo.analist;
                    txtActivo.Text = riesgo.active;
                    txtRiesgo.Text = riesgo.risk;
                    txtDano.Text = riesgo.damage;
                }
                else
                {
                    txtAnalista.Text = "";
                    txtActivo.Text = "";
                    txtRiesgo.Text = "";
                    txtDano.Text = "";
                }
            }
            else
            {
                txtAnalista.Text = "";
                txtActivo.Text = "";
                txtRiesgo.Text = "";
                txtDano.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
                AgresionCtrl agresionCtrl = new AgresionCtrl();
                ExtensionCtrl extensionCtrl = new ExtensionCtrl();
                FuncionCtrl funcionCtrl = new FuncionCtrl();
                ProfundidadCtrl profundidadCtrl = new ProfundidadCtrl();
                SustitucionCtrl sustitucionCtrl = new SustitucionCtrl();
                VulnerabilidadCtrl vulnerabilidadCtrl = new VulnerabilidadCtrl();

                Riesgo riesgo = riesgoCtrl.getRiesgoById(id);
                bool eliminado = false;

                if (agresionCtrl.getAgresionById(id) == null &&
                       extensionCtrl.GetExtensionById(id) == null &&
                       funcionCtrl.getFuncionById(id) == null &&
                       profundidadCtrl.getProfundidadById(id) == null &&
                       sustitucionCtrl.getSustituciones().FirstOrDefault(s => s.id == id) == null &&
                       vulnerabilidadCtrl.GetVulnerabilidadById(id) == null)
                {
                    MessageBox.Show("No se encontraron registros en otras tablas para el ID proporcionado.");
                }else
                {
                    if (riesgo != null)
                    {
                        eliminado = riesgoCtrl.RemoveRiesgoById(id);
                        agresionCtrl.RemoveAgresionById(id);
                        extensionCtrl.RemoveExtensionById(id);
                        funcionCtrl.RemoveFuncionById(id);
                        profundidadCtrl.RemoveProfundidadById(id);
                        sustitucionCtrl.RemoveSustitucionesById(id);
                        vulnerabilidadCtrl.RemoveVulnerabilidadById(id);
                    }
                }

                if (eliminado)
                {
                    // Hacer algo en caso de éxito, como actualizar la interfaz
                    MessageBox.Show("El riesgo se ha eliminado correctamente.");
                }
                else
                {
                    // Hacer algo en caso de que no se encuentre el riesgo con el ID dado
                    MessageBox.Show("No se encontró un riesgo con el ID proporcionado.");
                }
            }
            else
            {
                // Hacer algo si el ID no es válido
                MessageBox.Show("Ingrese un ID válido.");
            }

            AnalisisRiesgo_Load_2(sender, e);
        }

        private void txtRid_TextChanged(object sender, EventArgs e)
        {
            bool isTxtRidEmpty = string.IsNullOrWhiteSpace(txtRid.Text);

            if (!isTxtRidEmpty)
            {
                int idToFind = int.Parse(txtRid.Text); // Suponiendo que el valor en txtRid es un número
                DataGridViewRow row = dataGridView2.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(r => Convert.ToInt32(r.Cells["ID"].Value) == idToFind);

                if (row != null)
                {
                    txtFuncion.Text = row.Cells["ValorationFuncion"].Value.ToString();
                    txtSustitucion.Text = row.Cells["ValorationSustitucion"].Value.ToString();
                    txtProfundidad.Text = row.Cells["ValorationProfundidad"].Value.ToString();
                    txtExtencion.Text = row.Cells["ValorationExtension"].Value.ToString();
                    txtAgresion.Text = row.Cells["ValorationAgresion"].Value.ToString();
                    txtVulnerabilidad.Text = row.Cells["ValorationVulnerabilidad"].Value.ToString();

                    txtFuncion.Enabled = true;
                    txtSustitucion.Enabled = true;
                    txtProfundidad.Enabled = true;
                    txtExtencion.Enabled = true;
                    txtAgresion.Enabled = true;
                    txtVulnerabilidad.Enabled = true;
                }
                else
                {
                    txtFuncion.Text = "";
                    txtSustitucion.Text = "";
                    txtProfundidad.Text = "";
                    txtExtencion.Text = "";
                    txtAgresion.Text = "";
                    txtVulnerabilidad.Text = "";

                    txtFuncion.Enabled = true;
                    txtSustitucion.Enabled = true;
                    txtProfundidad.Enabled = true;
                    txtExtencion.Enabled = true;
                    txtAgresion.Enabled = true;
                    txtVulnerabilidad.Enabled = true;
                }
            }
            else
            {
                txtFuncion.Text = "";
                txtSustitucion.Text = "";
                txtProfundidad.Text = "";
                txtExtencion.Text = "";
                txtAgresion.Text = "";
                txtVulnerabilidad.Text = "";

                txtFuncion.Enabled = false;
                txtSustitucion.Enabled = false;
                txtProfundidad.Enabled = false;
                txtExtencion.Enabled = false;
                txtAgresion.Enabled = false;
                txtVulnerabilidad.Enabled = false;
            }

            if (!isTxtRidEmpty)
            {
                int idToFind = int.Parse(txtRid.Text); // Suponiendo que el valor en txtRid es un número
                DataGridViewRow row = dataGridView2.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(r => Convert.ToInt32(r.Cells["ID"].Value) == idToFind);

                if (row != null)
                {
                    btnGuardarF2.Enabled = false;
                }
                else
                {
                    btnGuardarF2.Enabled = true;
                }
            }
            else
            {
                btnGuardarF2.Enabled = true;
            }


        }

        
    }
}