using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Entity.DomainModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Market_MVCWebUI.Extensions
{
    public static class SessionExtensionMethods
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string stringObject = JsonConvert.SerializeObject(value);
            session.SetString(key,stringObject);
        }

        public static T GetObject<T>(this ISession session, string key) where T:class
        {
            string stringObject = session.GetString(key);
            if (String.IsNullOrEmpty(stringObject))
            {
                return null;
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(stringObject);
            }
        }
    }
}
