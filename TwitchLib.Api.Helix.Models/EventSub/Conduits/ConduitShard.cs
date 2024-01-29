﻿using Newtonsoft.Json;

namespace TwitchLib.Api.Helix.Models.EventSub.Conduits;

public sealed class ConduitShard
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }
    [JsonProperty(PropertyName = "shard_count")]
    public int ShardCount { get; set; }
}