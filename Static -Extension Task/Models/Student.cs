using System;
using System.Collections.Generic;
using System.Text;

namespace Static__Extension_Task.Models
{
    abstract class Student
    {
        private string _fullname;
        private string _groupNo;
        private int _age;
         public string Fullname { get; set; }
        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value)==true)
                {
                    _groupNo = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value>=16 && value<=170)
                {
                    _age = value;
                }
            }
        }
        public static  bool CheckGroupNo(string groupname)
        {
            int count = 0;
            if (groupname.Length==4 && groupname[0]>=65 && groupname[0]<=90)
            {
                for (int i = 1; i < groupname.Length; i++)
                {
                    if (groupname[i]>=48 && groupname[i]<=57)
                    {
                        count++;
                    }
                    if (count==3)
                    {
                        return true;
                    }
                }
            }
            return false;
            
        }
        public static bool CheckFullname(string fullName)
        {

        }
    }
}
