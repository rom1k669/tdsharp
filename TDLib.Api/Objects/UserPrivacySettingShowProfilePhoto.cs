using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// A privacy setting for managing whether the user's profile photo is visible
        /// </summary>
        public partial class UserPrivacySetting : Object
        {
            /// <summary>
            /// A privacy setting for managing whether the user's profile photo is visible
            /// </summary>
            public class UserPrivacySettingShowProfilePhoto : UserPrivacySetting
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingShowProfilePhoto";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}