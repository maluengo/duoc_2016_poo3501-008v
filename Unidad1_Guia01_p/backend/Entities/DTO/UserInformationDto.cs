using System; 

namespace backend.Entities.DTO
{
/// <summary>
/// ATR: POCO Class, that allows serialization
/// </summary>
    [Serializable]
    public sealed class UserInformationDto
    {
        public string userName { get; set; }
        public string passWord { get; set; }

    }
}
