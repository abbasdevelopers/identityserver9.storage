﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace IdentityServer9.Stores.Serialization
{
    public class CustomContractResolver: DefaultContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            var props = base.CreateProperties(type, memberSerialization);
            return props.Where(p => p.Writable).ToList();
        }
    }
}