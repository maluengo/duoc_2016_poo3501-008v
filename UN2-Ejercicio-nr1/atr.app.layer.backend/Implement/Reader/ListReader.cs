using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atr.app.layer.backend.Contracts;

namespace atr.app.layer.backend.Implement.Reader
{
    public class ListReader : IReaderable
    {
        /// <summary>
        /// Cuenta la cantidad de elementos sobre la coleccion
        /// </summary>
        /// <param name="listToCount"></param>
        /// <returns></returns>
        public int CountInList(List<string> listToCount)
        {
            var howMany = default(int);

            if (!object.ReferenceEquals(listToCount, null))
            {
                if (listToCount.Any())
                {
                    howMany = listToCount.Count;
                }
            }

            return howMany;
        }

        /// <summary>
        /// Retorna una coleccion de strings en duro. 
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllValues()
        {
            var collection = new List<string>();

            for (var i = 0; i < 10; i++)
            {
                collection.Add($"Registro nro {i}");
            }

            return collection;
        }
    }
}
