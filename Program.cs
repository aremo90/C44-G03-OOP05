using ConsoleApp1.Binding;

namespace ConsoleApp1
{
    internal class Program
    {
        #region method Binding usage

        //public static void processEmployee(FullTimeEmp fullEmp)
        //{
        //    if (fullEmp is not null)
        //    {
        //        fullEmp.Function01();
        //        fullEmp.Function02();
        //    }
        //}
        //public static void processEmployee(PartNameEmp partTime)
        //{
        //    if (partTime is not null)
        //    {
        //        partTime.Function01();
        //        partTime.Function02();
        //    }
        //}

        public static void processEmployee(Employee emp)
        {
            if (emp is not null)
            {
                emp.Function01();
                emp.Function02();
            }
        }

        #endregion

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

            #region Binding exmple 

            //Employee fullTimeEmp = new FullTimeEmp();
            //Employee partTimeEmp = new PartNameEmp();

            //processEmployee(fullTimeEmp);
            //processEmployee(partTimeEmp);
            #endregion 


        }
    }
}
