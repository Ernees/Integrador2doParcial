using Clases.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Desarrollador : Empleado
    {
        #region Atributos
        private double salarioBase;
        private int lineasDeCodigoPorHora;
        #endregion

        #region Propiedades
        //Implementar Excepciones
        public double SalarioTotal
        {
            get
            {
                return CalcularSalario();
            }
        }
        public double SalarioBase
        {
            get => salarioBase;
            set
            {
                if (value < 0 || value > 500000) 
                {
                    throw new DatoInvalidoException("Intento ingresar un sueldo fuera de rango", value.ToString());
                }
               salarioBase = value;
            }
        }

        public int LineasDeCodigoPorHora
        {
            get => lineasDeCodigoPorHora;
            set
            {
                lineasDeCodigoPorHora = value;
            }
        }
        #endregion

        #region Constructores
        public Desarrollador(int id, string nombre, string apellido, int edad, string departamento, double salarioBase, int lineasDeCodigoPorHora)
            : base(nombre, apellido, edad, departamento, id)
        {
            this.salarioBase= salarioBase;
            this.lineasDeCodigoPorHora = lineasDeCodigoPorHora;
        }
        #endregion

        #region Metodos
        // Métodos sobrescritos
        protected override double CalcularSalario()
        {
            return this.SalarioBase + (this.lineasDeCodigoPorHora * 0.5f);
        }


        #endregion
    }
}
