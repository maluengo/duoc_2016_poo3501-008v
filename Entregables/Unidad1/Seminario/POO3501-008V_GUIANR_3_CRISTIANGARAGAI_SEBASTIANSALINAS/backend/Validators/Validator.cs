using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Validators
{
    public class Validator
    {
        public bool validDistrit(string distritos)
        {
            int zero = default(int);
            bool validDistrit = default(bool);

            if (!string.IsNullOrEmpty(distritos))
                validDistrit = int.TryParse(distritos, out zero);

            return validDistrit;
        }

        public bool validCandidates(string candidatos)
        {
            int zero = default(int);
            bool validCandidates = default(bool);

            if (!string.IsNullOrEmpty(candidatos))
                if (int.TryParse(candidatos, out zero))
                {
                    validCandidates = true;
                }
                else
                {
                    validCandidates = false;
                }

            return validCandidates;
        }
    }
}
