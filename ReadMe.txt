Storage Account is must to work on this Libraries
NuGet Package: 
1. Azure.Storage.Blob
2. Microsoft.Azure.Storage.Blob
3. Microsoft.Azure.Storage


Azure Blob storage is optimized for storing massive amounts of unstructured data. Unstructured data is data that does not adhere to a particular data model or definition, such as text or binary data. Blob storage offers three types of resources:

The storage account.
A container in the storage account
A blob in a container


CloudStorageAccount: The CloudStorageAccount class represents your Azure storage account. Use this class to authorize access to Blob storage using your account access keys.
CloudBlobClient: The CloudBlobClient class provides a point of access to the Blob service in your code.
CloudBlobContainer: The CloudBlobContainer class represents a blob container in your code.
CloudBlockBlob: The CloudBlockBlob object represents a block blob in your code. Block blobs are made up of blocks of data that can be managed individually.