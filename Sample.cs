#define TEST_ENV
#define PC //ANDROID


using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

partial class Class1
{
    public void Run() {}
}
class Sample
{

    // # 전처리기 지시어
    public void PreProcess()
    {
#if ( TEST_ENV )
        Console.WriteLine("Now Test env.");
#if (ANDROID)
        console.WriteLine("platform : android");
#elif (IOS)
        console.WriteLine("platfoum : IOS");
#else
        Console.WriteLine("platrorm : PC");
#endif
#else
     console.WriteLine("Now production env.");
#endif
    }


    public void nullableTest()
    {
        int? a = null;
        int? b = 0;
        int result = Nullable.Compare<int>(a, b);
        Console.WriteLine(result);

        double? c = 0.01;
        double? d = 0.0100;
        bool result2 = Nullable.Equals<double>(c,d);
        Console.WriteLine(result2);
    }
    float sum = 0;
    DateTime time;
    bool? selected;

    public void CheckInput(int? i, float? d, DateTime? time, bool? selected)
    {
        if (i.HasValue && d.HasValue)
        {
            this.sum = (float)i.Value + (float)d.Value;
        }

        if (!time.HasValue)
            throw new ArgumentException();
        else
            this.time = time.Value;

        //this.selected = selected ?? false;  아래와 동일함
        if (selected == null)
            this.selected = false;
        else
            this.selected = selected;
    }
    public void NullableSample()
    {
        int i = 0;
        int? ii = null;
        bool? b = null;
        int?[] a = new int?[100];
        //nullable 에 맞추기

        if ( ii != null)
        {
            Console.WriteLine(i);
        }

    }
    struct MyPoint
    {
        public int X;
        public int Y;
        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
        private void Main(string[] args)
        {
            // 구조체 사용
            MyPoint pt = new MyPoint(10, 12);
            Console.WriteLine(pt.ToString());
        }
    }
    public void TryCatch()
    {
        int[] intarray = new int[] { 1, 2, 3, 4 };
        // try-catch 없이 실행
        DoSmonething(intarray);

        // try-catch
        try
        {   // 실행하고자 하는 문장들
            DoSmonething(intarray);
        }
        catch (System.Exception ex)
        {
            // 에러 처리
            Console.WriteLine($"ERROR!!!:{ex}");
            throw;
        }



    }

    private void DoSmonething(int[] ia)
    {
        ia[5] = 0;
    }
    

    public IEnumerable<int> GetNumber()
    {
        yield return 10; //첫번째 루프에서 리턴되는 값
        yield return 20; //두번째 루프에서 리턴되는 값
        yield return 30; //세번째 루프에서 리턴되는 값
    }

public void DoWhileSample ()
{
    int i = 100;
   Console.Write("Do While:");
    do
    {
        Console.WriteLine(i);
        i++;
           }
                 while (i<10);
                        Console.WriteLine();
              
              i = 100;
              Console.Write("while:");
       while( i < 10)
       {
        Console.WriteLine($"{i}");
        i++;
       }            
       Console.WriteLine();
}

 const int MAX_LOOP = 10;
 public void LoopSample()
 {
    //  for 증가식 => 감소식 (10...1)
    for (int i = MAX_LOOP; 1 > 0 ; i--)
    {
        Console.WriteLine($"Loop {i}");
    }
 }
   static bool verbose = false;
    static bool continueOnError = false;
    static bool logging = false;
     
    public void SwitchStatement()
    {
        string category = "포도"; //string.Empty;
        int price = 100;

        switch (category)
        {
            case "사과":
                price = 1000;
                break;
            case "딸기":
                price = 1100;
                break;
            case "포도":
                price = 900;
                break;
            default:
                price = 0;
                break;
        }
        /*
        if ( category == "사과")
        {
            price = 1000;
        }
        else if ( category == "딸기")
        {
            price = 1100;
        }
        else if ( category == "포도")
        {
            price = 900;
        }
        else
        {
            price = 0;
        }
        */
       //Console.WriteLine($"price: {price}");
       
    }

