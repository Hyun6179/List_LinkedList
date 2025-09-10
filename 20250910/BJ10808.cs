using System.Text;

namespace _20250910
{
    class BJ10808
    {
        static void Main()
        {
            string input = Console.ReadLine()!;
            string array = "abcdefghijklmnopqrstuvwxyz";
            int[] result = new int[26];

            StringBuilder sb = new StringBuilder();

            sb.Append(input);

            for (int i = 0; i < sb.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (sb[i] == array[j])
                    {
                        result[j]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
