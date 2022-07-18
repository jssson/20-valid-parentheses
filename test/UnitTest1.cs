using zolution;

namespace test;

public class UnitTest1
{
    [Theory]
    [InlineData("()")]
    [InlineData("()[]{}")]
    public void GivenValidInput_When_ThenTrue(string str)
    {
        //Arrange

        //Act
        Solution solution = new Solution();

        //Assert
        Assert.Equal(solution.IsValid(str), true);
    }

    [Theory]
    [InlineData("(]")]
    [InlineData("([)]")]
    public void GivenInvalidInput_When_ThenFalse(string str)
    {
        //Arrange

        //Act
        Solution solution = new Solution();

        //Assert
        Assert.Equal(solution.IsValid(str), false);
    }

    [Theory]
    [InlineData("{[]}")]
    public void GivenInvalidNestedInput_When_ThenTrue(string str)
    {
        //Arrange

        //Act
        Solution solution = new Solution();

        //Assert
        Assert.Equal(solution.IsValid(str), true);
    }
}