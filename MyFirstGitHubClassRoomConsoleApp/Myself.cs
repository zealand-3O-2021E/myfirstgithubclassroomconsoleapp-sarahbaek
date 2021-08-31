using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
   public class Myself
    {
        private string _name;
        private int _age;
        private bool _married;

        public Myself(string Name, int Age, bool Married)
        {
            _name = Name;
            _age = Age;
            _married = Married;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public bool Married { get => _married; set => _married = value; }

      
    }
}
