using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public abstract class Servidor
    {
        public abstract string descargar(String url); // creamos una clase abstracta de la cual van a heredar las demás clases
    }
}
