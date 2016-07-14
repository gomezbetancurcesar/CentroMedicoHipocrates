using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CentroMedicoHipocrates
{
    public class Validaciones
    {
        public void marcarError(TextBox textbox, Color? color = null)
        {
            if (color.HasValue)
            {
                textbox.BackColor = color.Value;
            }else
            {
                textbox.BackColor = Color.FromArgb(250, 220, 220);
            }
        }

        //Valida el formato del email
        public bool validarEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (regex.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Valida el rut
        public bool validaRut(string rut)
        {
            Console.WriteLine(rut);
            rut = rut.ToUpper();
            Regex expresion = new Regex("^([0-9]){6,8}([0-9K])?$");
            string dv = rut.Substring(rut.Length - 1, 1);

            //Valida el formato del rut ingresado
            if (!expresion.IsMatch(rut))
            {
                return false;
            }

            string rutTemp = rut.Substring(0, rut.Length - 1);
            Console.WriteLine(rutTemp);
            Console.WriteLine(dv);
            if (dv != this.Digito(int.Parse(rutTemp)))
            {
                return false;
            }
            return true;
        }

        private string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }
    }
}
