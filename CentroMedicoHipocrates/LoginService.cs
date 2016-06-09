using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedicoHipocrates
{
    public class LoginService
    {
        private static Dictionary<string, string> usuario = new Dictionary<string, string>();

        public bool Autenticar(string username, string password)
        {
            bool autenticado = false;
            //Ir a preguntar al modelo de la tabla si existe el usuario
            if (username == "admin")
            {
                usuario.Add("usuario", username);
                usuario.Add("rol", "administrador");
                autenticado = true;
            }

            if (username.Equals("medico"))
            {
                usuario.Add("usuario", username);
                usuario.Add("rol", "medico");
                autenticado = true;
            }

            if (username.Equals("recepcion"))
            {
                usuario.Add("usuario", username);
                usuario.Add("rol", "recepcion");
                autenticado = true;
            }
            return autenticado;
        }

        public Dictionary<string, string> Auth()
        {
            return usuario;
        }

        public string AuthField(string index)
        {
            if(usuario[index] != null)
            {
                return usuario[index];
            }
            else
            {
                return "";
            }
        }
    }
}
