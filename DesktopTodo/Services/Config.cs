using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DesktopTodo.Services
{
    class Config : ISingleton
    {
        private string _sessionKey;
        public string SessionKey 
        {
            get => _sessionKey;
            set
            {
                _sessionKey = value;
                IsLogged = true;
            }
        }
        public bool IsLogged { get; set; }
        private static readonly string _path = Directory.GetCurrentDirectory() + @"\config.json";
        public Config()
        {
            LoadData();
        }

        public void SaveData()
        {
            JObject json = new JObject();
            json["session_id"] = SessionKey;

            File.WriteAllText(_path, json.ToString());
        }

        // Maybe save last login time...
        private bool LoadData()
        {
            if(File.Exists(_path))
            {
                string data = File.ReadAllText(_path);
                JObject json = JObject.Parse(data);

                if(!string.IsNullOrEmpty(json["session_id"].ToString()))
                {
                    SessionKey = json["session_id"].ToString();
                }
            }

            return false;
        }
    }
}
