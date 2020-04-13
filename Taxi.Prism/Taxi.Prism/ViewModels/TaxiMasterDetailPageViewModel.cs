using Prism.Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Taxi.Common.Models;

namespace Taxi.Prism.ViewModels
{
    public class TaxiMasterDetailPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public TaxiMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            LoadMenus();
        }

        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        private void LoadMenus()
        {
            List<Menu> menus = new List<Menu>
            {
                new Menu
                {
                    Icon = "ic_airport_shuttle",
                    PageName = "HomePage",
                    Title = "Nuevo viaje"
                },
                new Menu
                {
                    Icon = "ic_local_taxi",
                    PageName = "TaxiHistoryPage",
                    Title = "Ver historia de taxi"
                },
                new Menu
                {
                    Icon = "ic_people",
                    PageName = "GroupPage",
                    Title = "Admin mi grupo de usuario"
                },
                new Menu
                {
                    Icon = "ic_account_circle",
                    PageName = "ModifyUserPage",
                    Title = "Modificar usuario"
                },
                new Menu
                {
                    Icon = "ic_report",
                    PageName = "ReportPage",
                    Title = "Reportar un incidente"
                },
                new Menu
                {
                    Icon = "ic_exit_to_app",
                    PageName = "LoginPage",
                    Title = "Loguearse"
                }
            };

            Menus = new ObservableCollection<MenuItemViewModel>(
                menus.Select(m => new MenuItemViewModel(_navigationService)
                {
                    Icon = m.Icon,
                    PageName = m.PageName,
                    Title = m.Title
                }).ToList());
        }
    }
}
