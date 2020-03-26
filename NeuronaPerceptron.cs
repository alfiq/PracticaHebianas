using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronaHebianaLuis
{
    class NeuronaPerceptron
    {
        double[] pesosIniciales = new double[0];
        double[] pesosFinales = new double[0];
        double Theta = 0;
        double Miu = 0.01;
        bool continua = false;
        public void Init(double[] PesosEntrada,double Theta = 1,double FactorAprendizaje = 0.01,bool EsContinua = false)
        {
            if(PesosEntrada.Length<1)
            {

            }
            pesosIniciales = PesosEntrada;
            pesosFinales = (double[])pesosIniciales.Clone();
            this.Theta = Theta;
            continua = EsContinua;
            Miu = FactorAprendizaje;
        }
        public void NuevaEpoca(double[] Entradas, double Salida)
        {
            double yi = obtenerSalida(Entradas);
            for (int i = 0; i < pesosIniciales.Length; i++)
            {
                pesosFinales[i] = obtenerNuevoPeso(pesosFinales[i], yi, Entradas[i],obtenerBeta(Salida, yi));
            }
        }
        private double obtenerNuevoPeso(double w, double y, double x, double beta)
        {
            if (continua)
            {
                return (double)(w + x * Miu * beta);
            }
            else
            {
                return (double)(w + y * x * beta);
            }
        }
        public double obtenerSalida(double[] entradas)
        {
            double output = 0;
            for (int i = 0; i < entradas.Length; i++)
            {
                output += pesosFinales[i] * entradas[i];
            }
            output = funcionDeExitacion(output);
            return output;
        }
        public double funcionDeExitacion(double input)
        {
            if (continua)
            {
                return input;
            }
            else
            {
                if (input >= Theta)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        public double[] ObtenerPesosFinales()
        {
            return (double[])pesosFinales.Clone();
        }
        public double obtenerBeta(double y, double y2)
        {
            if(continua)
            {
                return y - y2;
            }
            else
            {
                if (y == y2)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

        }
    }
}
