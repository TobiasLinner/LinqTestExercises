namespace LinqExercises.Tests;
using LinqExercises.Core;
public class LinqTests
{
    private readonly List<User> _users;

    public LinqTests()
    {
        _users = TestData.GetTestUsers();
    }

    [Fact]
    public void Test1_ShouldFilterUsersFromSweden()
    {
        // 1. Använd Where() för att sortera ut alla användare i listan som kommer från exempelvis "Sweden".
        var result = _users.ToList();

        Assert.Equal(25, result.Count());
    }

    [Fact]
    public void Test2_ShouldFilterUsersWithLastNameStartingWithS()
    {
        // 2. Använd Where() för att hitta alla användare vars efternamn börjar på "S".
        var result = _users.ToList();
        Assert.Equal(32, result.Count());
    }

    [Fact]
    public void Test2b_ShouldFilterUsersLoggedInLastWeek()
    {
        // 2b. Använd Where() för att hitta alla användare som loggat in den senaste veckan
        var result = _users.ToList();

        Assert.Equal(9, result.Count());
    }

    [Fact]
    public void Test3_ShouldSortUsersByFirstName()
    {
        // 3. Använd OrderBy() för att sortera användarna i listan efter deras förnamn.
        var result = _users.ToList();

        Assert.Equal("Alexander", result.First().FirstName);
    }

    [Fact]
    public void Test4_ShouldFindUserWithMostDataStored()
    {
        // 4. Använd OrderByDescending() och FirstOrDefault() för att hitta den användare som har mest DataStored.
        var result = _users.First();
        Assert.Equal(9999999, result.DataStored);
    }


    [Fact]
    public void Test5_ShouldSortUsersByCountryThenLastName()
    {
        // 5. Använd OrderBy() och ThenBy() för att sortera användare efter land och sedan efter efternamn.
        var result = _users.ToList();

        Assert.Equal("Germany", result.First().Country);
    }

    [Fact]
    public void Test6_ShouldProjectEmails()
    {
        // 6. Använd Select() för att skapa en ny lista innehållandes bara användarnas email.
        var result = new[] { "invalid-email" };
        Assert.True(result.All(email => email.Contains("@")));
    }

    [Fact]
    public void Test7_ShouldProjectFirstNameAndEmail()
    {
        // 7. Använd Select() för att skapa en lista av anonyma objekt med FirstName och Email.
        var result = _users.Take(3);
        Assert.Equal(99, result.Count());
    }

    [Fact]
    public void Test8_ShouldGetEmailsOfUsersWithDataStorageOver5000()
    {
        // 8. Använd Where() och Select() för att få en lista med e-postadresser från användare som har lagrat mer än 5000 dataenheter.
        var result = _users;
        Assert.Equal(98, result.Count());
    }

    [Fact]
    public void Test9_ShouldCheckIfUsersFromUSAExist()
    {
        // 9. Använd Any() för att kontrollera om det finns någon användare från "USA".
        bool result = false;
        Assert.True(result);
    }

    [Fact]
    public void Test10_ShouldVerifyAllUsersHaveValidEmail()
    {
        // 10. Använd All() för att kontrollera om alla användare har en giltig e-postadress (innehåller '@').
        var result = false;
        Assert.True(result);
    }

    [Fact]
    public void Test11_ShouldCheckIfUserNamedAnnaExists()
    {
        // 11. Använd Select() och Contains() för att kontrollera om det finns någon användare med förnamnet "Anna".
        var result = false;
        Assert.True(result);
    }

    [Fact]
    public void Test12_ShouldGetDistinctCountries()
    {
        // 12. Använd Select() med Distinct() för att få en lista med unika länder som användarna kommer ifrån.
        var result = new List<string> { "USA" };
        Assert.Equal(5, result.Count());
    }

    [Fact]
    public void Test13_ShouldFindFirstUserWithSpecificLastName()
    {
        // 13. Använd FirstOrDefault() för att hitta den första användaren med ett specifikt efternamn.
        var result = new { LastName = "0" };
        Assert.Equal("Smith", result.LastName);
    }


    // Test16-20 - Aggregate functions
    [Fact]
    public void Test16_ShouldFindHighestDataStored()
    {
        // 16. Använd Max() för att hitta det högsta värdet av DataStored.

        var result = 0;
        Assert.Equal(9999999, result);
    }

    [Fact]
    public void Test17_ShouldFindYoungestAge()
    {
        // 17. Använd Min() för att hitta den lägsta åldern bland användarna (Kanske lite klurig)
        var result = 0;
        Assert.Equal(29, result);
    }

    [Fact]
    public void Test18_ShouldCountUsersBornBefore2000()
    {
        // 18. Använd Count() för att räkna hur många användare som är födda före år 2000.
        var result = 0;
        Assert.Equal(99, result);
    }

    [Fact]
    public void Test19_ShouldSumTotalDataStored()
    {
        // 19. Använd Sum() för att beräkna den totala mängden lagrad data av alla användare.
        var result = 0;
        Assert.Equal(10869199, result);
    }

    [Fact]
    public void Test20_ShouldCalculateAverageDataStored()
    {
        // 20. Använd Average() för att beräkna den genomsnittliga mängden lagrad data per användare.
        var result = 0;
        Assert.Equal(109789.89, result, 2);
    }

    // Test21-22 - Aggregate operations
    [Fact]
    public void Test21_ShouldCalculateTotalDataStoredUsingAggregate()
    {
        // 21. Använd Aggregate() för att beräkna den totala mängden lagrad data av alla användare (int).
        var result = 0;
        Assert.Equal(10869199, result);
    }

    [Fact]
    public void Test22_ShouldConcatenateFullNames()
    {
        // 22. Använd Select() och Aggregate() för att sammanfoga alla användares fullständiga namn till en enda sträng.
        var result = "0";

        Assert.StartsWith("Alexander Schneider, Alice Söderqvist", result);
        Assert.EndsWith("William Taylor", result);
    }

    // Test23-26 - Take/Skip operationsdocc
    [Fact]
    public void Test23_ShouldTakeFirst10Users()
    {
        // 23. Använd Take() för att ta de första 10 användarna i listan.
        var result = Array.Empty<string>();
        Assert.Equal(10, result.Count());
    }

    [Fact]
    public void Test24_ShouldSkipFirst90Users()
    {
        // 24. Använd Skip() för att hoppa över de första 90 användarna i listan.
        var result = Array.Empty<string>();
        Assert.Equal(9, result.Count());
    }

    [Fact]
    public void Test25_ShouldTakeWhileDataStoredAbove10000()
    {
        // 25. Använd TakeWhile() för att ta alla användare tills en användare med mindre än 10000 DataStored dyker upp.
        var result = new List<User> { new User { DataStored = 9000 } };
        Assert.True(result.All(u => u.DataStored >= 10000));
    }

    [Fact]
    public void Test26_ShouldSkipWhileDataStoredAbove10000()
    {
        // 26. Använd SkipWhile() för att hoppa över alla användare tills en användare med mindre än 10000 DataStored dyker upp.
        var result = new List<User> { new User { DataStored = 11000 } };
        Assert.True(result.First().DataStored < 10000);
    }

    // Test28 - GroupBy operations

    [Fact]
    public void Test28_ShouldFindCountryWithHighestTotalDataStored()
    {
        // 28. Hur kan du ta reda på vilket land som har användare med högst totala DataStored?
        //Alltså, räkna ihop den totala DataStored per land och skriv ut det land som ligger högst.
        //Använd dig av så mkt LINQ som möjligt, ex Sum() och Max().
        var result = "Norway";
        Assert.Equal("Sweden", result);
    }
}