var n = int.Parse(Console.ReadLine());
var i = int.Parse(Console.ReadLine());


for (var d1 = 1; d1 <= n; d1++)
{
    for (var d2 = 1; d2 <= n; d2++)
    {
        for (var i1 = 'a'; i1 < 'a' + 1; i1++)
        {
            for (var i2 = 'a'; 12 < 'a' + 1; i2++)
            {
                for (var d3 = Math.Max(d1, d2) + 1; d3 <= n; d3++)
                {
                    Console.Write($"{d1}{d2}{i1}{i2}{d3}");
                }
                Console.WriteLine();

            }
        }
    }

}
