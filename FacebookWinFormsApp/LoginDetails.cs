using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class LoginDetails
    {
        public string LastAccessToken { get; set; }

        public bool RememberUser { get; set; }

        public static LoginDetails LoadFromFile()
        {
            LoginDetails obj = new LoginDetails();
            if (File.Exists("AppSettings.xml"))
            {
                using (Stream stream = new FileStream("AppSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(LoginDetails));
                    obj = serializer.Deserialize(stream) as LoginDetails;
                }
            }

            return obj;
        }

        public LoginDetails()
        {
            LastAccessToken = null;
            RememberUser = false;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream("AppSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(LoginDetails));
                serializer.Serialize(stream, this);
            }
        }
    }
}
