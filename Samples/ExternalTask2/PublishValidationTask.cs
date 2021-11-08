using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Build.Framework;

namespace ExternalTask2
{
    public class PublishValidationTask : Microsoft.Build.Utilities.Task
    {
        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "Hello World TEST PublishValidationTask");
            return true;
        }
    }
}
