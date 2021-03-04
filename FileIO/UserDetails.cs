using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    [Serializable()]
    class UserDetails
    {
        int userId;
        string userName;

        [NonSerialized()]
        string location; //field state not saved - non persistent

        public UserDetails(int userId, string userName, string location)
        {
            this.UserId = userId;
            this.UserName = userName;
            this.Location = location;
        }

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Location { get => location; set => location = value; }

        public void GetDetails()
        {
            Console.WriteLine("User Id:{0}", UserId);
            Console.WriteLine("User Name:{0}", UserName);
            Console.WriteLine("User location:{0}", Location);
        }
    }
}
