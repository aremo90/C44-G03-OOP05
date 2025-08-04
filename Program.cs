using ConsoleApp1.Binding;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binding 
            /*
             * Refrerence From Parent refer to object from Child
             */

            //TypeA type = new TypeB(1,2);

            //type.A = 1;
            ////type.B = 2;

            //type.Func01(); // Output: Parent Class

            //type.Func02(); // Go to last Override of function
            #endregion 

        }
    }
}
