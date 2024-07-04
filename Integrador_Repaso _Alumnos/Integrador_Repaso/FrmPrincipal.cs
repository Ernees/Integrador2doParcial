using Clases;
using Clases.Excepciones;
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
    public partial class FrmPrincipal : Form
    {
        Empresa miEmpresa;
        public FrmPrincipal()
        {
            InitializeComponent();

            miEmpresa = new Empresa("UTN221");
            Desarrollador desa1 = new Desarrollador(1, "Pepe", "Gomez", 25, "Sistemas", 1500, 30);
            Desarrollador desa2 = new Desarrollador(2, "Rosa", "Ali", 25, "Sistemas", 1500, 30);
            Desarrollador desa3 = new Desarrollador(3, "Pepe", "Gomez", 25, "Sistemas", 1500, 30);
            Gerente gerente1 = new Gerente(5, "Maria", "Ruiz", 30, "Gerencia", 12500, 10);
            Gerente gerente2 = new Gerente(6, "Erne", "Huerta", 20, "Gerencia", 6500, 1);

            miEmpresa.AñadirEmpleado(desa1);
            miEmpresa.AñadirEmpleado(desa2); 
            miEmpresa.AñadirEmpleado(desa3);
            miEmpresa.AñadirEmpleado(gerente1);
            miEmpresa.AñadirEmpleado(gerente2);
            
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FrmDesarrollador miFormulario = new FrmDesarrollador();
                if(miFormulario.ShowDialog() == DialogResult.OK)
                {
                    miEmpresa.AñadirEmpleado(miFormulario.DesarrolladorFormulario);

                    MessageBox.Show("Desarrollador cargado exitosamente");
                }
                else
                {
                    MessageBox.Show("Accion cancelada por el usuario. Desarrollador no cargado");
                }
            }
            catch(EmpleadoNoEncotradoException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.miEmpresa);
            mostrar.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
                
        }
    }
}
