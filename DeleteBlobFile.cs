using Microsoft.Azure.Storage.Blob;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public static class DeleteBlobFile
    {
        public static async Task DeleteBlobFileFromContainer(string connectionString, string containerName, string fileName)
        {
            CloudBlobClient cloudBlobClient = ConnectAzureStroage.ProcessConnection(connectionString);
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);

            CloudBlockBlob blob = cloudBlobContainer.GetBlockBlobReference(fileName);
            blob.DeleteIfExists();
        }
    }
}
