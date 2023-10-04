using System;
class myarray
{
    int[] ar;
    Random rnd = new Random();
    public myarray(int size)
    {
        ar = new int[size];
        for (int i = 0; i < size; i++)
            ar[i] = rnd.Next(1, 30);
    }
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < ar.Length)
                return ar[index];
            else
                throw new Exception("Некорректный индекс!  " + index);
        }
    }
}
class UseArray
{
    public static void Main()
    {
        myarray ar = new myarray(10);
        for (int i = 0; i < 10; i++)
            Console.Write("{0,4}", ar[i]);
        for (int i = 0; i < 10; i++)
            ar[i] = i;
        for (int i = 0; i < 10; i++)
            Console.Write("{0,4}", ar[i]);
    }
}

