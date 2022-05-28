using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService02
{
    /// <summary>
    /// Descripción breve de WebServiceBaldor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceBaldor : System.Web.Services.WebService
    {

        [WebMethod]
        public string Suma(params string [] v)
        {
            string result = null;

            Double sum = 0;
            Boolean ok = true;

            for(int i = 0; i < v.Length; i++)
            {
                try
                {
                    Double x = Convert.ToDouble(v[i]);
                    sum += x;
                }
                catch(FormatException ex)
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
            {
                result = sum.ToString();
            }

            return result;
        }

        [WebMethod]
        public string Resta(string s1, string s2)
        {
            string result = null;

            try
            {
                Double x1 = Convert.ToDouble(s1);
                Double x2 = Convert.ToDouble(s2);
                Double x = x1 - x2;

                result = x.ToString();
            }
            catch(FormatException ex)
            {

            }
            return result;
        }

        [WebMethod]
        public string Multiplica(string s1, string s2)
        {
            string result = null;

            try
            {
                Double x1 = Convert.ToDouble(s1);
                Double x2 = Convert.ToDouble(s2);
                Double x = x1 * x2;

                result = x.ToString();
            }
            catch (FormatException ex)
            {

            }
            return result;
        }

        [WebMethod]
        public string Divide(string s1, string s2)
        {
            string result = null;

            try
            {
                Double x1 = Convert.ToDouble(s1);
                Double x2 = Convert.ToDouble(s2);
                Double x = x1 / x2;

                result = x.ToString();
            }
            catch (FormatException ex)
            {

            }
            return result;
        }

        [WebMethod]
        public string Minimo(params string[] v)
        {
            string result = null;

            Double min = Double.MaxValue;
            Boolean ok = true;

            for (int i = 0; i < v.Length; i++)
            {
                try
                {
                    Double x = Convert.ToDouble(v[i]);
                    if(x < min)
                    {
                        min = x;
                    }
                }
                catch (FormatException ex)
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
            {
                result = min.ToString();
            }

            return result;
        }

        [WebMethod]
        public string Maximo(params string[] v)
        {
            string result = null;

            Double max = Double.MinValue;
            Boolean ok = true;

            for (int i = 0; i < v.Length; i++)
            {
                try
                {
                    Double x = Convert.ToDouble(v[i]);
                    if (x > max)
                    {
                        max = x;
                    }
                }
                catch (FormatException ex)
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
            {
                result = max.ToString();
            }

            return result;
        }

        [WebMethod]
        public string Promedio(params string[] v)
        {
            string result = null;

            Double sum = 0;
            Boolean ok = true;

            for (int i = 0; i < v.Length; i++)
            {
                try
                {
                    Double x = Convert.ToDouble(v[i]);
                    sum += x;
                }
                catch (FormatException ex)
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
            {
                Double prom = sum / v.Length;
                result = prom.ToString();
            }

            return result;
        }

        [WebMethod]
        public string Porcentaje(string s1, string s2)
        {
            string result = null;

            try
            {
                Double x1 = Convert.ToDouble(s1);
                Double x2 = Convert.ToDouble(s2);
                Double x = (x1 / 100) * x2;

                result = x.ToString();
            }
            catch (FormatException ex)
            {

            }
            return result;
        }
    }
}
