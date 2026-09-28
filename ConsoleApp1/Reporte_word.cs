using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
  internal class Reporte_word : IGenerar_reporte
    {
        public void Generar_reporte()
        {
            Console.WriteLine("Generando reporte en Word...");
        }
    }
    
}
