using System;
using System.Text;

namespace Source;

public static class Base62
{
    private const int MAX_SIZE = 62;
    private static char[] alphabet = new char[MAX_SIZE] 
    {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
    };
    public static string ToBase62String(byte[] bytes)
    {
        var sb = new StringBuilder();

        foreach (byte b in bytes)
        {
            sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
        }

        var bitString = sb.ToString();
        var length = bitString.Length;
        var lengthMod6 = length % 6;
        // TODO add carry

        for (int i = 0; i < length; i = i + 6)
        {
            var sixBitString = bitString.Substring(i, 6);
            var b = Convert.ToByte(sixBitString, 2);

            // TODO get char from alphabet and build string with it
        }

        return bitString;
    }
}
