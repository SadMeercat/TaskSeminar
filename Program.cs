int [] data = new int [] {0, 1, 1, 0, 1, 0, 1, 0, 1 };
int [] info = new int [] {2, 3, 4, 1 };

for (int i = 0; i < info.Length; i++)
{
    double tempPow = 0;
    int powCount = 0;
    for (var j = info[i] - 1; j >= 0; j--)
    {
        if(powCount == 0 && data[j] == 0)
        {
            powCount++;
            continue;
        }
        tempPow += Math.Pow(data[j] * 2, powCount);
        powCount++;
    }
    Console.WriteLine("Result " + tempPow);
}