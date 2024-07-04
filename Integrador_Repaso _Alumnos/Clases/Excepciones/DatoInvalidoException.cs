using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Excepciones
{
    public class DatoInvalidoException : Exception
    {
        string valor;
        public DatoInvalidoException(string mensaje, string valor)
            :base(mensaje)
        {
            this.valor = valor;
            LogException();
        }

        private void LogException()
        {
            string filePath = "log.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: Excepcion no controlada: {this.Message} Valor: {this.valor}");
            }
        }


    }
}
