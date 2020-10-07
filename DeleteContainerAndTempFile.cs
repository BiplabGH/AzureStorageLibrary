using Microsoft.Azure.Storage.Blob;
using System.IO;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public static class DeleteContainerAndTempFile
    {
        public static async Task DeleteContainerAndTempFiles(string connectionString, string containerName, string tempFilePath)
        {
            CloudBlobClient cloudBlobClient = ConnectAzureStroage.ProcessConnection(connectionString);
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);
            if (cloudBlobContainer != null)
            {
                await cloudBlobContainer.DeleteIfExistsAsync();
            }
            File.Delete(tempFilePath);
        }
    }
}
