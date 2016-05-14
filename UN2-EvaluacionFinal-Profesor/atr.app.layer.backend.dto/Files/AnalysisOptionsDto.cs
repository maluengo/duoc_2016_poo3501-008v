namespace atr.app.layer.backend.dto.Files
{
    /// <summary>
    /// Objeto que representa la abstracción de las opciones de análiss.
    /// </summary>
    public class AnalysisOptionsDto
    {
        public bool IsErrorAnalysisEnabled{ get; set; }
        public bool IsWarningAnalysisEnabled { get; set; }
        public bool IsInfoAnalysisEnabled { get; set; }
    }
}
