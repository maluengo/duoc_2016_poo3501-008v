using System;

namespace atr.app.layer.backend.dto.Analysis
{
    /// <summary>
    /// Objeto que representa la abstracción del resultado del análisis. 
    /// </summary>
    public class LogAnalysisMessageFindedDto
    {
        public string MessageInfo { get; set; }
        public string MessageError { get; set; }
        public string MessageWarning { get; set; }
        public string TimeStamp { get; set; }    
    }
}
