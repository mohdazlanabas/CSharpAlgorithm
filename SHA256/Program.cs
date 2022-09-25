
using System.Text;
using System.Security.Cryptography;

namespace SHA256File
{
    internal class Program
    {
        public static class Hashing
        {
            public static string ToSHA256(string s)
            {
                using var sha256 = SHA256.Create();
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
                var sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter String To Hash: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Hashed String: {Hashing.ToSHA256(input)}");
        }


    }
}