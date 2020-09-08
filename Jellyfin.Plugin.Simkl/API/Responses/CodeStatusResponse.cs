﻿using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Simkl.API.Responses
{
    /// <summary>
    /// Code status response.
    /// </summary>
    public class CodeStatusResponse
    {
        /// <summary>
        /// Gets or sets result.
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets access token.
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
    }
}