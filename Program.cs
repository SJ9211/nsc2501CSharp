internal class Program
{
    // Internal 같은 어셈블리에서만 접근가능
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] s1 = new string[] { "I", "Love", "Programmers." };
        string[] s2 = new string[] { "com", "b", "d", "p", "c" };
        int[] intarray = new int[] {};
        string STR = "0010";
        //Console.WriteLine(sol.Solution0211(STR));
        Util.PrintIntArray(sol.Solution02112(10));

        //Sample sam = new Sample();
       // sam.TryCatch();
       
       
       
       //nssample nss = new nssample();
    MyCustomer myc = new MyCustomer();
    MyCustomer myc2 = new MyCustomer();

    // 필드를 public 으로 하면 위험
    // 원치 않는 값지정등을 외부에서 할 수 있기 때문에

    }
}