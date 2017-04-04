using System;
using System.Linq;
using backend.Entities.DTO;
using backend.Functionality.AppConfigReader;

namespace backend.Domain.UserManager
{
    public class UserManager
    {
        /// <summary>
        /// ATR: Get a DTO with a User information already fill on it. 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public UserInformationDto GetSingleUserInformationByUserName(string userName)
        {
            var objResult = default(UserInformationDto);
            ConfigReader readerHelper = default(ConfigReader);
            

            if (!string.IsNullOrEmpty(userName))
            {
                readerHelper = new ConfigReader();

                var fixedUser = !userName.Contains("_") ? $"user_{userName}" : userName;

                if (!object.ReferenceEquals(readerHelper.GetAllUserInfoBySufix(fixedUser), null))
                {  

                    objResult = readerHelper.GetAllUserInfoBySufix(fixedUser).
                    FirstOrDefault(x => string.Equals(x.userName, fixedUser,
                    StringComparison.InvariantCultureIgnoreCase));

                }   

            }   

            return objResult;
        }

        /// <summary>
        /// ATR: Check if a specif user exist in AppSetting configuration. 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool IsUserExistInConfig(string userName)
        {
            var isExist = default(bool);

            if (!string.IsNullOrEmpty(userName))
            {
                var fixedUser = !userName.Contains("_") ? $"user_{userName}" : userName;
                isExist = !string.IsNullOrEmpty(new ConfigurationManagerFacade().GetAnyValueFromConfigByKey(fixedUser));
            }

            return isExist;
        }

    }
}
