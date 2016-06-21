using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GHMonitor.ViewModel
{
    public class GHSectionViewModel : ViewModelBase
    {
        public string GHName { get; set; }

        public GHSectionViewModel(string name)
        {
            GHName = name;
        }

        /// <summary>
        /// The <see cref="Temperature" /> property's name.
        /// </summary>
        public const string TemperaturePropertyName = "Temperature";

        private Single _temperatureProperty = 0f;

        /// <summary>
        /// Sets and gets the Temperature property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public Single Temperature
        {
            get
            {
                return _temperatureProperty;
            }

            set
            {
                if (_temperatureProperty == value)
                {
                    return;
                }

                _temperatureProperty = value;
                RaisePropertyChanged(TemperaturePropertyName);
            }
        }

        /// <summary>
        /// The <see cref="Moisture" /> property's name.
        /// </summary>
        public const string MoisturePropertyName = "Moisture";

        private Single _moistureProperty = 0f;

        /// <summary>
        /// Sets and gets the Moisture property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public Single Moisture
        {
            get
            {
                return _moistureProperty;
            }

            set
            {
                if (_moistureProperty == value)
                {
                    return;
                }

                _moistureProperty = value;
                RaisePropertyChanged(MoisturePropertyName);
            }
        }
    }
}
