Console.WriteLine("Введите чила М");
string[] M = Console.ReadLine()!.Split(' ');

int count = 0;
for (int i = 0; i < M.Length; i++)
    if (int.Parse(M[i]) > 0)
        count++;

System.Console.WriteLine(count);