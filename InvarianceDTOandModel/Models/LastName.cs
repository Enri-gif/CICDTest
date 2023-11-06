using System.Text.RegularExpressions;

namespace ValidateTheNameModelBinding.Models
{
    public class LastName
    {
        private string _lastName;

        public string GetLastName()
        {
            return _lastName;
        }
        private void validateLastName(string LastName)
        {
            if(LastName != null && LastName.Length >= 2 && LastName.Length <= 20)
            {
                string pattern = @"^[a-zA-Z]+$";
                if(!Regex.IsMatch(LastName, pattern))
                    throw new Exception("Name is invalid");
            }
            else
                throw new Exception("Name must not be null and must be between 2 and 20 characters");
        }

        public LastName(string lastName)
        {
            validateLastName(lastName);
            _lastName = lastName;
        }
    }
}