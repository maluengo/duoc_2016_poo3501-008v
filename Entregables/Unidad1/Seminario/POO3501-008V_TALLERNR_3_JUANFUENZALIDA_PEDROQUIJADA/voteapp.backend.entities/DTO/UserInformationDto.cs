using System; 

namespace backend.Entities.DTO
{
    [Serializable]
    public sealed class UserInformationDto
    {
        public string userName { get; set; }
        public string passWord { get; set; }

    }
}
