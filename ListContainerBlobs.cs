using Microsoft.Azure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public static class ListContainerBlobs
    {
       public static async Task<List<Uri>> GetBlobsInContainer(string connectionString, string containerName)
        {
            CloudBlobClient cloudBlobClient = ConnectAzureStroage.ProcessConnection(connectionString);
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);
            // List the blobs in the container.
            BlobContinuationToken blobContinuationToken = null;
            List<Uri> BlobList = new List<Uri>();
            do
            {
                var results = await cloudBlobContainer.ListBlobsSegmentedAsync(null, blobContinuationToken);
                // Get the value of the continuation token returned by the listing call.
                blobContinuationToken = results.ContinuationToken;
                foreach (IListBlobItem item in results.Results)
                {
                    BlobList.Add(item.Uri);
                }
            } while (blobContinuationToken != null); // Loop while the continuation token is not null.

            return BlobList;
        }
    }
}
