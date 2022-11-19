using System.Reflection;

namespace Day_22_Practice_Reflection_UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome TO Day 22 assingment Problem");
            UserRegistration userRegistration = new UserRegistration();

            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();

            foreach (var item in types)
            {
                
                Console.WriteLine("Class : {0}", item.Name);

        
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method
                    Console.WriteLine("--> Method : {0}", method.Name);

                    // Array to store parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }







            Console.WriteLine("Hello User please Enter the First Name");
            Console.WriteLine(" NOTE:- First name starts with Cap and haS nminimum 3 characters");
            string userdata = Console.ReadLine();
            bool value = userRegistration.validatename(userdata);

            if (value)
            {
                Console.WriteLine("Given Name Accepted");

            }
            else
            {
                Console.WriteLine("Please Enter Valid Name");

            }

            Console.WriteLine("Enter Last Name");
            Console.WriteLine("NOTE:- Last name starts with Cap and has minimum 3 characters");

            string userlastname = Console.ReadLine();

            value = userRegistration.validatelastname(userlastname);

            if (value)
            {
                Console.WriteLine("Given Last Name Accepted");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Last Name");

            }

            Console.WriteLine("Enter Mail ID");
            Console.WriteLine("NOTE:- E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl&co) and 2 optional (xyz & in) with\r\nprecise @ and . positions");

            string usermail = Console.ReadLine();

            value = userRegistration.validatemail(usermail);

            if (value)
            {
                Console.WriteLine("Given Mail ID  Accepted");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Mail ID");

            }

            Console.WriteLine("Enter Mobile Number");
            Console.WriteLine("NOTE:- Mobile Format - E.g. 91 9919819801 - Country code follow by space and 10 digit number");

            string usermobile = Console.ReadLine();

            value = userRegistration.validatemobile(usermobile);

            if (value)
            {
                Console.WriteLine("Given Mobile Number  Accepted");
            }
            else
            {
                Console.WriteLine("Please Enter valid Mobile number");

            }

                Console.WriteLine("Enter Password");
                Console.WriteLine("NOTE:- Password minimum 8 Characters ");

                string userpassword = Console.ReadLine();

                value = userRegistration.validatepassword(userpassword);

                if (value)
                {
                    Console.WriteLine("Given Password  Accepted");
                }
                else
                {
                    Console.WriteLine("Please Enter valid Password");

                }


            
        }
    }
}