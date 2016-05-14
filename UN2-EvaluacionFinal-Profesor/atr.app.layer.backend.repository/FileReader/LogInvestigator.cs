using System ;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using atr.app.layer.backend.dto.Files;
using atr.app.layer.backend.repository.Contracts;

namespace atr.app.layer.backend.repository.FileReader
{
    public class LogInvestigator: IFileReaderable
    {
        /// <summary>
        /// ATR: obtiene un archivo específico, por path.  El archivo debe 
        /// de ser de extensión .log. 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public LogDto GetFileByPath(string path)
        {
            var objLog = default(LogDto);

            try
            {
                if (File.Exists(path))
                {
                    var auxDirectory = GetDirectoryByPath(path);

                    //ATR: Si se le pasa un path con la direccion abosluta
                    //de un archivo, auxDirectory será null.  Para ello.
                    //Se obtendrá el directorio padre y continuará el flujo. 
                    if (object.ReferenceEquals(auxDirectory, null))
                    {
                        auxDirectory = new FileInfo(path).Directory;
                    }

                    if (auxDirectory.Exists)
                    {
                        var auxInfo = auxDirectory.GetFiles().FirstOrDefault
                            (x => x.FullName.Contains(path));

                        if (!object.ReferenceEquals(auxInfo, null))
                        {
                            objLog = new LogDto()
                            {
                                FileName = auxInfo.FullName,
                                Extension = auxInfo.Extension,
                                LogInfo = auxInfo
                            };
                        }
                    }

                }
            }
            catch (Exception)
            {
                return null;
            }
                            
            return objLog;
        }

        /// <summary>
        /// ATR: Obtiene y/o carga un directorio, a partir de un Path válido.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DirectoryInfo GetDirectoryByPath(string path)
        {
            var objDirectory = default(DirectoryInfo);

            try
            {
                if (Directory.Exists(path))
                {
                    objDirectory = new DirectoryInfo(path);
                }
            }
            catch (Exception ex)
            {
                return default(DirectoryInfo);
            }

            return objDirectory;
        }

        /// <summary>
        /// ATR: Obtiene todos los archivos disponibles en un directorio dado.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<LogDto> GetAllLogFilesByPath(string path)
        {
            var logsCollection = default(List<LogDto>);

            if (!object.ReferenceEquals(GetDirectoryByPath(path), null))
            {
                var extension = ".log";
                logsCollection = new List<LogDto>();

                logsCollection.AddRange(GetDirectoryByPath(path).GetFiles().Where(x=> 
                string.Equals(x.Extension, extension, StringComparison.CurrentCulture)).ToList().
                            Select(y => new LogDto()
                            {
                                FileName = y.FullName,
                                Extension = y.Extension,
                                LogInfo = y
                            }));
                

            }

            return logsCollection;
        }
    }
}
