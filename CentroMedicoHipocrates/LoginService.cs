﻿using System;
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
            if (username == "usuario")
            {
                autenticado = true;
            }
            
            if (autenticado)
            {
                usuario.Add("usuario", username);
                usuario.Add("rol", "administrador");
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
            }else
            {
                return "";
            }
        }
    }
}