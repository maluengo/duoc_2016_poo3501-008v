using System.IO;

namespace atr.app.layer.backend.dto.Files
{
    public class LogDto
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public FileInfo LogInfo { get; set; }
    }
}
