using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationPattern
{
    class ServiceInfo
    {
        public int Id
        {
            get;
            set;
        }


        public string Name
        {
            get;
            set;
        }

        public ServiceInfo(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public ServiceInfo()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Id is {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Id is {0}", this.Name);
        }
    }
}
