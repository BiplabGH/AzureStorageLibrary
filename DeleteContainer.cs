using Microsoft.Azure.Storage.Blob;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public class DeleteContainer
    {
        public static async Task DeleteBlobontainer(string connectionString, string containerName)
        {
            CloudBlobClient cloudBlobClient = ConnectAzureStroage.ProcessConnection(connectionString);
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);
            if (cloudBlobContainer != null)
            {
                await cloudBlobContainer.DeleteIfExistsAsync();
            }
        }
    }
}
