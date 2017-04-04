using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._3.App.Back.AppConfig;
using _2._4.App.Back.Entities;

namespace _2._4.App.Back.Credentials
{
    public class CredentialsValidations
    {

        public bool isCredentialsValid(CredentialsDto userDto)
        {
            var isOk = false;
            var configHelper = default(AppConfigReader);

            if (!object.ReferenceEquals(userDto, null))
            {
                if (!string.IsNullOrEmpty(userDto.passWord) && !string.IsNullOrEmpty(userDto.userName))
                {
                    configHelper = new AppConfigReader();

                    isOk = string.Equals(userDto.passWord, configHelper.GetValueFromKey("password"),
                        StringComparison.InvariantCultureIgnoreCase)
                           &&
                           string.Equals(userDto.userName, configHelper.GetValueFromKey("user"),
                               StringComparison.InvariantCultureIgnoreCase);
                }
            }


            return isOk;
        }


    }
}
