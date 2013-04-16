using System.Collections.Generic;

/// <summary>
/// Summary description for TestData
/// </summary>
public class TestData
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class TestDataList : List<TestData>
{

    /// <summary>
    /// Constructor
    /// 
    /// Just some test data
    /// </summary>
    public TestDataList()
    {
        AddRange(new[]
                     {
                         new TestData { FirstName = "Lucas", LastName = "Lim" },
                         new TestData { FirstName = "Dion", LastName = "Phaneuf" },
                         new TestData { FirstName = "Bernie", LastName = "Monette" },
                         new TestData { FirstName = "Sean", LastName = "Doyle" },
                         new TestData { FirstName = "Andre", LastName = "Martelli" }
                     });
    }
}
