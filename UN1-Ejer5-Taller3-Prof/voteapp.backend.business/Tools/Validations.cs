using voteapp.backend.entities.Enums;

namespace voteapp.backend.business.Tools
{
    public class  Validations
    {

        /// <summary>
        /// Valida si es número o no.
        /// </summary>
        /// <param name="valueToCheck"></param>
        /// <returns>True si es número</returns>
        public bool IsNumeric(string valueToCheck)
        {
            var isOk = false;

            if (!string.IsNullOrEmpty(valueToCheck))
            {
                var auxInt = default(int);
                isOk = int.TryParse(valueToCheck, out auxInt);
            }

            return isOk;
        }

        

    }
}
