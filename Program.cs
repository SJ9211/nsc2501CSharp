internal class Program
{
    // Internal 같은 어셈블리에서만 접근가능
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] intarray = new int[] { 1, 2, 100, -99, 1, 2, 3 };
        string STR = "happy birthday!";
        //Console.WriteLine(sol.Solution0121());
        Util.PrintIntArray(sol.Solution0121(intarray));
        
        Sample sam = new Sample();
         sam.StringsSample();  

        //var obj = new CSVar{};
        //obj.Method1();
    }
}