using System.Text.Json;

namespace Levent
{
    namespace JsonSerializeMachine
    {
        public static class SerializationJson
        {
            /// <summary>
            /// Converting object to json
            /// </summary>
            /// <param name="obj">Object to be converted</param>
            public static string toJson(Object obj)
            {
                string jsonData = JsonSerializer.Serialize<Object>(obj);

                return jsonData;
            }

            /// <summary>
            /// Converting object list to json
            /// </summary>
            /// <param name="obj">Object list to be converted</param>
            public static string toJson(List<Object> obj)
            {
                string jsonData = JsonSerializer.Serialize<List<Object>>(obj);
                return jsonData;
            }

            /// <summary>
            /// Converting jsonString to object
            /// </summary>
            /// <param name="jsonData">jsonString to be converted</param>
            /// <typeparam name="T"> object type</>
            public static T fromJson<T>(string jsonData)
            {
                var serialized = JsonSerializer.Deserialize<T>(jsonData)!;
                return serialized;
            }

            /// <summary>
            /// Converting jsonString to objectList
            /// </summary>
            /// <param name="jsonData">jsonString to be converted</param>
            /// <typeparam name="T"> object type</>
            public static List<T> fromJsonList<T>(string jsonData)
            {
                var serialized = JsonSerializer.Deserialize<List<T>>(jsonData)!;
                return serialized;
            }
        }
    }
}