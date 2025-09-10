namespace _20250910
{
    class BJ2979
    {
        static void Main()
        {

            // 1대면 5 2대명 3 3대면 1
            string[] input = Console.ReadLine()!.Split();
            int cost = 0;
            int[] array = new int[100];

            
            for (int i = 0; i < input.Length; i++)
            {
                string[] time = Console.ReadLine()!.Split();
                int x = int.Parse(time[0]);
                int y = int.Parse(time[1]);

                for (int j = x;  j < y; j++)
                {
                    array[j]++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1) cost += array[i] * int.Parse(input[0]);
                else if (array[i] == 2) cost += array[i] * int.Parse(input[1]);
                else if (array[i] == 3) cost += array[i] * int.Parse(input[2]);
            }

            Console.WriteLine(cost);
        }
    }
}
