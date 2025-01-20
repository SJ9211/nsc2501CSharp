class CSVar
{
    // field(필드) : 전역변수

    int globalVar;
    const int MAX = 1024;

    public void Method1 ()
    {
        // 지역변수
        int localVar;

        // 아래 할당이 없으면 에러 발생
        localVar = 100;

        Console.WriteLine(MAX); //상수를 쓰는 의미는 사람이 보기 편하게 쓰는것 
        Console.WriteLine(globalVar);
        Console.WriteLine(localVar);
    }
}