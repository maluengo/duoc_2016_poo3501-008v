using System.Collections.Generic;
using System.IO;

namespace layer.backend.fakeRepository.Contracts
{
    public interface IFileReaderable
    {
        IEnumerable<FileInfo> GetAllFilesFromPath(string path);
        IEnumerable<FileInfo> GetOnlyLogFiles(string path);

    }
}
