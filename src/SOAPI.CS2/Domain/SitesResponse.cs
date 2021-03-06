﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SOAPI.CS2.Domain
{
    public class SitesResponse : CollectionResponse<Site>
    {
        [JsonProperty("api_sites")]
        public override List<Site> Items { get; set; }
    }
}
