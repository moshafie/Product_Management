﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Products_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string SalesMan;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.frm_main());
        }
    }
}