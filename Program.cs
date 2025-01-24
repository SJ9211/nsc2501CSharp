internal class Program
{
    // Internal 같은 어셈블리에서만 접근가능
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] s1 = new string[]{"a","b","c"};
        string[] s2 = new string[]{"com","b","d","p","c"};
        int[] intarray = new int[] { 1, 2, 100, -99, 1, 2, 3 };
        string STR = "Stanley1yelnatS";
        Console.WriteLine(sol.Solution01242(STR,6,12));
       // Util.PrintIntArray(sol.Solution0123(15000));
        
        //Sample sam = new Sample();
        //sam.SwitchStatement();  

        //var obj = new CSVar{};
        //obj.Method1();
    }
}