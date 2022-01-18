using System;

namespace ClassOne
{
    public class Class1
    {
        public Class1(){}

        public int Run()
        {
            var subClass = new SubClass.SubClass();

            return 0 + subClass.Run();
        }
    }
}
