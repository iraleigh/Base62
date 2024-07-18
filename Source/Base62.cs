using System;
using System.Text;

namespace Source;

public static class Base62
{
    public static string ToBase62String(byte[] bytes)
    {
        var sb = new StringBuilder();

        foreach (byte b in bytes)
        {
            sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
        }

        return sb.ToString();
    }
}
