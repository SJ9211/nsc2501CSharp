internal class Program
{
    // Internal 같은 어셈블리에서만 접근가능
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] s1 = new string[]{"a","b","c"};
        string[] s2 = new string[]{"com","b","d","p","c"};
        int[] intarray = new int[] { 1, 2, 100, -99, 1, 2, 3 };
        string STR = "happy birthday!";
       // Console.WriteLine(sol.Solution0122(s1, s2));
        Util.PrintIntArray(sol.Solution0123(15000));
        
        //Sample sam = new Sample();
        //sam.Operator();  

        //var obj = new CSVar{};
        //obj.Method1();
    }
}