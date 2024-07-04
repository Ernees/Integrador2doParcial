using Clases;

namespace Integrador_Repaso
{
    public partial class FrmDesarrollador : Form
    {
        Desarrollador desarrolladorFormulario;
        public Desarrollador DesarrolladorFormulario 
        { 
            get => desarrolladorFormulario;
        }
        public FrmDesarrollador()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string departamento;
            int edad;
            double salario;
            int lineas;
            int id;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            departamento = txtDepartamento.Text;
            edad = int.Parse(txtEdad.Text);
            salario = double.Parse(txtBasico.Text);
            lineas = int.Parse((txtLineas.Text));
            id = int.Parse((txtId.Text));

            desarrolladorFormulario = new Desarrollador(id, nombre, apellido, edad, departamento, salario, lineas);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}