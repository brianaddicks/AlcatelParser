using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Web;

namespace AlcatelParser {
	
    public class Interface {
		public string Name;
		public string IpAddress;
        public int Vlan;
        public int IfIndex;
    }
}