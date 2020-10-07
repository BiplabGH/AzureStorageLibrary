using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public static class CallAsync
    {
        public static void AsyncHelper()
        {
            string containerName = "<containerName>";
            string connectionString = Config.StorageConnectionString;
            var x  = ListContainerBlobs.GetBlobsInContainer(connectionString, containerName).GetAwaiter().GetResult();
            Console.WriteLine(x);
        }
    }
}
