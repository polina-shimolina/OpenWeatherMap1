﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Class
    {
        
        public string result;
        WebRequest request;
        Weather weather;
        public Class()
        {
            
        }
        public void ChangeRequest(string input)
        {
            request = WebRequest.Create(input);
        }
        public void Search()
        { 
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            weather = JsonConvert.DeserializeObject<Weather>(responseFromServer);
            result = $" temperature in {weather.name}: {weather.main.temp} °C";
        }
        public void MessageShow()
        {
           MessageBox.Show(result);
        }
    }
}
