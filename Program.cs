namespace stringsImutavel.net
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Olá, ";
            string s2 = "Daniel";
            string s3 = s1;
            s1 += s2;
            // s1 agora contém o novo objeto: Olá, Daniel, mas s3 é uma referência para a posição
            // original na memória, que contém Olá,.
            Console.Write($"{s3}");            
            // Saída: Olá,
        }
    }
}