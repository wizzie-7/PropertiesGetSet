using System;

namespace PropertiesGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSet GS = new GetSet();
            GS.Fname = "Vivek";
            GS.Lname = "JADHAV";
            Console.WriteLine(GS.Fname);
            Console.WriteLine(GS.Lname);

            child c = new child();
            c.test(50);
            c.print();

            AbstractChildClass acc = new AbstractChildClass();
            acc.abstractTest();
            Console.WriteLine(acc.Cityname);
            

        }
    }

    public class GetSet
    {
        public GetSet()
        {

        }
        private string fname;
        private string lname;
        private int id;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get;
            set;
        }
        public int Id
        {
            get { return id; }
            set { id = value;  }
        }
        public void test(int id)
        {
            this.id = id;
            Console.WriteLine(id);
        }
    }

    public class child : GetSet
    {
        public void print()
        {
            base.Fname = "xyz";
            base.Lname = "pqr";
            base.test(50);
            Console.WriteLine(Fname);
            Console.WriteLine(Lname);
        }
    }

    public abstract class AbstractClass
    {
        private string cityname;
        public abstract void abstractTest();
        public abstract string Cityname
        {
            get;// { return cityname; }
            //set { cityname = value;  }
        }

    }
    public class AbstractChildClass : AbstractClass
    {
        public override void abstractTest()
        {
            
        }
        public override string Cityname
        {
            get
            {
                return "Overriding properties";
            }
        }
    }
}
