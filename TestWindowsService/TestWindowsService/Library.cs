﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class Libary
    {
        public static void WriteErrorLog(string message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFixe.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + message);
                sw.Flush();
                sw.Close();

            }
            catch (Exception)
            {


            }
        }

    }
}