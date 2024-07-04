using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_Repaso
{
    public partial class FrmMostrar : Form
    {
        Empresa empresaFormulario;
        public FrmMostrar(Empresa miEmpresa)
        {
            InitializeComponent();
            this.empresaFormulario = miEmpresa;
        }



        //private void FrmMostrar_Load(object sender, EventArgs e)
        //{

        //}

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (Empleado em in empresaFormulario.Empleados)
            {
                lstMostrar.Items.Add(em.MostrarInformacion());
            }
        }

        private void btnDesarrolladores_Click(object sender, EventArgs e)
        {
            foreach (Empleado em in empresaFormulario.Empleados)
            {
                if (em is Desarrollador)
                {
                    lstMostrar.Items.Add(em.MostrarInformacion());
                }
            }
        }

        private void btnGerentes_Click(object sender, EventArgs e)
        {
            foreach (Empleado em in empresaFormulario.Empleados)
            {
                if (em is Gerente)
                {
                    lstMostrar.Items.Add(em.MostrarInformacion());
                }
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            string cadena;
            cadena = empresaFormulario.MostrarUltimoEmpleado();
            MessageBox.Show(cadena);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(txtId.Text);
            Empleado em = empresaFormulario.BuscarPorId(id);
            MessageBox.Show(em.MostrarInformacion());
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            foreach(Empleado em in empresaFormulario.Empleados)
            {
                if(em is Gerente)
                {
                    Gerente g = ((Gerente)em);
                    string cadena = g.AsignarProyecto();
                    lstMostrar.Items.Add(cadena);
                }
            }
        }
    }
}