    public void Operator()
    {
        // 나머지 연산자 %
        int a = (1 + 2 - 1) * (4 / 2) % 3;

        // 할당 연산자 +=, -= , *=, /=, %=
        a %= 2;

        // 증감 연산자 . i++ 는 i=i+1 를 축약
        a++; // a = a + 1 // a += 1
        a--; // a = a - 1 // a -= 1

        // 증감연산자를 앞에 붙이냐 뒤에 붙이냐
        ++a; // 맨먼저 ++ 계산한다

        int b = 1,c = 2;
        bool d =true;
        // 논리 연산자
        if (( a > 1 && b < 0 )|| c == 1 || !d) a = 0;
    
        // 비교 연산자
        if ( a <= b) a = 0;

        // 비트 연산자
        byte aa = 0b_0000_0111; // 7
        byte bb = (byte)((aa & 3) | 4);
        Console.WriteLine($"byte bb:{bb}");

        // shift 연사자 : << = *2 : >> = /2
        int i = 2;
        i = 1 << 5;
        Console.WriteLine ($"2 after left Shift 5: {i}");

        // 조건 연산자
        int val = (a>b) ? a : b;
        int? iii = null;
        i = iii ?? 0;

        string s = null;
        //string ss = s ?? string.Empty;
        string ss;
        if (s == null)
        {
            ss = string.Empty;
        }
        else
        {
            ss = s;
        }
        ss = s ?? "Don't do this";
}
    enum City
    {
        Seoul,
        Deajun,
        Busan = 5,
        Jeju =10
    }

    [Flags]

    enum Border
    {

        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }
    public void EnumSample()
    {
        City myCity;
        //  enum 타입에 값을 대입하는 방법
        myCity = City.Seoul;
        //  enum을 int로 변환 하는 방법
        // (int)를 앞에 지정
        int cityValue = (int) myCity;
        if (myCity == City.Seoul) // enum 값을 비교하는 방법
        {
            Console.WriteLine("Welcome to Seoul");
        }
  
        Border b = Border.Top | Border.Bottom | Border.Left;
        if ((b & Border.Top) != 0)
        {
            if (b.HasFlag(Border.Bottom))
            {
                Console.WriteLine(b.ToString()); // (int)b => 13
            }
        }
    }

    public void StringsSample()
        {
            string s1 = "C#";
            string s2 = "Programming";
            // char c1 = 'A';
            // char c2 = 'B';
                    
            string s3 = s1 + " "+ s2;
            Console.WriteLine("string: {0} {1}", s3, 10);

            string s3substring = s3.Substring(1, 5);
            Console.WriteLine("Substring: {0}", s3substring);

            string s = "C# Studies";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0}:{1}", i , s[i]);
            }
        
            string str = "Hello";
            char[] charArray = str.ToCharArray();
            for ( int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }
        
            char[] charArray2 = {'A','B','C','D'};
            s = new string(charArray2);

            Console.WriteLine(s);

            char c1 = 'A';
            char c2 = (char)(c1 +3);
            Console.WriteLine(c2);        
    }
       
   
