using System;
using System.Linq;
using backend.Entities.DTO;
using backend.Functionality.AppConfigReader;

namespace backend.Domain.UserManager
{
    public class UserManager
    {
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
