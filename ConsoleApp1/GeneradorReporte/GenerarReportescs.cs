using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.GeneradorReporte
{
    public class GenerarReportescs
    {
        public abstract class ReporteFactory
        {
            public abstract IGenerar_reporte CrearReporte();

            public void GenerarReporte()
            {

                var reporte = CrearReporte();
                reporte.Generar_reporte();
            }
        }

    }
}
