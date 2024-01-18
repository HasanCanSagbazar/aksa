using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksaMachines
{
    public class UserData
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Job { get; set; }
        // Add other properties as needed

        public UserData() { }
        public UserData(string userId, string fullName, string job)
        {
            UserId = userId;
            FullName = fullName;
            Job = job;
            
            // Initialize other properties as needed
        }
    }
}
