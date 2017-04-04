using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atr.app.layer.backend.Contracts;

namespace atr.app.layer.backend.Factories
{
    /// <summary>
    /// Factory, abstracta, que permita instanciar cualquier clase que
    /// implemente una intefaz. 
    /// </summary>
    public class AbstractFactory
    {

        private IReaderable objParam = null;

        /// <summary>
        /// Constructor público, sobrecargado que recibe como argumento
        /// una instancia de cualquier clase, que implemente
        /// IReaderable. 
        /// </summary>
        /// <param name="objParam"></param>
        public AbstractFactory(IReaderable objParam)
        {
            if (!object.ReferenceEquals(objParam, null))
              //if(!object.ReferenceEquals(objParam, default(IReaderable)))
            {
                this.objParam = objParam;

            }

            
        }

        public AbstractFactory()
        {
            
        }

        /// <summary>
        /// Método, que permita retorna la instancia de la propiedad privada.
        /// objParam. 
        /// </summary>
        /// <returns></returns>
        public IReaderable GetInstance()
        {
            return this.objParam;
        }

    }
}
