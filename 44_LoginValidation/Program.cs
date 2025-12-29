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
                "\n2 : Register User" +
                "\n3 : Update Password"+
                "\n4 : Exit");
            Console.WriteLine("Enter your Choice : ");
            ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    #region Login
                    {
                        Console.WriteLine("Enter User Name : ");
                        string? uname = Console.ReadLine();
                        Console.WriteLine("Enter Password : ");
                        string? pass = Console.ReadLine();

                        MyUser user = new MyUser(uname, pass);

                        var u = contextDB.validateUser(user);

                        if (u != null)
                        {
                            Console.WriteLine("welcome!!!");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Credentials");
                        }

                        break;
                    }
                #endregion

                case 2:
                    #region Register
                    {
                        Console.WriteLine("Enter User Name : ");
                        string? uname = Console.ReadLine();
                        Console.WriteLine("Enter Email : ");
                        string? email = Console.ReadLine();
                        Console.WriteLine("Enter Password : ");
                        string? pass = Console.ReadLine();
                        Console.WriteLine("Re-Enter Password : ");
                        string? repass = Console.ReadLine();

                        if (pass == repass)
                        {
                            MyUser user = new MyUser(uname, pass, email);
                            int no = contextDB.addNewUser(user);

                            if (no > 0)
                            {
                                Console.WriteLine("User Added Succesfully!!");
                            }
                            else
                            {
                                Console.WriteLine("Something Went Wrong");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Password Not Correct!!");
                        }




                        break;
                    }
                #endregion

                case 3:
                    {
                        Console.WriteLine("Enter User Name : ");
                        string? uname = Console.ReadLine();
                        Console.WriteLine("Enter Email : ");
                        string? email = Console.ReadLine();
                        Console.WriteLine("Enter old Password : ");
                        string? oldpass = Console.ReadLine();
                        Console.WriteLine("Enter New Password : ");
                        string? newpass = Console.ReadLine();

                        if (oldpass != newpass)
                        {
                            MyUser user = new MyUser(uname, newpass, email);
                            int no = contextDB.updatePass(user);

                            if (no > 0)
                            {
                                Console.WriteLine("Password updated Succesfully!!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Email!!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Enter Different Password !!");
                        }




                        break;
                    }

            }


        } while (ch != 4);
    }
}