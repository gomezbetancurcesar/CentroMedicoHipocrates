using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CentroMedicoHipocrates
{
    public class LoginService
    {
        private static Dictionary<string, string> usuario = new Dictionary<string, string>();
        private static Usuario datosUsuario = new Usuario();

        public bool Autenticar(string rut, string password)
        {
            bool autenticado = false;
            datosUsuario = new Usuario().login(rut, password);
            if (!datosUsuario.ioId.Equals(0))
            {
                string nombreCompleto = datosUsuario.ioNombre + " " + datosUsuario.ioApellidoPaterno + " " + datosUsuario.ioApellidoMaterno;
                switch (datosUsuario.ioRol.ioNombre)
                {
                    case "Administrador":
                        usuario.Add("usuario", nombreCompleto);
                        usuario.Add("rol", datosUsuario.ioRol.ioNombre);
                        autenticado = true;
                        break;
                    case "Medico":
                        usuario.Add("usuario", nombreCompleto);
                        usuario.Add("rol", datosUsuario.ioRol.ioNombre);
                        datosUsuario.ioDoctor = new Doctor().buscarPorPersonaId(datosUsuario.ioId);
                        autenticado = true;
                    break;
                    case "Recepcion":
                        usuario.Add("usuario", nombreCompleto);
                        usuario.Add("rol", datosUsuario.ioRol.ioNombre);
                        autenticado = true;
                    break;
                }
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

        public Usuario getUser()
        {
            return datosUsuario;
        }
    }
}
