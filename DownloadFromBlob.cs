using Microsoft.Azure.Storage.Blob;
using System.IO;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public static class DownloadFromBlob
    {
        public static async Task DownloadBlobFile(string connectionString, string containerName, string fileName)
        {
            CloudBlobClient cloudBlobClient = ConnectAzureStroage.ProcessConnection(connectionString);
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);
            CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(fileName);

            MemoryStream ms = new MemoryStream();
            await cloudBlockBlob.DownloadToStreamAsync(ms);
            Stream blobStream = cloudBlockBlob.OpenReadAsync().Result;

            //return null;//File(blobStream, cloudBlockBlob.Properties.ContentType, fileName);
        }
    }
}
