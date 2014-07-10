using System.ServiceModel;
using System.ServiceModel.Web;
using Protell.Model;
using System.Collections.ObjectModel;


namespace Protell.Service.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IDownload" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IDownload
    {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        bool PingServer();
        
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        ObservableCollection<AppSettingsModel> Download_Settings(long LastModifiedDate, long ServerLastModifiedDate);
      
    }
}
