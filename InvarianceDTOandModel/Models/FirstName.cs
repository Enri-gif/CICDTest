using System.Text.RegularExpressions;

public class FirstName
{
    private string _firstName;

    public string GetFirstName()
    {
        return _firstName;
    }
    private void validateFirstName(string FirstName)
    {
        if(FirstName != null && FirstName.Length >= 2 && FirstName.Length <= 20)
        {
            string pattern = @"^[a-zA-Z]+$";
            if(!Regex.IsMatch(FirstName, pattern))
                throw new Exception("Name is invalid");
        }
        else
            throw new Exception("Name must not be null and must be between 2 and 20 characters");
    }

    public FirstName(string firstName)
    {
        //validateFirstName(firstName);
        _firstName = firstName;
    }
}