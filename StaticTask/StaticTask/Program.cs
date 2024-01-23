namespace StaticTask;

class Program
{
    static void Main(string[] args)
    {
        string fullName;
        do
        {
            Console.WriteLine("enter FullName:");

             fullName = Console.ReadLine();

        } while (!Student.CheckFullname(fullName));


        string groupNo;
        do
        {
            Console.WriteLine("enter GroupNo:");
             groupNo = Console.ReadLine();

        } while (!Student.CheckGroupNo(groupNo));

        byte age;

        string strAge;
        do
        {
            Console.WriteLine("enter Age:");
            strAge = Console.ReadLine();

        } while (!byte.TryParse(strAge,out age) || age<0);

        Student student = new Student(fullName,groupNo, age);

        Console.WriteLine("Your FullName:"+student.FullName);
        Console.WriteLine("Your GroupNo:"+student.GroupNo);
        Console.WriteLine("Your Age:"+student.Age);


        Console.ReadLine();
    }

}

