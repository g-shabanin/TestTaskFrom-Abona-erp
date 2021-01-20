using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace InventoryXPO {
    public static class ConnectionHelper
    {

        static readonly Type[] PersistentTypes = new Type[]{
            typeof(Customer),
            typeof(Order),
            typeof(Item),
            typeof(ItemInStock),
            typeof(OrderDetail),
            typeof(OrderStatusEnumTable)
        };

        public static void Connect(bool threadSafe = true)
        {
            XpoDefault.DataLayer = CreateDataLayer(threadSafe);
        }

        static IDataLayer CreateDataLayer(bool threadSafe)
        {
            //Configuration config = null;
            //string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //string assmblyName = Assembly.GetExecutingAssembly().GetName().Name;


            //try
            //{
            //    var s = assemblyFolder + "\\" + assmblyName + ".dll.config";
            //    config = ConfigurationManager.OpenExeConfiguration(s);
            //    var value = config.ConnectionStrings.CurrentConfiguration.Sections;
            //}
            //catch (Exception ex)
            //{
            //    //handle errror here.. means DLL has no sattelite configuration file.
            //}
            //string connStr = ConfigurationManager.ConnectionStrings["InventoryXPO"].ConnectionString;
            string connStr = "XpoProvider=InMemoryDataStore";
            connStr = XpoDefault.GetConnectionPoolString(connStr);  // Uncomment this line if you use a database server like SQL Server, Oracle, PostgreSql etc.
            ReflectionDictionary dictionary = new ReflectionDictionary();
            dictionary.GetDataStoreSchema(PersistentTypes);   // Pass all of your persistent object types to this method.
            AutoCreateOption autoCreateOption = AutoCreateOption.DatabaseAndSchema;  // Use AutoCreateOption.DatabaseAndSchema if the database or tables do not exist. Use AutoCreateOption.SchemaAlreadyExists if the database already exists.
            IDataStore provider = XpoDefault.GetConnectionProvider(connStr, autoCreateOption);
            return threadSafe ? (IDataLayer)new ThreadSafeDataLayer(dictionary, provider) : new SimpleDataLayer(dictionary, provider);
        }
    }
}
