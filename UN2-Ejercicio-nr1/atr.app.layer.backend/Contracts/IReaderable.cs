using System.Collections.Generic;

namespace atr.app.layer.backend.Contracts
{
    public interface IReaderable
    {
        //métodos no concretos.
        //Operation Contract.
        int CountInList(List<string> listToCount);
        List<string> GetAllValues();
    }
}
