using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace modul8_1302220152
{
    internal class BankTransferConfig
    {
        public Config config;

        // public string lang { get { return config.lang; } set { config.lang = new; } }

        public BankTransferConfig()
        {
            string jsText = File.ReadAllText("../../../../bank_transfer_config.json");

            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };
            config = JsonSerializer.Deserialize<Config>(jsText, options);
        }

    }
    public class Config
    {
        public string lang;
        public Transfer transfer;
        public string[] methods;
        public Confirmation confirmation;
    }
    public class Transfer
    {
        public int threshold;
        public int low_fee;
        public int high_fee;
    }
    public class Confirmation
    {
        public string en;
        public string id;
    }
}
