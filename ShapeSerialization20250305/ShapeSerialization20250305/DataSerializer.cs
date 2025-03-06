using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShapeSerialization20250305
{
    internal class DataSerializer
    {
        // the object data type empowers this function to work with any other kind of type
        public void SerializeBinary(object data, string filePath)
        {
            using FileStream fs = new FileStream(filePath, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, data);
        }
        public object DeserializeBinary(string filePath)
        {
            using FileStream fs = new FileStream(filePath, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(fs);
            return obj;
        }
        public void SerializeXml<T>(T obj, string filename)
        {
            using StreamWriter writer = new StreamWriter(filename);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(writer, obj);
        }
        public T DeserializeXml<T>(string filename)
        {
            using StreamReader reader = new StreamReader(filename);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(reader);
        }
        public void SerializeJson<T>(T obj, string filename)
        {
            string jsonString = JsonSerializer.Serialize(obj,new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, jsonString);
        }
        public T DeserializeJson<T>(string filename)
        {
            string jsonString = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
