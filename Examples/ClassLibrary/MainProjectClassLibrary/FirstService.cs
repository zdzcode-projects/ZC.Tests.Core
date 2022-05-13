using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjectClassLibrary
{
    public class FirstService
    {
        private readonly SecondService _secondService;

        public FirstService(SecondService secondService)
        {
            _secondService = secondService;
        }

        public bool IsValid(string email, string password)
        {
            if(!_secondService.IsValidEmail(email))
            {
                throw new Exception("Invalid email");
            }

            //TODO: Verify password

            return true;
        }
    }
}
