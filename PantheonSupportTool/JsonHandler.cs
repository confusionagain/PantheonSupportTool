using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JsonHandler
{
    public class JsonFileHandler
    {
        private readonly string _filePath;

        public JsonFileHandler(string filePath)
        {
            _filePath = filePath;
            EnsureFileExists();
        }

        private void EnsureFileExists()
        {
            string directoryPath = Path.GetDirectoryName(_filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "{}");
            }
        }

        private Dictionary<string, object> LoadJson()
        {
            return LoadOrCreateJson();
        }

        private void SaveJson(Dictionary<string, object> jsonData)
        {
            string formattedJson = SerializeJson(jsonData);
            File.WriteAllText(_filePath, formattedJson);
        }

        private Dictionary<string, object> LoadOrCreateJson()
        {
            if (!File.Exists(_filePath))
            {
                return new Dictionary<string, object>();
            }

            using (var stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
            {
                return stream.Length == 0 ? new Dictionary<string, object>() : DeserializeJson(stream);
            }
        }

        private Dictionary<string, object> DeserializeJson(Stream stream)
        {
            var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };
            var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, object>), settings);
            return serializer.ReadObject(stream) as Dictionary<string, object> ?? new Dictionary<string, object>();
        }

        private string SerializeJson(Dictionary<string, object> jsonData)
        {
            var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };
            var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, object>), settings);

            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, jsonData);
                ms.Position = 0;
                using (var reader = new StreamReader(ms))
                {
                    string json = reader.ReadToEnd();
                    return PrettyPrintJson(json);
                }
            }
        }

        public void SetValue(string keyPath, object value)
        {
            var jsonData = LoadJson();
            SetNestedValue(jsonData, keyPath.Split('.'), value);
            SaveJson(jsonData);
        }

        private void SetNestedValue(Dictionary<string, object> data, string[] keys, object value, int index = 0)
        {
            string key = keys[index];

            if (index == keys.Length - 1)
            {
                data[key] = value;
                return;
            }

            if (!(data.ContainsKey(key) && data[key] is Dictionary<string, object>))
            {
                data[key] = new Dictionary<string, object>();
            }

            SetNestedValue((Dictionary<string, object>)data[key], keys, value, index + 1);
        }

        public bool DeleteEntry(string keyPath)
        {
            var jsonData = LoadJson();
            bool deleted = DeleteNestedEntry(jsonData, keyPath.Split('.'));
            if (deleted)
            {
                SaveJson(jsonData);
            }
            return deleted;
        }

        private bool DeleteNestedEntry(Dictionary<string, object> data, string[] keys, int index = 0)
        {
            string key = keys[index];

            if (!data.ContainsKey(key))
            {
                return false;
            }

            if (index == keys.Length - 1)
            {
                data.Remove(key);
                return true;
            }

            if (data[key] is Dictionary<string, object> nestedDict)
            {
                bool deleted = DeleteNestedEntry(nestedDict, keys, index + 1);
                if (deleted && nestedDict.Count == 0)
                {
                    data.Remove(key); // Clean up empty dictionaries
                }
                return deleted;
            }
            return false;
        }

        public object GetValue(string keyPath)
        {
            var jsonData = LoadJson();
            object value = GetNestedValue(jsonData, keyPath.Split('.'));
            return value;
        }

        private object GetNestedValue(Dictionary<string, object> data, string[] keys, int index = 0)
        {
            string key = keys[index];

            if (!data.ContainsKey(key))
            {
                return null;
            }

            if (index == keys.Length - 1)
            {
                return data[key];
            }

            if (data[key] is Dictionary<string, object> nestedDict)
            {
                return GetNestedValue(nestedDict, keys, index + 1);
            }

            return null;
        }

        // A simple JSON pretty printer that adds line breaks and indentation.
        private static string PrettyPrintJson(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return json;
            }

            int indentLevel = 0;
            bool inQuotes = false;
            var sb = new StringBuilder();
            for (int i = 0; i < json.Length; i++)
            {
                char ch = json[i];

                if (ch == '\"')
                {
                    // Check if the quote is escaped.
                    bool escaped = false;
                    int j = i - 1;
                    while (j >= 0 && json[j] == '\\')
                    {
                        escaped = !escaped;
                        j--;
                    }
                    if (!escaped)
                    {
                        inQuotes = !inQuotes;
                    }
                    sb.Append(ch);
                }
                else if (!inQuotes)
                {
                    if (ch == '{' || ch == '[')
                    {
                        sb.Append(ch);
                        sb.AppendLine();
                        indentLevel++;
                        sb.Append(new string(' ', indentLevel * 2));
                    }
                    else if (ch == '}' || ch == ']')
                    {
                        sb.AppendLine();
                        indentLevel--;
                        sb.Append(new string(' ', indentLevel * 2));
                        sb.Append(ch);
                    }
                    else if (ch == ',')
                    {
                        sb.Append(ch);
                        sb.AppendLine();
                        sb.Append(new string(' ', indentLevel * 2));
                    }
                    else if (ch == ':')
                    {
                        sb.Append(ch);
                        sb.Append(" ");
                    }
                    else if (!char.IsWhiteSpace(ch))
                    {
                        sb.Append(ch);
                    }
                }
                else
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }
    }
}
