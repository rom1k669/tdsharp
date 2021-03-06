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
        /// Returns the last message sent in a chat no later than the specified date 
        /// </summary>
        public class GetChatMessageByDate : Function<Message>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatMessageByDate";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) relative to which to search for messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }
        }


        /// <summary>
        /// Returns the last message sent in a chat no later than the specified date 
        /// </summary>
        public static Task<Message> GetChatMessageByDateAsync(this Client client,
            long chatId = default(long),
            int date = default(int))
        {
            return client.ExecuteAsync(new GetChatMessageByDate
            {
                ChatId = chatId,
                Date = date,
            });
        }
    }
}