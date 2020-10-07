using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System;

namespace StorageLibrary
{
    public class ConnectAzureStroage
    {
        public static CloudBlobClient ProcessConnection(string connectionString)
        {
            // Check whether the connection string can be parsed.
            CloudStorageAccount storageAccount;
            string storageConnectionString = connectionString;
            try
            {
                if (CloudStorageAccount.TryParse(storageConnectionString, out storageAccount))
                {
                    CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();
                    return cloudBlobClient;
                }
                else
                {
                    return null;//Throw invalid data exception
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
