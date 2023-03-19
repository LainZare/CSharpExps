namespace Exp3
{
    internal class Program
    {
        const int ASCII_LENGTH = 128;

        static void Main(string[] args)
        {
            Console.WriteLine("请输入一段字符串");
            string? input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("无输入，无字符");
            }
            else
            {
                AnalyzeInput2(input);
            }
        }

        // 预先为每个ASCII码分配空间，index即为字符对应的ASCII码。
        static void AnalyzeInput1(string input)
        {
            int[] charactors = new int[ASCII_LENGTH];
            foreach (char c in input)
            {
                charactors[c] += 1;
            }

            Console.WriteLine("该字符串中各字符数量为");
            for (int i = 0; i < ASCII_LENGTH; i++)
            {
                if (charactors[i] != 0)
                {
                    Console.WriteLine($"\"{(char)i}\": {charactors[i]} 个");
                }
            }
        }

        static void AnalyzeInput2(string input)
        {
            Dictionary<char, int> charactors = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (charactors.Keys.Contains(c))
                {
                    charactors[c] += 1;
                }
                else
                {
                    charactors.Add(c, 1);
                }
            }
            Console.WriteLine("该字符串中各字符数量为");
            foreach (var c in charactors)
            {
                Console.WriteLine($"\"{c.Key}\": {c.Value} 个");
            }
        }
    }
}