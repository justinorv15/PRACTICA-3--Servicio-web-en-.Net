using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Cal_Area
{
    /// <summary>
    /// Descripción breve de CalcularWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 

    public class CalcularWebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public double Circulo(double Radio)
        {
            Calcular r = new Calcular();
            return r.Circulo(Radio);
        }
        [WebMethod]
        public decimal Cuadrado(decimal Lado)
        {
            Calcular r = new Calcular();
            return r.Cuadrado(Lado);
        }
        [WebMethod]
        public decimal Triangulo(decimal Base, decimal Altura)
        {
            Calcular r = new Calcular();
            return r.Triangulo(Base, Altura);
        }

    }
}
