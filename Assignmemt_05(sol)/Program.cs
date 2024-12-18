namespace Assignmemt_05_sol_
{


    internal class Program
    {
        #region Q1 valu type
        #region passing by value
        //static void swap1(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}
        #endregion
        #region passing by references
        //static void Swap2(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}
        #endregion

        #endregion

        #region Q2 reference type
        #region passing by value
        //static void fun1(int[] arr)
        //{
        //    if (arr == null)
        //        return;
        //    //arr[0] = 10;
        //    arr = new int[] { 4, 5, 6, 7 };
        //}
        #endregion

        #region passing by referenc
        //static void fun2(ref int[] arr)
        //{
        //    if (arr == null)
        //        return;
        //    //arr[0] = 10;
        //    arr = new int[] { 4, 5, 6, 7 };
        //}
        #endregion
        #endregion


        #region Q3
        //static void sum_sub(int x,int y,out int sum,out int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //}



        #endregion


        #region Q4
        //static int sumdigit(int x)
        //{
        //    int sum = 0;
        //    while (x != 0)
        //    {
        //        int digit = x % 10;
        //        sum += digit;
        //        x /= 10;

        //    }
        //    return sum;
        //}


        #endregion


        #region Q5
        //static void IsPrime(int number)
        //{
        //    int prime = 0;
        //    for(int i = 2; i < number; i++)
        //    {

        //            if (number%i == 0)
        //            {
        //                prime = 1;
        //            }
        //    }
        //    if(prime == 0)
        //    {
        //        Console.WriteLine("prime");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not prime");
        //    }
        //}
        #endregion


        #region Q6
        //static void minmax(ref int[] arr)
        //{
        //    int max = arr[0]; int min = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //    }
        //    Console.WriteLine($"max={max}");
        //    Console.WriteLine($"min={min}");
        //}
        #endregion

        #region Q7
        //static void factorial(int number)
        //{
        //    int fact = 1;
        //    for(int i = 1; i <= number; i++)
        //    {
        //        fact *= i;
        //    }
        //    Console.WriteLine($"factorial={fact}");
        //}
        #endregion

        #region Q8
        //static string changechar(string word,int i,char x)
        //{
        //    word = word.Remove(i,1);
        //    word = word.Insert(i, x.ToString());
        //    return word;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q1 value type
            #region passing by value
            //int a = 10, b = 20;
            //swap1(a, b);
            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"b={b}");
            #endregion

            #region passing by reference
            //int a = 10, b = 20;
            //Swap2(ref a, ref b);
            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"b={b}");
            #endregion

            #endregion

            #region Q2 reference type
            #region passing by value
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //fun1(numbers);
            //Console.WriteLine(numbers[0]);

            #endregion

            #region passing by refences
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //fun2(ref numbers);
            //Console.WriteLine(numbers[0]);
            #endregion

            #endregion


            #region Q3

            //int a, b, sum, sub;
            //bool flag1, flag2;
            //do
            //{
            //    Console.WriteLine("enter first number");
            //    flag1 = int.TryParse(Console.ReadLine(), out a);
            //    Console.WriteLine("enter second number");
            //    flag2 = int.TryParse(Console.ReadLine(), out b);
            //} while (!(flag1 && flag2));
            //sum_sub(a, b, out sum,out sub);
            //Console.WriteLine($"sum= {sum}");
            //Console.WriteLine($"sum= {sub}");

            #endregion


            #region Q4

            //int x;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter number");
            //    flag = int.TryParse(Console.ReadLine(), out x);

            //} while (!flag);

            //int result =sumdigit(x);
            //Console.WriteLine($"sum={result}");
            #endregion


            #region Q5

            //int number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter your number");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //} while (!flag);
            //IsPrime(number);
            #endregion


            #region Q6
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);
            //int[] numbers = new int[size];
            //do
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"enter number{i + 1}");
            //        flag = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    }
            //} while (!flag);

            //minmax(ref numbers);

            #endregion

            #region Q7
            //int number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter number");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //} while (!flag);
            //factorial(number);
            #endregion

            #region Q8
           // Console.WriteLine("enter word");
           // string word =(Console.ReadLine());
           // Console.WriteLine("enter i");
           //int i=int.Parse(Console.ReadLine());
           // Console.WriteLine("enter char");
           // char x=char.Parse(Console.ReadLine());
           // string newword=changechar(word,i,x);
           // Console.WriteLine($"new word={newword}");
            #endregion

        }
    }
}

