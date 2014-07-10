using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Protell.Model;
using Protell.Server.DAL.Repository.v2;


namespace Protell.Service.Services
{
    //Comentario de prueba
    //otro
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [DataContractFormat]
    public class Download : IDownload
    {
        public bool PingServer()
        {
            return true;
        }

        

        public ObservableCollection<AppSettingsModel> Download_Settings(long LastModifiedDate, long ServerLastModifiedDate)
        {
            ObservableCollection<AppSettingsModel> result = new ObservableCollection<AppSettingsModel>();
            try
            {
                using(var repository=new AppSettingsRepository())
                {
                    result = repository.GetSettings(LastModifiedDate, ServerLastModifiedDate);
                }
            }
            catch (Exception)
            {
                                
            }
            return result;
        }

    }
}
