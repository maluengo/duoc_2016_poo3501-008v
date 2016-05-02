using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using backend.Entities.DTO;

namespace backend.Functionality.AppConfigReader
{
    public class ConfigReader
    {
        public UserInformationDto GetUserInformationFromConfig(string sufixToSearch)
        {
            var objFinded = default(UserInformationDto);     

            if (!string.IsNullOrEmpty(sufixToSearch))
            {
                var auxPassByUserKey = ConfigurationManager.AppSettings[sufixToSearch];

                if (!string.IsNullOrEmpty(auxPassByUserKey))
                {
                    objFinded = new UserInformationDto()
                    {
                        userName = (sufixToSearch),
                        passWord = auxPassByUserKey
                    };
                }

            }

            return objFinded; 
        }
        
        public List<UserInformationDto> GetAllUserInfoBySufix(string sufix)
        {
            var allSettings         = ConfigurationManager.AppSettings.AllKeys.ToList();
            var listOfUsersInConfig = default(List<UserInformationDto>);

            if (!string.IsNullOrEmpty(sufix))
            {
                if (allSettings.Any())
                {
                    listOfUsersInConfig = new List<UserInformationDto>();
                    for (var userData = 0; userData < allSettings.Count; userData++)
                    {

                        listOfUsersInConfig.Add(GetUserInformationFromConfig(sufix));

                    }
                }
            }

            return listOfUsersInConfig;
        } 


    }
}
