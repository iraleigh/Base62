using Source;

namespace Tests;

public class Base62Tests
{
    [Fact]
    public void ToBase62String_ShouldBe_ABitString()
    {
        var output = Base62.ToBase62String(new byte[2] { 0, 1 });
        Assert.Equal("0000000000000001", output);
    }
}