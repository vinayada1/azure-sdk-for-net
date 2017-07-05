// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace compositeNetworkClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the storage location for a packet capture session.
    /// </summary>
    public partial class PacketCaptureStorageLocation
    {
        /// <summary>
        /// Initializes a new instance of the PacketCaptureStorageLocation
        /// class.
        /// </summary>
        public PacketCaptureStorageLocation()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PacketCaptureStorageLocation
        /// class.
        /// </summary>
        /// <param name="storageId">The ID of the storage account to save the
        /// packet capture session. Required if no local file path is
        /// provided.</param>
        /// <param name="storagePath">The URI of the storage path to save the
        /// packet capture. Must be a well-formed URI describing the location
        /// to save the packet capture.</param>
        /// <param name="filePath">A valid local path on the targeting VM. Must
        /// include the name of the capture file (*.cap). For linux virtual
        /// machine it must start with /var/captures. Required if no storage ID
        /// is provided, otherwise optional.</param>
        public PacketCaptureStorageLocation(string storageId = default(string), string storagePath = default(string), string filePath = default(string))
        {
            StorageId = storageId;
            StoragePath = storagePath;
            FilePath = filePath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the storage account to save the packet
        /// capture session. Required if no local file path is provided.
        /// </summary>
        [JsonProperty(PropertyName = "storageId")]
        public string StorageId { get; set; }

        /// <summary>
        /// Gets or sets the URI of the storage path to save the packet
        /// capture. Must be a well-formed URI describing the location to save
        /// the packet capture.
        /// </summary>
        [JsonProperty(PropertyName = "storagePath")]
        public string StoragePath { get; set; }

        /// <summary>
        /// Gets or sets a valid local path on the targeting VM. Must include
        /// the name of the capture file (*.cap). For linux virtual machine it
        /// must start with /var/captures. Required if no storage ID is
        /// provided, otherwise optional.
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }

    }
}
