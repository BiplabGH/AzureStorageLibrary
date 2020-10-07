using Microsoft.Azure.Storage.Blob;
using System.IO;
using System.Threading.Tasks;
using System;
using Microsoft.Win32;

namespace StorageLibrary
{
    public static class DownloadBlobFileAsStream
    {
        public static async Task DownloadBlobFileStream(string connectionString, string containerName, string fileName)
        {
            CloudBlobClient cloudBlobClient = ConnectAzureStroage.ProcessConnection(connectionString);
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);
            CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(fileName);

            //Use this for stream data
            string home = GetDownloadFolderPath();
            Stream file = File.OpenWrite(home + @"\" + fileName);
            cloudBlockBlob.DownloadToStream(file);
        }

        public static string GetDownloadFolderPath()
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
        }
    }
}
