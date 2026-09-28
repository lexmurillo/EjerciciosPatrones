using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.GeneradorReporte
{
    public class CreatorWord : GenerarReportescs.ReporteFactory
    {
        public override IGenerar_reporte CrearReporte() => new Reporte_word();


    }
    
    
}
