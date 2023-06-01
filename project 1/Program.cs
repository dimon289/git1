namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int series = 40;
            int sumNow = 0;
            int sumPrev = 1;
            int sumNext= 0;
            for(int i = 0; i < series; i++)
            {
                sumNext = sumNow + sumPrev;
                Console.WriteLine(sumNext);
                sumPrev = sumNow;
                sumNow= sumNext;
            }


        }
    }
}