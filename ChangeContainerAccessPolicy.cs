using Microsoft.Azure.Storage.Blob;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public static class ChangeContainerAccessPolicy
    {
        public static async Task ChangeAccessPolicy(string connectionString, string containerName, string updatePermission)
        {
            CloudBlobClient cloudBlobClient = ConnectAzureStroage.ProcessConnection(connectionString);
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);
            SetPermission.SetBlobPermission(cloudBlobContainer, updatePermission);
        }
    }
}
