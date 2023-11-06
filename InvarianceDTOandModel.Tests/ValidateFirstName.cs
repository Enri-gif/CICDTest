namespace InvarianceDTOandModel.Tests;

public class ValidateFirstName
{
    [Theory]
    [InlineData("test")]
    public void ValidateFirstNameLengthNoException(string name)
    {
        var exception = Record.Exception
        (
            ()=> new FirstName(name)
        );
        Assert.Null(exception);
    }
}