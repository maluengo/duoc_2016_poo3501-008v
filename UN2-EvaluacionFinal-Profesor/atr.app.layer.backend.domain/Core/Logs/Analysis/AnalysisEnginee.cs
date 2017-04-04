using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using atr.app.layer.backend.domain.Contracts;
using atr.app.layer.backend.dto.Analysis;
using atr.app.layer.backend.dto.Files;

namespace atr.app.layer.backend.domain.Core.Logs.Analysis
{
    /// <summary>
    /// ATR: Clase, que contiene el core de análisis de los archivos de logs solicitados. 
    /// </summary>
    public  class AnalysisEnginee: IAnalyzisable
    {

        /// <summary>
        /// ATR: Obtiene, a partir de un archivo log seleccionado, los mensajes detectados y analizados en sus 
        /// líneas a partir de los criterios previamente seleccionados (error, warning o info). 
        /// </summary>
        /// <param name="objLog"></param>
        /// <returns></returns>
        public IEnumerable<LogAnalysisMessageFindedDto> GetSelectedMessagesInLogsByFile(LogDto objLog, IEnumerable<LogAnalysisResultDto> allFilesWithResults)
        {
            List<LogAnalysisMessageFindedDto> collectionOfMessages = null;

            if (!object.ReferenceEquals(objLog, null) && !object.ReferenceEquals(allFilesWithResults, null))
            {
                foreach (var obj in allFilesWithResults.Where(x=> string.Equals(x.LogObjectAnalyzed.FileName, 
                    objLog.FileName, StringComparison.InvariantCulture)))
                {
                    collectionOfMessages = obj.LogMessagesAnalyzed.ToList();
                } 
            }   

            return collectionOfMessages;

        }
           
        
        /// <summary>
        /// ATR: Filtra, a partir de una colección de archivos, aquellos con las palabras ingresadas como argumentos.
        /// Por defecto, acepta: ERROR, INFO y WARNING. 
        /// </summary>
        /// <param name="objLogToAnalyze"></param>
        /// <param name="searchOptions"></param>
        /// <returns></returns>
       public IEnumerable<LogAnalysisMessageFindedDto> GetAnalysisResults(LogDto objLogToAnalyze, AnalysisOptionsDto searchOptions)
       {
           List<LogAnalysisMessageFindedDto> objResult = new List<LogAnalysisMessageFindedDto>();

            if (!object.ReferenceEquals(searchOptions, null) && !object.ReferenceEquals(objLogToAnalyze, null))
            {
                var collectionOfLines = File.ReadAllLines(objLogToAnalyze.FileName).ToList();
                
                foreach (var line in collectionOfLines.Where(x => !string.IsNullOrWhiteSpace(x)))
                {
                    objResult.Add(new LogAnalysisMessageFindedDto()
                    {
                      //Buscará una coincidencia por iteración.  La lógica de búsqueda implica, por coherencia funcional.
                      //que se debería de seleccionar sólo una opción (o ERROR, o WARNING o INFO). 
                        MessageInfo    =  searchOptions.IsInfoAnalysisEnabled  && line.Contains("info") ? line : string.Empty,
                        MessageWarning = searchOptions.IsWarningAnalysisEnabled && line.Contains("warning") ? line : string.Empty,
                        MessageError   = searchOptions.IsErrorAnalysisEnabled && line.Contains("error") ? line: string.Empty,
                        TimeStamp      = line.Split(Convert.ToChar("]"))[0]
                        
                    });
                    
                }

            }



           return objResult;
           
       }

        /// <summary>
        /// ATR: Método principal, ordena en un par ordenado (Key, value) el objeto Log a analizar y una colección
        /// de resultados a partir de las opciones de búsqueda ingresadas como argumentos. 
        /// </summary>
        /// <param name="objLogToAnalyze"></param>
        /// <param name="searchOptions"></param>
        /// <returns></returns>
       public IEnumerable<LogAnalysisResultDto> GetResultsConsolidated(IEnumerable<LogDto> objLogToAnalyze, AnalysisOptionsDto searchOptions)
       {
           List<LogAnalysisResultDto> objResult = null;

           if (!object.ReferenceEquals(objLogToAnalyze, null) && (!object.ReferenceEquals(searchOptions, null)))
           {
               if (objLogToAnalyze.Any())
               {
                   objResult = new List<LogAnalysisResultDto>();

                   foreach (var objLog in objLogToAnalyze.ToList().Where(x => !x.Equals(default(LogDto))))
                   {
                        objResult.Add(new LogAnalysisResultDto()
                        {
                            LogMessagesAnalyzed = GetAnalysisResults(objLog, searchOptions) ,
                            LogObjectAnalyzed   = objLog
                        });
                       
                   }
               }
           }
            

            return objResult;
           
       }



    }
}
