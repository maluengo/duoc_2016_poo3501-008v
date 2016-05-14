using atr.app.layer.backend.domain.Contracts;
using atr.app.layer.backend.repository.Contracts;

namespace atr.app.layer.backend.repository
{
    public class RepositoryFactory
    {
        private IFileReaderable objFileReader = null;
        private ILogCheckerable objLogChecker= null;

        public RepositoryFactory()
        {
            
        }

        public RepositoryFactory(IFileReaderable objFileReaderable)
        {
            if (!object.ReferenceEquals(objFileReaderable, null))
            {
                if (!objFileReaderable.Equals(default(IFileReaderable)))
                {
                    this.objFileReader = objFileReaderable;
                }
            }
            
        }

        public RepositoryFactory(ILogCheckerable objLogCheckerable)
        {
            if (!object.ReferenceEquals(objLogCheckerable, null))
            {
                if (!objLogCheckerable.Equals(default(ILogCheckerable)))
                {
                    this.objLogChecker = objLogCheckerable;
                }
            }

        }


        public ILogCheckerable GetInstanceOfCheckerable()
        {
            return this.objLogChecker;
        }

        public IFileReaderable GetFileReaderable()
        {
            return this.objFileReader;
        }

    }
}
