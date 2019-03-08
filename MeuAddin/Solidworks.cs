using MeuAddin;
using SolidWorks.Interop.sldworks;
namespace Teste
{

    public class teste : MySampleAddin
    {
        public override void ApplicationStartup(SldWorks solidWorks)
        {
            SldWorks swApp;
            swApp = solidWorks;      
            swApp.SendMsgToUser("Classe derivada");
        }
    }
}
