using System.Net;
using Newtonsoft.Json;


namespace ThirdStage.Serializ_Deserialize_Json_Data
{
    public static class Deserialize_JSON
    {
        public static Rootobject Deserialize(string address)
        {
             return JsonConvert.DeserializeObject<Rootobject>(new WebClient().DownloadString(address)) as Rootobject;
        }
    }
}