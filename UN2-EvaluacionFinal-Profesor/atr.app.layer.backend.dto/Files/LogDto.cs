using System.IO;

namespace atr.app.layer.backend.dto.Files
{
    /// <summary>
    /// ATR: Objeto que representa la abstracción del archivo de log a analizar. 
    /// </summary>
    public class LogDto
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public FileInfo LogInfo { get; set; }
    }
}
