using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public DirectoryInfo LoadDirectory(string path)
        {
            var objDirectory = default(DirectoryInfo);

            if (IsPathValid(path))
            {
                objDirectory = new DirectoryInfo(path);
            }

            return objDirectory;
        }

        public bool IsPathValid(string path)
        {
            var isValid = false;

            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    isValid = File.Exists(path);
                }
                catch (Exception)
                {
                    
                }

            }    

            return isValid;
        }

        

        public IEnumerable<FileInfo> GetAllFilesFromPath(string path)
        {
            List<FileInfo> collectionOfFiles = default(List<FileInfo>);

            if (!string.IsNullOrEmpty(path))
            {
                if (IsPathValid(path))
                {
                    collectionOfFiles = this.LoadDirectory(path).GetFiles().ToList();
                }
            }
                
            return collectionOfFiles;
            
        }

        public IEnumerable<FileInfo> GetOnlyLogFiles(string path)
        {
            throw new System.NotImplementedException();
        }
    }
}
