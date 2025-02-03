internal class Program
{
    // Internal 같은 어셈블리에서만 접근가능
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] s1 = new string[] { "I", "Love", "Programmers." };
        string[] s2 = new string[] { "com", "b", "d", "p", "c" };
        int[] intarray = new int[] { 13, 22, 53, 24, 15, 6};
        string STR = "bus";
        Console.WriteLine(sol.Solution0203(intarray));
        //Util.PrintIntArray(sol.Solution0131(intarray));

       // Sample sam = new Sample();
       // sam.TryCatch();
       // Util.MakeLotto();  
       // static 이 있을때쓰는 방법
       //Util util = new Util();
       //util.MakeLotto();
    }
}