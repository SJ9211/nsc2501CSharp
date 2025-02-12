using System.Text.RegularExpressions;

internal class Program
{
    // Internal 같은 어셈블리에서만 접근가능
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] s1 = new string[] { "I", "Love", "Programmers." };
        string[] s2 = new string[] { "com", "b", "d", "p", "c" };
        int[] intarray = new int[] { 12, 4, 15, 46, 38, 1, 14, 56, 32, 10};
        string STR = "0010";
        Console.WriteLine(sol.Solution02122(3,5));
       // Util.PrintIntArray(sol.Solution0212(intarray));

        //Sample sam = new Sample();
      

        // ref 사용. 초기화 불필요
        int x = 1;
        double y = 1.0;
        double ret = GetData(ref x, ref y);

        // out 사용. 초기화 불필요
        int c, d;
        bool bret = GetData(10, 20, out c, out d);
    }

    static double GetData(ref int a, ref double b)
    {
        return ++a * ++b;
    }
    static bool GetData(int a, int b, out int c, out int d)
    {
        c = a + b;
        d = a - b;
        return true;
    }
    
    
    //nssample nss = new nssample();
    MyCustomer myc = new MyCustomer();
    MyCustomer myc2 = new MyCustomer();

    // 필드를 public 으로 하면 위험
    // 원치 않는 값지정등을 외부에서 할 수 있기 때문에

}