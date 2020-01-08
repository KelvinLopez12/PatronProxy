using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxyMiServidor : Servidor
    {
        MiServidor miServidor;
        private int puerto;
        private String host;
        public ProxyMiServidor(int p, String h)
        {
            puerto = p;
            host = h;
            miServidor = null;
        }
        public override string descargar(String url)
        {
            string resultado = String.Empty;
            if (restringido(url))
            {
                if (miServidor == null)
                    miServidor = new MiServidor(puerto, host); // en esta parte "MiServidor" y "ProxyMiServidor" están herdando de "Servidor"

                resultado = miServidor.descargar(url);

            }
            else
                resultado = "Esta descarga no está disponible en tu país.";



            return resultado;
        }



        public Boolean restringido(string ruta)
        {
            Boolean descargaPermitida = false;
            if (ruta == "descargaPermitida")
                descargaPermitida = true;
            return descargaPermitida;
        }
    }
}