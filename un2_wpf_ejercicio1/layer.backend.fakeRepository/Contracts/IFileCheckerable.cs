using System.IO;

namespace layer.backend.fakeRepository.Contracts
{
    public interface IFileCheckerable
    {
        bool IsDotLog(string logFile);
        bool IsMatchExtension(string extension, FileInfo logFile);

    }
}
