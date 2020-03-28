using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronaHebianaLuis
{
    class NeuronaHebiana
    {
        double[] pesosIniciales = new double[0];
        double[] pesosFinales = new double[0];
        double biasInicial = 0;
        double biasFinal = 0;

        public void Init(double[] PesosEntrada,
                         double BiasEntrada)
        {
            pesosIniciales = (double[])PesosEntrada.Clone();
            pesosFinales = (double[])pesosIniciales.Clone();
            biasInicial = BiasEntrada;
            biasFinal = biasInicial;

        }

        public NeuronaHebiana Clone()
        {
            NeuronaHebiana other = (NeuronaHebiana)this.MemberwiseClone();
            other.pesosIniciales =(double[]) pesosIniciales.Clone();
            other.pesosFinales = (double[]) pesosFinales.Clone();
            other.biasInicial = biasInicial;
            other.biasFinal = biasFinal;
            return other;
        }

        public void NuevaEpoca(double[] Entradas,double Salida)
        {
            for (int i  = 0;i<pesosIniciales.Length;i++)
            {
                pesosFinales[i] = obtenerNuevoPeso(pesosFinales[i], Salida, Entradas[i]);
            }

            biasFinal = obtenerNuevoBias(biasFinal, Salida);
        }
        private double obtenerNuevoPeso(double w,double y, double x)
        {
            return (double)(w + y * x);
        }
        private double obtenerNuevoBias(double b, double y)
        {
            return b + y;
        }
        public double obtenerSalida(double[] entradas)
        {
            double output = 0;
            for(int i  = 0;i<entradas.Length;i++)
            {
                output += pesosFinales[i]*entradas[i];
            }
            return funcionDeExitacion(output+biasFinal);
        }
        public double funcionDeExitacion(double input)
        {
            if(input>0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public double[] ObtenerPesosFinales()
        {
            return (double[])pesosFinales.Clone();
        }
        public double ObtenerBiasFinal()
        {
            return biasFinal;
        }
        public double[] ObtenerPesosIniciales()
        {
            return (double[])pesosIniciales.Clone();
        }
        public double ObtenerBiasInicial()
        {
            return biasInicial;
        }

        
    }
}
