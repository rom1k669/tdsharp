using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Deletes a profile photo. If something changes, updateUser will be sent 
        /// </summary>
        public class DeleteProfilePhoto : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deleteProfilePhoto";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the profile photo to delete
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("profile_photo_id")]
            public Int64 ProfilePhotoId { get; set; }
        }


        /// <summary>
        /// Deletes a profile photo. If something changes, updateUser will be sent 
        /// </summary>
        public static Task<Ok> DeleteProfilePhotoAsync(this Client client,
            Int64 profilePhotoId = default(Int64))
        {
            return client.ExecuteAsync(new DeleteProfilePhoto
            {
                ProfilePhotoId = profilePhotoId,
            });
        }
    }
}