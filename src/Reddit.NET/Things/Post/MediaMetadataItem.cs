using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.Things
{
    public class MediaMetadataItem
    {


        [JsonProperty("o")]
        public OriginalImage[] OriginalImages { get; set; }
    }

    public class OriginalImage
    {
        [JsonProperty("u")]
        public String URL { get; set; }
    }
}
