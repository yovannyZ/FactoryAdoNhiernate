using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConnectionString
    {
        public static string _sql;

        protected static string Sql
        {
            get
            {
                if (_sql == null)
                {
                    //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                    //ConfigurationSectionGroup userSetting = config.GetSectionGroup("userSettings");
                    //ClientSettingsSection settings = (ClientSettingsSection)userSetting.Sections.Get(0);
                    //SettingElement srvElem = settings.Settings.Get("Servidor");
                    //SettingElement bdElem = settings.Settings.Get("BaseDatos");
                    //string ServerName = string.Empty;
                    //string BaseDatos = string.Empty;
                    //if (srvElem != null)
                    //    ServerName = srvElem.Value.ValueXml.InnerText;
                    //if (bdElem != null)
                    //    BaseDatos = bdElem.Value.ValueXml.InnerText;

                    _sql = string.Format("Data Source={0};Initial Catalog=BD_PLA{1};User=miguel;password=main", "DESKTOP-ADMKICT", "01");
                }
                return _sql;
            }


        }
    }
}
