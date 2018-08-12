using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class DeviceToken : Object
        {
            public class DeviceTokenBlackBerryPush : DeviceToken
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "deviceTokenBlackBerryPush";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("token")]
                public string Token { get; set; }
            }
        }
    }
}