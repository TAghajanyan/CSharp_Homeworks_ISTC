using Newtonsoft.Json;

namespace ThirdStage.Serializ_Deserialize_Json_Data
{
    public static class Serialize_JSON
    {
        public static string Serialize(Rootobject ob)
        {
            return JsonConvert.SerializeObject(ob);
        }
    }
}