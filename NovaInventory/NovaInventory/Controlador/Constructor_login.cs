﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaInventory.Controlador
{
    class Constructor_login
    {
        public static string id_usuario { get; set; }
        public static string usuario { get; set; }
        public string clave { get; set; }
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static int nivel { get; set; }
        public Constructor_login(string usuario, string clave)
        {
            usuario = Constructor_login.usuario;
            clave = this.clave;
           
        }
    }
}
