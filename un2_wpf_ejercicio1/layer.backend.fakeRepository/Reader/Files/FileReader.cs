using System.Collections.Generic;
using System.IO;
using layer.backend.fakeRepository.Contracts;

namespace layer.backend.fakeRepository.Reader.Files
{
    public class FileReader: IFileReaderable
    {
        //IEnumerable<FileInfo> IFileReaderable.GetAllFilesFromPath(string path)
        //{
        //    throw new System.NotImplementedException();
        //}

        //IEnumerable<FileInfo> IFileReaderable.GetOnlyLogFiles(string path)
        //{
        //    throw new System.NotImplementedException();
        //}

        public IEnumerable<FileInfo> GetAllFilesFromPath(string path)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<FileInfo> GetOnlyLogFiles(string path)
        {
            throw new System.NotImplementedException();
        }
    }
}
