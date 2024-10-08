using CommunityToolkit.Mvvm.ComponentModel;
using Pam_Study.Services;
using System.Collections.ObjectModel;

namespace Pam_Study.Views
{
    public partial class MonitorViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Models.Monitor> monitores;

        public async void getMonitores()
        {
            monitores = await new MonitorService().getAllMonitorsAsync();
        }
        
    }
}
