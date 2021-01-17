using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Market.MVCWebUI.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            var stringObject = JsonConvert.SerializeObject(value);
            session.SetString(key,stringObject);
        }

        public static T GetObject<T>(this ISession session, string key) where T:class
        {
            var stringObject = session.GetString(key);
            if (String.IsNullOrEmpty(stringObject))
            {
                return null;
            }
            else
            {
                var value = JsonConvert.DeserializeObject<T>(stringObject);
                return value;
            }
            
        }
    }
}
