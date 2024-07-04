using Clases.Excepciones;
using Clases;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Empresa miEmpresa = new Empresa("Globand");
                Console.WriteLine(Empresa.InicioActividades);

                Desarrollador desa1 = new Desarrollador(1, "Pepe", "Gomez", 25, "Sistemas", 1500, 30);
                Desarrollador desa2 = new Desarrollador(2, "Rosa", "Ali", 25, "Sistemas", 1500, 30);
                Desarrollador desa3 = new Desarrollador(1, "Pepe", "Gomez", 25, "Sistemas", 1500, 30);
                Gerente gerente1 = new Gerente(5, "Maria", "Ruiz", 30, "Finanzas", 2500, 10);

                Console.WriteLine(miEmpresa.AñadirEmpleado(desa1));
                Console.WriteLine(miEmpresa.AñadirEmpleado(desa2));
                Console.WriteLine(miEmpresa.AñadirEmpleado(desa3));
                Console.WriteLine(miEmpresa.AñadirEmpleado(gerente1));

                Console.WriteLine(miEmpresa.MostrarEmpleados());

                Console.WriteLine("*************");
                Console.WriteLine(miEmpresa.BuscarPorId(2).MostrarInformacion());
                Console.WriteLine("*************");
                Console.WriteLine(miEmpresa.MostrarUltimoEmpleado());
            
                desa1.SalarioBase = -256; 
            }
            catch (DatoInvalidoException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch(EmpleadoNoEncotradoException ex)
            {
                Console.WriteLine(ex.Message);
                ex.LogException();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error no contemplado... comuniquese con sistemas"); 
            }

            //miEmpresa.AñadirEmpleado(desa2);
            //miEmpresa.AñadirEmpleado(desa3);
            //miEmpresa.AñadirEmpleado(gerente1);

            //Console.WriteLine(desa1.MostrarInformacion());
            //Console.WriteLine(desa1.SalarioBase);
            //Console.WriteLine(desa1.SalarioTotal);
            //Console.WriteLine("*********************");
            //Console.WriteLine(gerente1.MostrarInformacion());
            //Console.WriteLine(gerente1.SalarioTotal);





            Console.ReadLine();
        }
    }
}