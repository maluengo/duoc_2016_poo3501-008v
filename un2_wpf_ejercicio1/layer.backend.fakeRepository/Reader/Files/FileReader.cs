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
                    isValid = Directory.Exists(path);
                }
                catch (Exception ex)
                {
                    //Usar su gestor de log favorito. 
                    //(nlog, log4net)
                    //if(!object.ReferenceEquals(ex.InnerException))

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

        /// <summary>
        /// Obtener solo archivos con extension .Log. 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IEnumerable<FileInfo> GetOnlyLogFiles(string path)
        {
            //List<FileInfo> collectionResult = default(List<FileInfo>);

            //if (this.IsPathValid(path))
            //{
            //    var auxDirectory = this.LoadDirectory(path);

            //    if (!object.ReferenceEquals(auxDirectory, null))
            //    {
            //        collectionResult = auxDirectory.GetFiles().ToList()
            //            .Where(x=> string.Equals(x.Extension, 
            //            ".log", StringComparison.InvariantCulture))
            //            .ToList();


            //    }
            //}

            List<FileInfo> collectionResult = default(List<FileInfo>);

            if (!string.IsNullOrEmpty(path))
            {
                collectionResult = this.GetAllFilesFromPath(path).Where
                (x => string.Equals(x.Extension, ".log",
                    StringComparison.InvariantCulture)).ToList();
            }


            return collectionResult;

        }

    }
}
