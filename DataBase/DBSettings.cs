using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
 

namespace DBConnLib
{
    
    
    public struct TESTINFO
    {
        public double lowThreshold;
        public double highThreshold;
        public double testValue;
        public string testName;
        public bool Enabled;
    }
    public class AppConfig
    { 
       
        public List<TESTINFO> tests;
    }

    public sealed class AppSettings
    {
        private static AppSettings instance = null;
        private static readonly object padlock = new object();
        AppConfig m_config;
        string m_fileName;

        AppSettings()
        {
        }
        public AppConfig Config
        {
            get
            {
                return m_config;
            }
        }

        public void Default()
        {
            m_config = new AppConfig();
            m_config.tests = new List<TESTINFO>();
            TESTINFO t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);

            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);


            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);
            t = new TESTINFO
            {
                testName = "test1",
                highThreshold = 100,
                lowThreshold = 20,
                testValue = 0,
                Enabled = true
            };
            m_config.tests.Add(t);



        }
         
        public string Save()
        {
            try
            {
               
                
                string json = JsonConvert.SerializeObject(m_config);
                string jsonFormatted = JValue.Parse(json).ToString(Formatting.Indented);                    
                File.WriteAllText(m_fileName, jsonFormatted);
               
                return "ok";
            }
            catch (Exception err)
            {
                return err.Message;
            }
        }
        
        public string Load(string fileName)
        {
            try
            {
                m_fileName = fileName;
                if (File.Exists(fileName) == false)
                {
                    m_config = new AppConfig();
                    Default();
                    Save();
                    return "file not found";
                }
                string text = File.ReadAllText(m_fileName);
                m_config = JsonConvert.DeserializeObject<AppConfig>(text);
                if (m_config == null)
                {
                    m_config = new AppConfig();
                    Default();
                    Save();
                }
                   
                return "ok";
            }
            catch (Exception err)
            {
                m_config = new AppConfig();
                return err.Message;
            }
        }
      
        public static AppSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new AppSettings();
                        }
                    }
                }
                return instance;
            }
        }
    }

}
