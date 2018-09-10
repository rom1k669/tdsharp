using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class ResendEmailAddressVerificationCode : Function<EmailAddressAuthenticationCodeInfo>
        {
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "resendEmailAddressVerificationCode";

            [JsonProperty("@extra")] public override string Extra { get; set; }
        }
    }
}