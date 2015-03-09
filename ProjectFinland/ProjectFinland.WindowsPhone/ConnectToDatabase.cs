using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace ProjectFinland
{
    class ConnectToDatabase
    {
        public static MobileServiceClient MobileService = new MobileServiceClient(
          "http://localhost:50522"
);
        // Use this constructor instead after publishing to the cloud
        // public static MobileServiceClient MobileService = new MobileServiceClient(
        //      "https://kidslist.azure-mobile.net/",
        //      "LIvhiOaaECUZQfozduynGmJGyhazay72"
        //);

        
    }

    public class Parent
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public bool Pasword { get; set; }
    }
}
