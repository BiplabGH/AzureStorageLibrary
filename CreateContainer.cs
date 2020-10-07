using Microsoft.Azure.Storage.Blob;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public static class CreateContainer
    {
        public static async Task<bool> CreateBlobContainer(string connectionString, string containerName, string permission)
        {
            CloudBlobClient cloudBlobClient = ConnectAzureStroage.ProcessConnection(connectionString);
            if (cloudBlobClient != null)
            {
                CloudBlobContainer cloudBlobContainer =
                    cloudBlobClient.GetContainerReference(containerName);
                await cloudBlobContainer.CreateAsync();
                SetPermission.SetBlobPermission(cloudBlobContainer, permission);

                return true;
            }
            return false;
        }
    }
}
