﻿using System.Net;

namespace Zoxive.HttpLoadTesting.Framework.Model
{
    public class HttpStatusCodeCount
    {
        public HttpStatusCodeCount(HttpStatusCode statusCodeName, long count)
        {
            StatusCodeName = statusCodeName.ToString();
            StatusCode = (int) statusCodeName;
            Count = count;
        }
        
        public string StatusCodeName { get; private set; }

        public int StatusCode { get; private set; }

        public long Count { get; private set; }
    }
}