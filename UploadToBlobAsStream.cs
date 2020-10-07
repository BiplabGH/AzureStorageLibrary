using Microsoft.Azure.Storage.Blob;
using System.IO;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public static class UploadToBlobAsStream
    {
        public static async Task UploadFileAsStream(string connectionString, string containerName, string mimeType, string localPath, string localFileName)
        {
            CloudBlobClient cloudBlobClient = ConnectAzureStroage.ProcessConnection(connectionString);
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);
            // Create a file in your local any folder to upload to a blob.
            string sourceFile = Path.Combine(localPath, localFileName);

            CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(localFileName);
            FileStream fileStream = File.OpenRead(localFileName);

            ///Read the stream at Code level
            //var streamReader = new StreamReader(fileStream);

            await cloudBlockBlob.UploadFromStreamAsync(fileStream);

            //Set Content Type or Mime Type
            cloudBlockBlob.FetchAttributes();
            cloudBlockBlob.Properties.ContentType = mimeType;
            cloudBlockBlob.SetProperties();
        }
    }
}
