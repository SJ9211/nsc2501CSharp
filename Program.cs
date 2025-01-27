internal class Program
{
    // Internal 같은 어셈블리에서만 접근가능
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] s1 = new string[]{"I", "Love", "Programmers."};
        string[] s2 = new string[]{"com","b","d","p","c"};
        int[] intarray = new int[] { 1, 2, 100, -99, 1, 2, 3 };
        string STR = "bus";
         Console.WriteLine(sol.Solution01272(STR));
          //Util.PrintIntArray(sol.Solution01272(s1));
    
        //Sample sam = new Sample();
        //sam.DoWhileSample();  

        //var obj = new CSVar{};
        //obj.Method1();
    }
}