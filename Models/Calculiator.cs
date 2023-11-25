namespace Calculator.Services
{
    public class Calcult
    {
        public int topla(int x, int y)
        {
            return x + y;
        }

        public int bolme (int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("0-a bolunmur");
                int newY = int.Parse(Console.ReadLine());
                return x / newY;
            }
            return x / y;
        }

        public  int vurma(int x, int y)
        {
            return (x * y);
        }

        public int cixma(int x, int y)
        {
            return x - y;
        }
    }
}