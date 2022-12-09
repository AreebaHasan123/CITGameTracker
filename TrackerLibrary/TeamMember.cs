using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamMember
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }


        

        public TeamMember()
        {
            ID= 0;
            FirstName= string.Empty;
            LastName= string.Empty; 
            EmailAddress= string.Empty; 
        }
        
        public string FullName
        {
          
                    
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
