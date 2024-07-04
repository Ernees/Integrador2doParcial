using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Excepciones
{
    public class EmpleadoNoEncotradoException: Exception
    {
        Empleado empleadoException;

        public EmpleadoNoEncotradoException(string mensaje, Empleado empleadito)
            : base(mensaje)
        {
            empleadoException = empleadito;
        }
        public EmpleadoNoEncotradoException(string mensaje)
            : base(mensaje)
        {
            
        }



        public void LogException()
        {
            string filePath = "log.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: Se intento guardar: {this.empleadoException.MostrarInformacion("Corto")}");
            }
        }
    }
}
