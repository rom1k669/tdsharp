using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class ForwardMessages : Method<Messages>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "forwardMessages";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("from_chat_id")]
        public long FromChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("message_ids")]
        public long[] MessageIds { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("disable_notification")]
        public bool DisableNotification { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("from_background")]
        public bool FromBackground { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("as_album")]
        public bool AsAlbum { get; set; }

    }

}