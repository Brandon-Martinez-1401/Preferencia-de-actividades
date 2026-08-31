namespace Preferencia_de_actividades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //====================================
            // 1.- VALIDAR EL NOMBRE
            //====================================
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                  "Por favor escribe tu nombre.",
                   "Validación",
                      MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );
                txtNombre.Focus();
            }
            //=========================================
            // 2.-OBTENER LAS ACTIIDADES SELECCIONADAS
            //=========================================

            List<string> Actividades = new List<string>();
            if(chkDeportes.Checked)
            {
                Actividades.Add("Deportes");
            }
            if (chkMusica.Checked)
            {
                Actividades.Add("Musica");
            }
            if (chkArte.Checked)
            {
                Actividades.Add("Arte");
            }
            if (chkProgra.Checked)
            {
                Actividades.Add("Programacion");
            }
            if (chkLectura.Checked)
            {
                Actividades.Add("Lectura");
            }

            //======================================
            // 3.- compobar ue selcciono
            //======================================
            MessageBox.Show(
                "por favor seleciona una atividd minimo.",
                "validacion.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);


        }
    }
}
    