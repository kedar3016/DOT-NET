using _44_LoginValidation.DAL;
using _44_LoginValidation.model;

internal class Program
{
    private static void Main(string[] args)
    {
        int ch;

        UserDBContext contextDB = new UserDBContext();


        do
        {
            Console.WriteLine("\n1 : Login " +
                "\n2 : Rgister" +
                "\n3 : Exit");
            Console.WriteLine("Enter your Choice : ");
            ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    {
                        Console.WriteLine("Enter User Name : ");
                        string? uname = Console.ReadLine();
                        Console.WriteLine("Enter Password : ");
                        string? pass = Console.ReadLine();

                        MyUser user = new MyUser(uname, pass);

                        var u  = contextDB.validateUser(user);

                        if(u != null)
                        {
                            Console.WriteLine( "welcome!!!");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Credentials");
                        }

                            break;
                    }
                    
             }


        } while (ch != 0);
    }
}