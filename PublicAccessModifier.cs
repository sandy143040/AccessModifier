using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class PublicAccessModifier
    {
        public void IntroOfPublicModifier()
        {
            Console.WriteLine("This is Public access modifier.");
            PrivateAccessModifier privateAccessModifier = new PrivateAccessModifier();
            privateAccessModifier.Intro();
        }
    }
}
