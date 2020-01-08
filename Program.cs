using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el proxy a la página de descargas
            Servidor servidor = new ProxyMiServidor(20, "https://www.mediafire.com/");
            // Descargamos un archivo permitido
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(servidor.descargar("descargaPermitida"));
            Console.ReadLine();
            // Vamos a probar ahora con una descarga restringida
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(servidor.descargar("descargaDenegada"));
            Console.ReadLine();
        }
    }
}