public void Dictionary()
    {
        // var
        var chr = new List<char>();
        var dic = new Dictionary<int, int>();
        
        //   hashtable
        Hashtable ht = new Hashtable();
        ht.Add("irian", "Irian SP");
        ht.Add("tom", "Tom Cr");

        if (ht.Contains("tom"))
        {
            Console.WriteLine(ht["tom"]);
        }

        // dictionary
        Dictionary<int, string> emp = new Dictionary<int, string>();
        emp.Add(1001, "Jane");
        emp.Add(1002, "Tom");
        emp.Add(1003, "Cindy");

        Console.WriteLine("Count:" + emp.Count);

        string name = emp[1003];
        Console.WriteLine(name);
        if (emp.ContainsKey(1004))
        {
            name = emp [1004];
            Console.WriteLine(name);
        }

    }

     public void Queue_Stack()
            {
                // Queue
                Queue<int> q = new Queue<int>();
               
                q.Enqueue(120) ;
                q.Enqueue(130) ;
                q.Enqueue(150) ;

                int Next = q.Dequeue();
                Console.WriteLine("Next:" + Next);
                Console.WriteLine("count:" + q.Count);
                Next = q.Dequeue();
                Console.WriteLine("Next:" + Next);

                // Stack
                Stack<float> s =new Stack<float>();
                
                s.Push(10.5f);
                s.Push(3.54f);
                s.Push(4.22f);

                float val = s.Pop();
                Console.WriteLine("val:" + val);
                Console.WriteLine("count:" + s.Count);
            }
    
    
    public void List()
    {
       
        List<int> intlist = new List<int>();
        List<char> charlist = new List<char>();
        List<float> flist = new List<float>();
        List<bool> blist = new List<bool>();
        List<string> slist = new List<string>();

        intlist.Add(0);
        intlist.Add(2);
        intlist.Add(0);

        // Remove는 리스트의 처음부터 검사해서
        // 해당하는 아이템이 있다면 그것만 지운다
        intlist.Remove(3);

        // 배열에서는 .Length
        // 리스트에서는 .Count 로 크기를 구할 수 있다
        int val = intlist.Count;
        Console.WriteLine("intlist의 크기:" + val);

        // linked list
        LinkedList<string> list = new LinkedList<string>();
        list.AddLast("Apple");
        list.AddLast("Banana");
        list.AddLast("Lemon");

        LinkedListNode<string> node = list.Find("Banana");
        LinkedListNode<string> newNode = new LinkedListNode<string>("Grape");

        list.AddAfter(node, newNode);

        list.ToList<string>().ForEach(p => Console.WriteLine(p));
        
        foreach (var ltem in list)
        {
            Console.WriteLine(ltem);
        }
    }


    public void Arrary()
    {
        // 1
        string[] players;
        players = new string[10];
        Console.WriteLine("players:" + players.Length);
        int[] intarray = new int[100];
        Console.WriteLine("intarray:" + intarray.Length);
        char[] cc = new char[5];
        int[] abc = new int[3];
        int[] abc2 = new int[3] { 1, 2, 3 };
        string[] Regions = new string[3] { "서울", "경기", "부산" };

        // 2
        string[,] Depts = new string[2, 2];
        Console.WriteLine("Depts:" + Depts.Length);
        int[,] inta2 = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 } };
        Console.WriteLine("inta2:" + inta2.Length);

        // 3
        string[,,] cubes = new string[2, 3, 4];
        Console.WriteLine("cubes:" + cubes.Length);

        // 아래 방법은 가능하지만,2차원 배열[,]을 사용하자
        // 차원별 배열 크기가 다를 경우 사용
        int[][] ii = new int[2][];
        int[][] iii = new int[3][];
        iii[0] = new int[2] { 1, 2 };
        iii[1] = new int[2] { 2, 3 };
        iii[2] = new int[2] { 3, 4 };

        int sum = 0;
        int[] scores = new int[5] { 80, 78, 60, 90, 100 };
        // sum += scores[0];
        // sum += scores[1];
        // sum = sum + scores[2];
        // sum = sum + scores[3];
        // sum = sum + scores[4];

        for (int i = 0; i < scores.Length; i++)
        {
            //sum = sum + scores[i];
            //sum -= scores[i];
            //sum *= scores[i];
            //sum /= scores[i];
            sum += scores[i];
        }
        Console.WriteLine("sum : " + sum);

        int[] ss = new int[100];
        ss[0] = 90;
        int val = ss[0];
    }
    public void Randomsum()
    {
        int sum = 0;
        //   random
        int[] nums = new int[10];

        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
            Console.WriteLine("nums[" + i + "]:" + nums[i]);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Console.WriteLine(sum);
    }


    void DateType()
    {
        // Bool
        bool b = true;
        // Numeric
        //short sh = 32768;
        int i = 2147483647;
        long I = 1234L;    // L suffix
        float f = 123.45F; // F suffix
        double d1 = 123.45;
        double d2 = 123.45D; //D suffix
        decimal d = 123.45M; //M suffix

        // Char/String
        char c = 'A';
        string s = "Hello";
        s = null;

        // == !=
        if (s[0] != 'e')
            b = true;
        else
            b = false;


        // DateTime   2025-01-13 10:24
        DateTime dt = new DateTime(2025, 01, 13, 10, 24, 0);

        // max, min
        int i2 = 0;
        // ....
        // if (12 > 2147483647) ;
        //if = (12 > int.MaxValue) ;

        // 기억해야 되는 datatype
        bool bb = false;
        int i3 = 0;
        float ff = 0.1f;
        char cc = 'c';
        string ss = "hello world";

    }
}