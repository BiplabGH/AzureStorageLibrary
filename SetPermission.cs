using Microsoft.Azure.Storage.Blob;

namespace StorageLibrary
{
    public static class SetPermission
    {
        public static void SetBlobPermission(CloudBlobContainer cloudBlobContainer, string permission)
        {
            switch (permission)
            {
                case "PrivatePermission":
                    BlobContainerPermissions privatePermission = new BlobContainerPermissions
                    {
                        PublicAccess = BlobContainerPublicAccessType.Off 
                    };
                    cloudBlobContainer.SetPermissionsAsync(privatePermission);
                    break;
                case "BlobPermission":
                    BlobContainerPermissions blobPermission = new BlobContainerPermissions
                    {
                        PublicAccess = BlobContainerPublicAccessType.Blob 
                    };
                    cloudBlobContainer.SetPermissionsAsync(blobPermission);
                    break;
                case "ContainerPermission":
                    BlobContainerPermissions containerPermission = new BlobContainerPermissions
                    {
                        PublicAccess = BlobContainerPublicAccessType.Container 
                    };
                    cloudBlobContainer.SetPermissionsAsync(containerPermission);
                    break;
                default:
                    break;//Throw Error here
            }
        }
    }
}
