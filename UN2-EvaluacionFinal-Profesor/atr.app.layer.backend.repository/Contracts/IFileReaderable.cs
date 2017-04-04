using System.Collections.Generic;
using System.IO;
using atr.app.layer.backend.dto.Files;

namespace atr.app.layer.backend.repository.Contracts
{
    public interface IFileReaderable
    {
        LogDto GetFileByPath(string path);
        DirectoryInfo GetDirectoryByPath(string path);

        List<LogDto> GetAllLogFilesByPath(string path);
    }
}
