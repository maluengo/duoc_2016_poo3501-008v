using System.Collections.Generic;
using atr.app.layer.backend.domain.Contracts;
using atr.app.layer.backend.dto.Files;
using atr.app.layer.backend.repository;
using atr.app.layer.backend.repository.FileReader;

namespace atr.app.layer.backend.domain.Source
{
    public class DataLoader: IDataLoaderable
    {


        /// <summary>
        /// ATR: Carga todos los archivos, de extensión .log, en una colección genérica.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IEnumerable<LogDto> LoadAllData(string path)
        {
            var objDto            = default(List<LogDto>);
            var repositoryFactory = default(RepositoryFactory);

            if (!string.IsNullOrEmpty(path))
            {
                repositoryFactory = new RepositoryFactory(new LogInvestigator());

                var injectedInstance = repositoryFactory.GetFileReaderable();

                if (!object.ReferenceEquals(injectedInstance, null))
                {
                    objDto = injectedInstance.GetAllLogFilesByPath(path);
                }


            }


            return objDto;
        }
    }
}
