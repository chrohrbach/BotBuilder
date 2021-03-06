// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class BotData
    {
        /// <summary>
        /// Initializes a new instance of the BotData class.
        /// </summary>
        public BotData() { }

        /// <summary>
        /// Initializes a new instance of the BotData class.
        /// </summary>
        public BotData(string eTag = default(string), object data = default(object))
        {
            ETag = eTag;
            Data = data;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

    }
}
