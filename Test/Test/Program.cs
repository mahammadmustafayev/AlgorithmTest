namespace Test;

public class Program
{
    static void Main(string[] args)
    {
        ChangeNegativeValue();
    }
    public static void ChangeNegativeValue()
    {
        int[] nums = { -21, 1, 2, -67, -5, 31, 98 };
        string res = string.Join(", ", nums);
        Console.WriteLine(res);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                nums[i] = -nums[i];
            }
        }
        Console.WriteLine(new string('-', 30));
        string result = string.Join(", ", nums);
        Console.WriteLine(result);
    }
    public static void ChangeSmallOrHigher()
    {
        int small = 0;
        int high = 0;
        int[] nums = { 5, 1, 12, 4, 87, 23, 6 };
        string res = string.Join(", ", nums);
        Console.WriteLine(res);

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[small])
            {
                small = i;
            }
            if (nums[i] > nums[high])
            {
                high = i;
            }
        }
        int temp = nums[small];
        nums[small] = nums[high];
        nums[high] = temp;
        Console.WriteLine(new String('-', 30));
        string result = string.Join(", ", nums);
        Console.WriteLine(result);
    }
    public static void CheckSmall()
    {
        int[] nums = { 5, 3, 10, 76, 21 };
        int small = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < small)
            {
                small = nums[i];
            }
        }
        Console.WriteLine("En kicik vahid:" + small);

        //int small = nums.Min();
        //Console.WriteLine(small);
    }
    public static void CheckA()
    {
        Console.WriteLine("Enter the text");
        bool HasA = false;
        string enterLetter = Console.ReadLine().Trim().ToLower();
        for (int i = 0; i < enterLetter.Length; i++)
            if (enterLetter[i] == 'a') HasA = true;
        Console.WriteLine("Bu metnde a herfi " + (HasA ? "vardir" : "yoxdur"));
    }
    public static void Check()
    {
        int count = 0;
        int m = 30;
        for (int i = 1; i <= m; i++)
            if (i % 7 == 0) ++count;
        Console.WriteLine($"Count :{count}");
        //int count = 0;
        //int m = 30;
        //for (int n = 1; n <= m; n++)
        //{
        //    if (n % 7 == 0)
        //    {
        //        count++;

        //    }

        //}

        //Console.WriteLine(count);
    }
    public static void AdminLogin()
    {

        Console.WriteLine(new String('-', 30));
        string adminName;
        string adminPassword;

        do
        {
            Console.WriteLine("Write the admin name");
            adminName = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Write the admin parol");
            adminPassword = Console.ReadLine().Trim().ToLower();
        } while (adminName != "admin" || adminPassword != "123");
        Console.WriteLine(new String('-', 30));
        Console.WriteLine("Xosh Geldiniz");
    }
}