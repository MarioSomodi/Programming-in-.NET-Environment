using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace UsersLib
{
    public class UserRepository
    {
        public List<User> DohvatiKorisnike() 
        {
            string json = CallRestMethod("https://thetrueboolean.com/people.json");
            JArray jsonArray = JArray.Parse(json);
            List<User> users = new List<User>();
            foreach (JObject jsonO in jsonArray)
            {
                string firstname, lastname, email, country, modified;
                int id;
                bool vip;

                if (String.IsNullOrWhiteSpace(Convert.ToString((int)jsonO.GetValue("id"))))
                {
                    id = 0;
                }
                else
                {
                    id = (int)jsonO.GetValue("id");
                }
                if (String.IsNullOrWhiteSpace((string)jsonO.GetValue("first_name")))
                {
                    firstname = "/";
                }
                else
                {
                    firstname = (string)jsonO.GetValue("first_name");
                }
                if (String.IsNullOrWhiteSpace((string)jsonO.GetValue("last_name")))
                {
                    lastname = "/";
                }
                else
                {
                    lastname = (string)jsonO.GetValue("last_name");
                }
                if (String.IsNullOrWhiteSpace((string)jsonO.GetValue("email")))
                {
                    email = "/";
                }
                else
                {
                    email = (string)jsonO.GetValue("email");
                }
                if (String.IsNullOrWhiteSpace((string)jsonO.GetValue("country")))
                {
                    country = "/";
                }
                else
                {
                    country = (string)jsonO.GetValue("country");
                }
                if (String.IsNullOrWhiteSpace((string)jsonO.GetValue("modified")))
                {
                    modified = "/";
                }
                else
                {
                    modified = (string)jsonO.GetValue("modified");
                }
                if (String.IsNullOrWhiteSpace(Convert.ToString((bool)jsonO.GetValue("vip"))))
                {
                    vip = false;
                }
                else
                {
                    vip = (bool)jsonO.GetValue("vip");
                }

                users.Add(new User
                {
                    firstName = firstname,
                    lastName = lastname,
                    Email = email,
                    Country = country,
                    Modified = modified,
                    Vip = vip
                });
            }
            return users;
        }
        private string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
    }
}
