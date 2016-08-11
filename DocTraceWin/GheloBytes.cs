using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Drawing;

namespace DocTrace
{
    public class GheloBytes
    {
        public static bool IsNumeric(string strNumber)
        {
            if (strNumber == null)
                return false;

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
            double dummyOut;
            return Double.TryParse(strNumber, System.Globalization.NumberStyles.Any, cultureInfo.NumberFormat, out dummyOut);
        }


        public static string GetSetting(string section, string setting, string attribute)
        {
            string configFile = Application.StartupPath + @"\config.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);
            return node.Attributes[attribute].Value;
        }

        public static void SaveSetting(string section, string setting, string attribute, string value)
        {
            string configFile = Application.StartupPath + @"\config.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);

            node.Attributes[attribute].Value = value;
            doc.Save(configFile);
        }
        public static string ConnectionString()
        {
            string dbName = GheloBytes.GetSetting("datasource", "database", "name");
            string serverName = GheloBytes.GetSetting("datasource", "server", "name");
            string login = GheloBytes.GetSetting("datasource", "security", "login");
            string password = GheloBytes.GetSetting("datasource", "security", "password");
            string connString = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", serverName, dbName, login, password);
            return connString;
        }

        public static string ConnectionStringDecrypted(int cipherKey)
        {
            string dbName = GheloBytes.GetSetting("datasource", "database", "name");
            string serverName = GheloBytes.GetSetting("datasource", "server", "name");
            string login = GheloBytes.GetSetting("datasource", "security", "login");
            string password = GheloBytes.GetSetting("datasource", "security", "password");

            dbName = GheloBytes.EncryptDecrypt(dbName, cipherKey);
            serverName = GheloBytes.EncryptDecrypt(serverName, cipherKey);
            login = GheloBytes.EncryptDecrypt(login, cipherKey);
            password = GheloBytes.EncryptDecrypt(password, cipherKey);

            string connString = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", serverName, dbName, login, password);
            return connString;
        }
        public static string EncryptDecrypt(string textToEncrypt, int key)
        {
            StringBuilder inSb = new StringBuilder(textToEncrypt);
            StringBuilder outSb = new StringBuilder(textToEncrypt.Length);
            char c;
            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                c = inSb[i];
                c = (char)(c ^ key);
                outSb.Append(c);
            }
            return outSb.ToString();
        }

        public static List<Paper> Papers()
        {
            List<Paper> papers = new List<Paper>();
            string paperFile = Application.StartupPath + @"\papers.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(paperFile);

            XmlNode papersNode = doc.SelectSingleNode("papers");
            
            foreach (XmlNode paperNode in papersNode.ChildNodes)
            {
                string name = paperNode.Attributes["name"].Value;
                int width = Convert.ToInt32(paperNode.Attributes["width"].Value);
                int height = Convert.ToInt32(paperNode.Attributes["height"].Value);
                bool isDefault = (GheloBytes.GetSetting("printing", "paper", "name") == name);
                
                Paper paper = new Paper(name, width, height);
                if (isDefault)
                    Paper.Default = paper;

                foreach (XmlNode coordinateNode in paperNode.SelectSingleNode("locations").ChildNodes)
                {
                    string id = coordinateNode.Attributes["id"].Value;
                    int x = Convert.ToInt32(coordinateNode.Attributes["x"].Value);
                    int y = Convert.ToInt32(coordinateNode.Attributes["y"].Value);
                    paper.Coordinates.Add(Convert.ToInt32(id), new Paper.Coordinate(id, x, y));
                }

                papers.Add(paper);
                
            }
            return papers;
        }

        public static Point ToHundredInches(int millimeter_x, int millimeter_y)
        {
            int x = Convert.ToInt32((millimeter_x / 25.4f) * 100);
            int y = Convert.ToInt32((millimeter_y / 25.4f) * 100);
            return new Point(x, y);
        }
        public static int ToHundredInches(int mm)
        {
            return Convert.ToInt32((mm / 25.4f) * 100);
        }


        public class Paper
        {
            public static Paper Default;
            public Paper(string name, int width, int height)
            {
                this._Name = name;
                this._Width = width;
                this._Height = height;
            }

            private string _Name;
            public string Name { 
                get 
                {
                    return _Name;
                }
            }

            private int _Width;
            public int Width
            {
                get
                {
                    return _Width;
                }
            }

            private int _Height;
            public int Height
            {
                get
                {
                    return _Height;
                }
            }

            private Dictionary<int, Coordinate> _Coordinates = new Dictionary<int,Coordinate>();
            public Dictionary<int, Coordinate> Coordinates
            {
                get
                {
                    return _Coordinates;
                }
                
            }

            public class Coordinate
            {
                public Coordinate(string id, int x, int y)
                {
                    _ID = id;
                    _X = x;
                    _Y = y;
                }

                private string _ID;
                public string ID
                {
                    get
                    {
                        return _ID;
                    }
                }

                private int _X;
                public int X
                {
                    get
                    {
                        return _X;
                    }
                }

                private int _Y;
                public int Y
                {
                    get
                    {
                        return _Y;
                    }
                }


            }

        }





    }
}
