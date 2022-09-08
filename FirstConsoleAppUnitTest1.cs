using CodeJam;

namespace FirstConsoleApp.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        System.Console.WriteLine("==== Tests started =====");
    }

    [Test]
    public void Test1()
    {
        Employee epl = new Employee("Liu", "Jo", 3, 7);
        int income = epl.getIncomeSum(2000);

        Code.BugIf((income < 2000) || (income > 2000), "Income value was calculated wrong!");
    }

    [Test]
    public void Test2()
    {
        Employee epl = new Employee("Hong", "Kong", 5, 7);
        int income = epl.getIncomeSum(2000);

        Code.BugIf((income < 2000) || (income > 2000), "Income value was calculated wrong!");
    }

    [Test]
    public void Test3()
    {
        Employee epl = new Employee("Hong", "Kong", 8, 7);
        int income = epl.getIncomeSum(2000);

       Code.BugIf((income < 2200) || (income > 2200), "Income value was calculated wrong!");
    }

    [Test]
    public void Test4()
    {
        Employee epl = new Employee("Chang", "Pun", 2, 10);
        int income = epl.getIncomeSum(2000);

        Code.BugIf((income < 2000) || (income > 2000), "Income value was calculated wrong!");
    }

    [Test]
    public void Test5()
    {
        Employee epl = new Employee("Shiu", "Lee", 2, 15);
        int income = epl.getIncomeSum(2000);

        Code.BugIf((income < 2300) || (income > 2300), "Income value was calculated wrong!");
    }

    [Test]
    public void Test6()
    {
        Employee epl = new Employee("Jacky", "Chang", 10, 17);
        int income = epl.getIncomeSum(3000);

        Code.BugIf((income < 3795) || (income > 3795), "Income value was calculated wrong!");
    }

    [Test]
    public void Test7()
    {
        Employee epl = new Employee("Umi", "Jan", 10, 18);
        int income = epl.getIncomeSum(0);

        Code.BugIf(-1 != -1, "Income value was calculated wrong!");
    }

    [Test]
    public void Test8()
    {
        Employee epl = new Employee("Kim", "Chen", 10, 18);
        int income = epl.getIncomeSum(-1000);

        Code.BugIf(-1 != -1, "Income value was calculated wrong!");
    }

     [Test]
    public void Test9()
    {
        Employee epl = new Employee("Kim", "Chen", 10, 18);
        int income = epl.getIncomeSum(-1000);

        Code.BugIf(-1 != -1, "Income value was calculated wrong!");
    }

     [Test]
    public void Test10()
    {
        Employee epl = new Employee("Ciao", "Mun", -10, 18);
        int income = epl.getIncomeSum(3000);

        Code.BugIf(-1 != -1, "Income value was calculated wrong!");
    }

     [Test]
    public void Test11()
    {
        Employee epl = new Employee("Wang", "Wei", 10, 0);
        int income = epl.getIncomeSum(3000);

        Code.BugIf(-1 != -1, "Income value was calculated wrong!");
    }

     [Test]
    public void Test12()
    {
        Employee epl = new Employee("Li", "Fang", 10, -15);
        int income = epl.getIncomeSum(3000);

        Code.BugIf(-1 != -1, "Income value was calculated wrong!");
    }
}

