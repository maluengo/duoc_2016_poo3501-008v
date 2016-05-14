using System.Collections.Generic;
using atr.app.layer.backend.dto.Files;

namespace atr.app.layer.backend.dto.Analysis
{
    /// <summary>
    /// ATR: Objeto, representa el resultado final de la búsqueda
    /// y análisis.  Contiene el Log Object y sus N resultados de acuerdo
    /// a los parámetros de búsqueda seleccionados. 
    /// </summary>
    public class LogAnalysisResultDto
    {
        public LogDto LogObjectAnalyzed { get; set; }
        public IEnumerable<LogAnalysisMessageFindedDto>  LogMessagesAnalyzed { get; set; } 
    }
}
