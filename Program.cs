using ConsoleApp1.Binding;
using ConsoleApp1.Interface;

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

            #region Interface

            /*
             * Interface :-
             * 
             *      -code contract between two developers First one write Interface signature
             *       Second one implement All Interface signature
             *      
             *      - Reference Type [Stack , Heap]
             *      - What you can write inside
             *          1. Signature for Method
             *          2. signature for Property
             *          3. default implemented Method
             *          New Feature
             *              4. Indexer
             *              5. Event
             *              6. Constants
             *              7.Operator
             *      = Tpype of Interface
             *          1. Top Level Interface
             *              Namespace => Access Modifier = Internal, public
             *          2. Nested Interface
             *              create this interface in any Other type
             */

            //IType refType;
            ////Declare reference type from Type "IType"
            //// This reference can Refer to any object from Any Type That Implement IO "IType"
            //// CLR will Allocate 4 unitilized Bytes at Stack [refType]

            ////IType type = new Type();
            //// error => you cannot take object from interface

            //refType = new Interface.Type();

            ////refType.MyProperty = 10;
            ////refType.MyMethod();
            ////refType.print(); // Default Method

            //Interface.Type type = new Interface.Type();
            //type.MyProperty = 10;
            //type.MyMethod();
            //type.print(); // Default Method => error => you cannot call default method from interface reference

            #endregion 
        }
    }
}
