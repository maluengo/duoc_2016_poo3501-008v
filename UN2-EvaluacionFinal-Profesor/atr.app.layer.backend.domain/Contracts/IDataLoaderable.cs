using System.Collections.Generic;
using atr.app.layer.backend.dto.Files;

namespace atr.app.layer.backend.domain.Contracts
{
    public interface IDataLoaderable
    {
        IEnumerable<LogDto> LoadAllData(string path);
    }
}
