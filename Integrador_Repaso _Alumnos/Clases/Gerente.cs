﻿using Clases.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Gerente : Empleado
    {
        #region Atributos
        private double salarioBase;
        private int proyectosManejados;
        #endregion

        #region Propiedades
        //Implementar Excepciones
        public double SalarioTotal { 
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
                salarioBase = value;
            }
        }

        public int ProyectosManejados
        {
            get => proyectosManejados;
            set
            {
                proyectosManejados = value;
            }
        }
        #endregion

        #region Contructores
        public Gerente(int id, string nombre, string apellido, int edad, string departamento, double salario, int proyectos)
        : base(nombre, apellido, edad, departamento, id)
        {
            this.salarioBase = salario;
            this.proyectosManejados = proyectos;
        }

        #endregion

        #region Metodos
        //Metodos sobreescritos

        protected override double CalcularSalario()
        {
            return this.SalarioBase + (this.proyectosManejados * 100);
        }

        public override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarInformacion());
            sb.AppendLine($"Salario Base: {this.salarioBase}");
            sb.AppendLine($"Proyectos manejados: {this.proyectosManejados}");
            return sb.ToString();
        }


        // Método propio
        public string AsignarProyecto()
        {
            string retorno;
            ProyectosManejados++;
            retorno = $"{this.nombre} ha asignado un nuevo proyecto. Total proyectos: {ProyectosManejados}";

            return retorno;
        }

        #endregion
    }
}
   