using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Fan_s_directory
{
     public class Modules
    {


       
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Origin { get; set; }
        public string Age { get; set; }
        public string Birthday { get; set; }
        public string Nation { get; set; }
        
        public string TypeOfSport { get; set; }
        public string Records { get; set; }
        public string Club { get; set; }

        public Modules(string firstName, string secondName, string origin, string age, string birthday, string nation, string typeOfSport, string records, string club)
        {
       
            FirstName = firstName;
            SecondName = secondName;
            Origin = origin;
            Age = age;
            Birthday = birthday;
            Nation = nation;
            TypeOfSport = typeOfSport;
            Records = records;
            Club = club;
        }
    }
    
}
