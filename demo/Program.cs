using demo.Binding;
using demo.Interface;

namespace demo
{
    internal class Program
    {
        //public static void processEmployee(Employee emp) 
        //    {
        //    if (emp != null) {
        //        emp.Fun01();
        //        emp.Fun02();


        //    }

        //    }
        public static void Print10(Sequance sequance)
        {

            if (sequance == null)
                return;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"current number is {sequance.Current}");
                sequance.GetNext();
                
            }
            sequance.Reset();

        }

        static void Main(string[] args)
        {
            #region Binding
            //    //binding is a behaviour 
            //    //refrence from parent and object from child
            //    TypeA RefBase=new TypeB(5,5);
            //    RefBase.A = 5;
            //    RefBase.Fun01();
            //    RefBase.Fun02();
            //    //what is not binding 
            //    TypeA TypeA=new TypeB(5,5);
            //    TypeB Hold= (TypeB) TypeA;


            ////explicit casting

            #endregion
            #region when we need binding
            //FullTimeEmp fullTimeEmp = new FullTimeEmp();
            //fullTimeEmp.Salary = 10;
            //fullTimeEmp.Name = "abdelrahman";
            //fullTimeEmp.Age = 23;
            //fullTimeEmp.Id = 1;
            //processEmployee(fullTimeEmp);

            //PartTime partTime = new PartTime();
            //partTime.HourRate = 10;
            //partTime.Name = "saadany";
            //partTime.Age = 23;
            //partTime.Id = 1;
            //processEmployee(partTime);




            //Employee FullTemployee = new FullTimeEmp(10, "full",10,10);

            //FullTemployee.Fun01();//static binding 
            //FullTemployee.Fun02();//dynamic binding


            //Employee PartTemployee = new PartTime(10, "part", 10, 10);

            //PartTemployee.Fun01();
            //PartTemployee.Fun02();

            #endregion
            #region Interface
            MyType myType = new MyType();
            myType.Id = 1;
            myType.MyFun();
            IMyType myType2 = new MyType();
            myType2.print();
            Sequance sequance = new Sequance();
           Print10(sequance);
            #endregion
        }
    }
}
