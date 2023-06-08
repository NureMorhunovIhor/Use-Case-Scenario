using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fan_s_directory
{
    class People {
        public List<Modules> PeopleList { get; set; }

        public People()
        {
            PeopleList = new List<Modules>();
        }
        public void Add(Modules person)
        {
            PeopleList.Add(person);
        }


        // Add more people as needed

    }

}
