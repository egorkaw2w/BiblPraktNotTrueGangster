using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace jsoner
{
    public class SerialDes
    {
        List<human> humanList;
        public static void Ser(string name, string favan)
        {
            List<human> humanList = new List<human>();
            human asd = new human(name, favan);
            humanList.Add(asd);
            string json = JsonConvert.SerializeObject(humanList);
            File.WriteAllText("chel.json", json);
        }
        public static T Des<T>(string filename)
        {
            T types = JsonConvert.DeserializeObject<T>(File.ReadAllText(filename));
            return types;
        }

    }
}

