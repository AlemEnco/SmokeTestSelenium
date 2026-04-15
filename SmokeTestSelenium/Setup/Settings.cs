using Newtonsoft.Json;
using SmokeTestSelenium.Setup.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeTestSelenium.Setup
{
    public class Settings
    {
        public Int16 SmWaitTime { get; set; }
        public String? Test { get; set; }
        public AppointmentEntity Data { get; set; }
        public string Message { get; set; }

        public Settings(Int16 waitTime, String test)
        {
            SmWaitTime = waitTime;
            Test = test;

            GetAppointmentEntity();
        }

        private void GetAppointmentEntity()
        {
            Data = new AppointmentEntity();
            String source = $"D:/Proyectos/ProyectoGitHub/rw-automation/Setup/Data/data{Test}.json";

            using (StreamReader r = new StreamReader(source))
            {
                String json = r.ReadToEnd();
                if (!String.IsNullOrEmpty(json))
                {
                    Data = JsonConvert.DeserializeObject<AppointmentEntity>(json);
                }
            }
        }
    }
}
