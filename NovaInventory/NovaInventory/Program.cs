﻿using System;
using NovaInventory.Vista;
using System.Windows.Forms;
using NovaInventory.Reportes;

namespace NovaInventory
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
