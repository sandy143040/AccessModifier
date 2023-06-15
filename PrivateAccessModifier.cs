using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class PrivateAccessModifier
    {
        private void DemoPrivateAccessModifier()
        {
            Console.WriteLine("This is Private access modifier.");
        }
        public void Intro()
        {
            DemoPrivateAccessModifier();
        }
    }
}
