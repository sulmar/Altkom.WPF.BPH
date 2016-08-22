using Altkom.RentBike.Models;
using Altkom.RentBike.Services;
using Altkom.RentBike.ViewModels.Commands;
using Altkom.RentBikes.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Altkom.RentBike.ViewModels
{
    public class StationsViewModel : BaseViewModel
    {
        private IList<Station> _Stations;
        public IList<Station> Stations
        {
            get
            {
                return _Stations;
            }

            set
            {
                _Stations = value;

                OnPropertyChanged(nameof(Stations));
            }
        }

        private Station _SelectedStation;
        public Station SelectedStation
        {
            get
            {
                return _SelectedStation;
            }

            set
            {
                _SelectedStation = value;
                OnPropertyChanged("SelectedStation");
            }
        }

        private readonly IStationsService _StationsService;

        public StationsViewModel()
        {
            this._StationsService = new MockStationsService();

            Load();
        }

        private ICommand _LoadCommand;

        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new RelayCommand(p => Load());
                }

                return _LoadCommand;
            }
        }

        private void Load()
        {
            // Symulacja opóźnienia
            Task.Delay(5000).Wait();

            Stations = _StationsService.GetStations();
            
            SelectedStation = Stations.LastOrDefault();
        }


        private ICommand _AsyncLoadCommand;

        public ICommand AsyncLoadCommand
        {
            get
            {
                if (_AsyncLoadCommand == null)
                {
                    _AsyncLoadCommand = new AsyncRelayCommand(p => LoadAsync());
                }

                return _AsyncLoadCommand;
            }
        }


        public async Task LoadAsync()
        {
            await Task.Run(() => Load());
         

            await Task.Run(() => UpdateStation());

        }



        #region UpdateStationCommand

        private ICommand _UpdateStationCommand;

        public ICommand UpdateStationCommand
        {
            get
            {
                if (_UpdateStationCommand == null)
                {
                    _UpdateStationCommand = new RelayCommand(p => UpdateStation(), p=> CanUpdateStation);
                }

                return _UpdateStationCommand;
            }
        }

     

        public void UpdateStation()
        {
            this.SelectedStation.Number = "ST999";
            this.SelectedStation.Name = "Stacja 999";
        }

        public bool CanUpdateStation
        {
            get
            {
                return true;
            }
        }
       


        #endregion

    }
}
