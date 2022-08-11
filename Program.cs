// .................Compiletime polymorphism............

//class PhonePe
//{
//    public void Transaction(int PhoneNo, int amount, int PinNO)
//    {
//        Console.WriteLine("Money Transfer Sucessfully using SBI");
//    }
//    public void Transaction(String UPIScan, int amount, int pinNo)
//    {
//        Console.WriteLine("Money Transfer Sucssesfully using SBI");
//    }

//static void Main(string[] args)
//    {
//        PhonePe p = new PhonePe();
//        p.Transaction(9988776, 2000, 111111);
//        p.Transaction("swati@axis", 2000, 2222222);


//    }
//}

//   ...........Runtime polymorphism.......
//class PhonePe
//{
//    public virtual void Transaction()
//    {
//        Console.WriteLine("Money Transfer Sucessfully using SBI");
//    }


//    class Bankaccount : PhonePe
//    {

//        public override void Transaction()
//        {
//            Console.WriteLine("money Transfer sucessfully Using HDFc bankaccount");
//            ;
//        }
//    }

//    static void Main(string[] args)
//    {


//        Bankaccount b = new Bankaccount();
//        b.Transaction();
//        Console.ReadLine();
//    }
//}

//.....................Abstraction..................

//    abstract class email
//{
//    public abstract void user(String userName);

//    public abstract void password(String Password);
//}

//class account : email
//{

//    public override void user(String username)
//    {

//        Console.WriteLine("enter username ");

//    }

//    public override void password(String Password)
//    {

//        Console.WriteLine("enter Password");

//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {

//        account a = new account();
//        a.user("swathi@gmail.com");
//        a.password("12345");
//        Console.ReadLine();
//    }
//}

//.............................Interface.................

//    interface Sim
//{
//    void call();
//    void browse();
//}
//class Airtel : Sim
//{
//    public void call()
//    {
//        Console.WriteLine("Airtel is calling");
//    }
//    public void browse()
//    {
//        Console.WriteLine("Airtel 4G connecting");
//    }
//}
//class Jio : Sim
//{
//    public void call()
//    {
//        Console.WriteLine("Jio is calling");
//    }
//    public void browse()
//    {
//        Console.WriteLine("Jio 4G connecting");
//    }
//}
//class Program
//{
//    static void Main(String[] args)
//    {
//        Airtel a = new Airtel();
//        a.call();
//        a.browse();
//        Jio j = new Jio();
//        j.call();
//        j.browse();

//        Console.ReadLine();
//    }
//}
..............................multilevel inheritance.................
  
   // class:Animal
   //   {
   //    public void eat()
   //    { Console.WriteLine("Eating...");
   //    }
   //}
   //public class Dog : Animal
   //{
   //    public void bark()
   //    { Console.WriteLine("Barking...");
   //    }
   //}
    //    }
   //}
   //class TestInheritance2
   //{
   //    public static void Main(string[] args)
   //    {
   //        Dog d1 = new Dog();
   //        d1.eat();
   //        d1.bark();
   //    }
   //}




