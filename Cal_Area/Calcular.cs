using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cal_Area
{
    public class Calcular
    {
        public decimal Lado { get; set; }
        public decimal Base { get; set; }
        public decimal Altura { get; set; }
        public double Radio { get; set; }

        public double Circulo(double Radio1)
        {
            Radio = Radio1;
            var resultado = Math.PI * (Radio1 * Radio1);
            return resultado;
        }

        public decimal Cuadrado(decimal Lado1)
        {
            Lado = Lado1;
            var resultado = Lado1 * Lado1;
            return resultado;
        }

        public decimal Triangulo(decimal Base1, decimal Altura1)
        {
            Base = Base1;
            Altura = Altura1;
            var resultado = (Base1 * Altura1) / 2;
            return resultado;
        }

    }
}