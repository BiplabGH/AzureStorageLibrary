using System.Threading.Tasks;

namespace StorageLibrary
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //Driver Code
            //uncomment rows as per required

            string containerName = "<containerName>";
            string connectionString = Config.StorageConnectionString;
            //string permission = Constant.BlobPermission;
            //string updatePermission = Constant.ContainerPermission;
            //string tempPath = @"‪<tempPath>";
            //string fileName = "<tempFileNamewithExtension>;
            string txtFileName = "<fileNameWithExtenson>";
            //Mime Type: https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types/Common_types
            string mimeType = "text/plain";
            string localPath = @"<localPath>";//File Local/Server/fake Path
            string localFileName = "localFileName>";

            //await DownloadFromBlob.DownloadBlobFile(connectionString, containerName, txtFileName);
            
            await DownloadBlobFileAsStream.DownloadBlobFileStream(connectionString, containerName, txtFileName);




            //CallAsync.AsyncHelper();

            //Create Container
            //await CreateContainer.CreateBlobContainer(connectionString, containerName, permission);
            //await ListContainerBlobs.GetBlobsInContainer(connectionString, containerName);
            //await UploadToBlobAsFile.UploadBlobFile(connectionString, containerName, mimeType, localPath, localFileName);
            //await DownloadFromBlob.DownloadBlobFile(connectionString, containerName, fileName);
            //await ChangeContainerAccessPolicy.ChangeAccessPolicy(connectionString, containerName, updatePermission);
            //await UploadToBlobAsStream.UploadFileAsStream(connectionString, containerName, mimeType, localPath, localFileName);

            //use either of them according to need
            //await DeleteBlobFile.DeleteBlobFileFromContainer(connectionString, containerName, fileName);
            //await DeleteContainer.DeleteBlobontainer(connectionString, containerName);
            //await DeleteContainerAndTempFile.DeleteContainerAndTempFiles(connectionString, containerName, tempPath);

        }
    }
}
