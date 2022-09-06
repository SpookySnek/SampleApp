using System.Text;

namespace SampleApp.Core;
public static class BinaryTranslator
{
    public static byte[] GetBytesFromBinaryString(String binary)
    {
        var list = new List<byte>();

        for (int i = 0; i < binary.Length; i += 8)
        {
            string t = binary.Substring(i, 8);

            list.Add(Convert.ToByte(t, 2));
        }

        return list.ToArray();
    }
    public static string TranslateToString(string raw)
    {
        return Encoding.ASCII.GetString(GetBytesFromBinaryString(raw));
    }
}

