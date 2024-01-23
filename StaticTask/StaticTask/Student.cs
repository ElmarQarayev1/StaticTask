using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace StaticTask
{
	public class Student
	{

		public string FullName;
		public string GroupNo;
		public byte Age;

        public Student(string fullname,string groupno,byte age)
        {
            this.Age = age;
            this.GroupNo = groupno;
            this.FullName = fullname;

        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (String.IsNullOrWhiteSpace(groupNo) || groupNo.Length != 4)
                return false;

            if (Char.IsLetter(groupNo[0]) && Char.IsUpper(groupNo[0]))
            {
                for (int i = 1; i < 4; i++)
                {
                    if (!Char.IsDigit(groupNo[i]))
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;

        }
        public static bool CheckFullname(string fullname)
        {
            if (String.IsNullOrWhiteSpace(fullname))
                return false;

            string[] nameParts = fullname.Split(' ');

            if (nameParts.Length == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (String.IsNullOrWhiteSpace(nameParts[i])|| CheckIsDigit(nameParts[i]))
                    {
                        return false;
                    }              
                }
                return true;
            }
            return false;
        }

       public static bool CheckIsDigit(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i])) return true;
                
            }
            return false;

        }


    }
}

