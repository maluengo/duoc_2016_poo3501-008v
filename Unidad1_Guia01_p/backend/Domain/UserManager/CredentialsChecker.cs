using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Entities.DTO;

namespace backend.Domain.UserManager
{
    public class CredentialsChecker
    {
        public bool CheckIfCredentialsAreOk(UserInformationDto userDto)
        {
            var areOk = false;
            UserManager userManagerHelper = null;

            if (!object.ReferenceEquals(userDto, null))
            {
                if (!string.IsNullOrEmpty(userDto.userName) && (!string.IsNullOrEmpty(userDto.passWord)))
                {
                    userDto.userName = $"user_{userDto.userName}";
                    userManagerHelper = new UserManager();

                    if (userManagerHelper.IsUserExistInConfig(userDto.userName))
                    {
                        var auxUserInformationFromConfig =
                            userManagerHelper.GetSingleUserInformationByUserName(userDto.userName);

                        areOk = !object.ReferenceEquals(auxUserInformationFromConfig, null) &&
                                string.Equals(auxUserInformationFromConfig.userName, userDto.userName)
                                && string.Equals(auxUserInformationFromConfig.passWord, userDto.passWord);

                    }
                }
            }



            return areOk;
        }
    }
}
