﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Blockfrost.Api
{
    public partial class TxPoolRetry
    {
        /// <summary>Index of the certificate within the transaction</summary>
        [JsonPropertyName("cert_index")]
        public int Cert_index { get; set; }

        /// <summary>Bech32 stake pool ID</summary>
        [JsonPropertyName("pool_id")]
        [Required(AllowEmptyStrings = true)]
        public string Pool_id { get; set; }

        /// <summary>Retiring epoch</summary>
        [JsonPropertyName("retiring_epoch")]
        public int Retiring_epoch { get; set; }
    }
}
