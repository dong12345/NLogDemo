using System;

namespace NLog.Test
{
    class Program
    {

        public static void Main()
        {

            LoggerHelper helper = new LoggerHelper();

            //try
            //{
            //    helper.Info("lalal");
            //    helper.Error("Error!!!");
            //    helper.Fatal("Fatal!!!!");
            //    System.Console.ReadKey();
            //}
            //catch (Exception ex)
            //{
            //    helper.Error("Goodbye cruel world");
            //}

            try
            {
                int result = Caclulate(10, 0);

            }
            catch (Exception ex)
            {
                helper.Info(ex.Message, ex);
            }
        }

        private static int Caclulate(int a, int b)
        {
            return a / b;
        }

    }
}
