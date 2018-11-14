using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSong.Models
{
    class User
    {

        public User()
        {
            Name = "Loiann";
            Address = "Whatever";
        }

        public string Name { get; set; }
        public string Address { get; set; }

        public void DoSomething()
        {
            Console.WriteLine("Yay");
        }
    }
}
