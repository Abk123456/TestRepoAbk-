using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Trash.DAL
{
    public class TrashDbContext
    {

    }
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            //session.SetString(key, JsonConvert.SerializeObject(value));
        }

        //public static T GetObjectFromJson<T>(this ISession session, string key)
        //{
        //    //var value = session.GetString(key);
        //    return key;//value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        //}
    }
}