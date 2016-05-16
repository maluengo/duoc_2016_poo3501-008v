using System.Collections.Generic;
using atr.app.layer.backend.dto.Analysis;
using atr.app.layer.backend.dto.Files;

namespace atr.app.layer.backend.domain.Contracts
{
    public interface IAnalyzisable
    {
        IEnumerable<LogAnalysisMessageFindedDto> GetAnalysisResults(LogDto objLogToAnalyze, 
            AnalysisOptionsDto searchOptions );

        IEnumerable<LogAnalysisResultDto> GetResultsConsolidated(IEnumerable<LogDto> objLogToAnalyze,
            AnalysisOptionsDto searchOptions);

        IEnumerable<LogAnalysisMessageFindedDto> GetSelectedMessagesInLogsByFile(LogDto objLog,
            IEnumerable<LogAnalysisResultDto> allFilesWithResults);




    }
}
