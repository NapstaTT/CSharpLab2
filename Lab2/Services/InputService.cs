namespace Lab2.Services
{
    public class InputService
    {
        public int ReadInt(string prompt)
        {
            Console.Write(prompt + " ");
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Неверный ввод. Попробуйте снова: ");
            }
            return result;
        }

        public double ReadDouble(string prompt)
        {
            Console.Write(prompt + " ");
            double result;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Неверный ввод. Попробуйте снова: ");
            }
            return result;
        }

        public string ReadString(string prompt)
        {
            Console.Write(prompt + " ");
            return Console.ReadLine();
        }
    }
}