using System;
using System.Text;

namespace com.modime.Base64Decode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var base64Encoded = args[0];
                var base64Decoded = Encoding.UTF8.GetString(Convert.FromBase64String(base64Encoded));

                Console.WriteLine(base64Decoded);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Missing argument: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error processing argument: {e.Message}", e);
            }
        }
    }
}
