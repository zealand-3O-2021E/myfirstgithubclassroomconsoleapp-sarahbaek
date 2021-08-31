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

        public Myself(string name, int age, bool married)
        {
            _name = name;
            _age = age;
            _married = married;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public bool Married { get => _married; set => _married = value; }

      
    }
}
