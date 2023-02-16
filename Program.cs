
static extern int srav(int a, int b);
{
    int a = 0, b = 0, c = 0;

    if (a > b)
    {
        Console.WriteLine(" a больше в ");
        c = a;
    }
    if (a < b)
    {
        Console.WriteLine(" a меньше в ");
        c = b;
    }
    if (a == b)
    {
        Console.WriteLine(" a = в ");
        c = a + b / 2;

    }
    Console.WriteLine("=========================================== ");
    return c;
}
int result;
int r = Console.Read();

int u = Console.Read();
srav(r, u);
Console.WriteLine(result);


static extern int srav2(int a, int b,int c);
{
    int a = 0, b = 0, c = 0;
    int d;
    int e=3;
    int[] mas ;
    while(e >-1){
         mas[0] = a;
         mas[1] = b;
         mas[2] = c;

        e--;
    }
    
    return d;
}
int result2 = srav2;
int r2 = Console.Read();
int s2 = Console.Read();
int u2 = Console.Read();
srav2(r2,u2,s2);
Console.WriteLine(result);
Console.WriteLine("=========================================== ");