using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;

namespace Core.Controllers
{
    public static class SessionController
    {
        private static string _connectionString = "XpoProvider=SQLite;Data Source=bia.ge.s3db";
        
        private static Session _simpleDataLayer;
        public static Session GetSessionSimpleDataLayer()
        {
            if (_simpleDataLayer is null)
            {
                var xpoTypeInfoSource = XpoTypesInfoHelper.GetXpoTypeInfoSource().XPDictionary;
                var connectionProvider = XpoDefault.GetConnectionProvider(_connectionString, AutoCreateOption.DatabaseAndSchema);
                
                var simpleDataLayer = new SimpleDataLayer(xpoTypeInfoSource, connectionProvider);
                _simpleDataLayer = new Session(simpleDataLayer, null) 
                { 
                    LockingOption = LockingOption.None, 
                    TrackPropertiesModifications = true 
                };

                _simpleDataLayer.CreateObjectTypeRecords();
                _simpleDataLayer.UpdateSchema();                
            }

            return _simpleDataLayer;
        }
                
        private static Session _threadSafeDataLayer; 
        public static Session GetSessionThreadSafeDataLayer()
        {
            if (_threadSafeDataLayer is null)
            {
                var connectionPoolString = XpoDefault.GetConnectionPoolString(_connectionString, -1, -1);
                var connectionProvider = XpoDefault.GetConnectionProvider(connectionPoolString, AutoCreateOption.None);
                var dictionary = new ReflectionDictionary();                
                
                var threadSafeDataLayer = new ThreadSafeDataLayer(dictionary, connectionProvider);
                _threadSafeDataLayer = new Session(threadSafeDataLayer, null)
                {
                    LockingOption = LockingOption.None,
                    TrackPropertiesModifications = true
                };

                XpoDefault.Session = _threadSafeDataLayer;
                XpoDefault.DataLayer = _threadSafeDataLayer.DataLayer;
            }

            return _simpleDataLayer;
        }
    }
}
