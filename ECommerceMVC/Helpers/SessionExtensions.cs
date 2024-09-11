using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ECommerceMVC.Helpers
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            var serializedObject = JsonConvert.SerializeObject(value);
            session.SetString(key, serializedObject);
        }

        public static T Get<T>(this ISession session, string key)
        {
            var serializedObject = session.GetString(key);
            return serializedObject == null ? default(T) : JsonConvert.DeserializeObject<T>(serializedObject);
        }

        public static void Remove(this ISession session, string key)
        {
            session.Remove(key);
        }
    }
}
