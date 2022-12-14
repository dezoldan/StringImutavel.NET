namespace stringsImutavel.net
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Olá, ";
            Console.Write($"O conteúdo de s1 é: \n");
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine($"s[{i}] = '{s1[i]}' ('\\u{(int)s1[i]:x4}')");
            }
            string s2 = "Daniel";
            string s3 = s1;
            Console.Write($"O conteúdo de s3 é: \n");
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine($"s[{i}] = '{s1[i]}' ('\\u{(int)s1[i]:x4}')");
            }
            s1 += s2;
            Console.Write("O conteúdo de s1 agora é: \n");
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine($"s[{i}] = '{s1[i]}' ('\\u{(int)s1[i]:x4}')");
            }
            Console.Write("O conteúdo de s3 é: \n");
            for (int i = 0; i < s3.Length; i++)
            {
                Console.WriteLine($"s[{i}] = '{s3[i]}' ('\\u{(int)s3[i]:x4}')");
            }
        }
    }
}