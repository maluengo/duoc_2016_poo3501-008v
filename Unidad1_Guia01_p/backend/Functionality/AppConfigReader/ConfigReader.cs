using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using backend.Entities.DTO;

namespace backend.Functionality.AppConfigReader
{
    /// <summary>
    /// ATR: Public class that allows to read an config file with specific AppSetting Key Value paris. 
    /// </summary>
    public class ConfigReader
    {
        /// <summary>
        /// ATR: Search inside de AppConfig in all the Keys, for a specific Key with a sufix!. Return an
        /// specific Key Value pair in a DTO object. 
        /// </summary>
        /// <param name="sufixToSearch"></param>
        /// <returns></returns>
        public UserInformationDto GetUserInformationFromConfig(string sufixToSearch)
        {
            var objFinded = default(UserInformationDto);     

            if (!string.IsNullOrEmpty(sufixToSearch))
            {
                //ATR: Here, we search for a specific Key, and return the value! Be careful, we
                //need to pass a sufix with this format. KEYNUMBER.
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

        /// <summary>
        /// ATR: Return all the Key Value Paris, in a DTO object, that match for a specific Key with sufix. 
        /// </summary>
        /// <param name="sufix"></param>
        /// <returns></returns>
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
