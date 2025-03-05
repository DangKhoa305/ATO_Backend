using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class SystemConfigurations
    {
        public int ConfigId { get; set; }
        public ConfigType ConfigType { get; set; }
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
    public enum ConfigType
    {
        EmailConfig,
        VnPayConfig
    }
}
