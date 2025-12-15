var random = new Random();
int[] nums = new int[10];
int kos = 0;
for (int i = 0; i < 10; i++)
{
    nums[i] = random.Next(-10, 11);
}
for (int i = 0; i < 10; i++)
{
    kos = kos + nums[i];
    Console.Write(nums[i]);
    Console.WriteLine();
}

Console.WriteLine("sum of elements");
Console.WriteLine(kos);

if (kos > 0)
{
    Console.WriteLine("Yes");
}
else Console.WriteLine("No");