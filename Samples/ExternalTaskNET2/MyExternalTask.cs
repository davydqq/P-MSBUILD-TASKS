using System;

namespace ExternalTask
{
    public class MyExternalTask : Microsoft.Build.Utilities.Task
    {
        public string MyParameter { get; set; }

        public override bool Execute()
        {
            Console.WriteLine("Hello from the ExternalTask: " + MyParameter);
            return true;
        }
    }
}
