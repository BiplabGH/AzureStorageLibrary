using Microsoft.Azure.Storage.Blob;
using System.IO;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public static class UploadToBlobAsFile
    {
        public static async Task UploadBlobFile(string connectionString, string containerName, string mimeType, string localPath, string localFileName)
        {
            CloudBlobClient cloudBlobClient = ConnectAzureStroage.ProcessConnection(connectionString);
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);

            string sourceFile = Path.Combine(localPath, localFileName);

            CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference("J<localFolderName>"+localFileName);
            await cloudBlockBlob.UploadFromFileAsync(sourceFile);

            //Set Content Type or Mime Type
            cloudBlockBlob.FetchAttributes();
            cloudBlockBlob.Properties.ContentType = mimeType;
            cloudBlockBlob.SetProperties();
        }
    }
}
