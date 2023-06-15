using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class Program:ProtectedAccessModifier
    {
        static void Main(string[] args)
        {
            PublicAccessModifier publicAccessModifier = new PublicAccessModifier();
            publicAccessModifier.IntroOfPublicModifier();

            PrivateAccessModifier privateAccessModifier = new PrivateAccessModifier();
            privateAccessModifier.Intro();

            ProtectedAccessModifier protectedAccessModifier = new ProtectedAccessModifier();
            Program program = new Program();
            program.DemoProtectedModifier();

            InternalAccessModifier internalAccessModifier = new InternalAccessModifier();
            internalAccessModifier.DemoInternalModifier();

            Console.ReadLine();
        }
    }
}
