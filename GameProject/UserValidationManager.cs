using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "Hasan" && gamer.LastName == "Karyağdı" && gamer.IdentityNumber == 12134)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
