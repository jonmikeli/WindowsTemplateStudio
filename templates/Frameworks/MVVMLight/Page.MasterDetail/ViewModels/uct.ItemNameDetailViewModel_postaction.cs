using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
namespace ItemNamespace.ViewModels
{
    public class uct.ItemNameDetailViewModel : ViewModelBase
    {

        //{[{
        public NavigationServiceEx NavigationService
        {
            get
            {
                return Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<NavigationServiceEx>();
            }
        }
        //}]}
    }
}