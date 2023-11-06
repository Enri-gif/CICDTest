using System.Text.RegularExpressions;

namespace ValidateTheNameModelBinding.Models
{
    public class Person
    {
        private FirstName firstName;
        private LastName lastName;

        public Person(FirstName firstName, LastName lastName)
        {
            isFirstNameValid(firstName.GetFirstName());
            isLastNameValid(lastName.GetLastName());

            this.firstName = firstName; 
            this.lastName = lastName;
        }

        private void isFirstNameValid(string name)
        {
            ///Add Invariance validation Here
            /// Throw an Exception if the name is invalid
            
            if(name != null && name.Length >= 3 && name.Length <= 20)
            {
                string pattern = @"^[a-zA-Z]+$";
                if(!Regex.IsMatch(name, pattern))
                    throw new Exception("Name is invalid");
            }
            else
                throw new Exception("Name must not be null and must be between 3 and 20 characters");
        }
        private void isLastNameValid(string name)
        {
            ///Add Invariance validation Here
            /// Throw an Exception if the name is invalid
            
            if(name != null && name.Length >= 3 && name.Length <= 20)
            {
                string pattern = @"^[a-zA-Z]+$";
                if(!Regex.IsMatch(name, pattern))
                    throw new Exception("Name is invalid");
            }
            else
                throw new Exception("Name must not be null and must be between 3 and 20 characters");
        }
    }
}
