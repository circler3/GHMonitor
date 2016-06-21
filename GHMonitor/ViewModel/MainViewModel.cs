using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading;

namespace GHMonitor.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                // Code runs "for real"
                
            }
            for (int i = 1; i < 31; i++)
            {
                SectionA.Add(new GHSectionViewModel("A" + i));
            }
            for (int i = 1; i < 31; i++)
            {
                SectionB.Add(new GHSectionViewModel("B" + i));
            }
            for (int i = 1; i < 27; i++)
            {
                SectionC.Add(new GHSectionViewModel("C" + i));
            }
            for (int i = 1; i < 13; i++)
            {
                SectionD.Add(new GHSectionViewModel("D" + i));
            }
            Thread th = new Thread(Sync);
            th.IsBackground = true;
            th.Start();
        }

        private void Sync()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("http://localhost:49988/api/products");
            response.Wait();
            if(response.Result.IsSuccessStatusCode)
            {
                var responseBody = response.Result.Content.ReadAsStringAsync();
                responseBody.Wait();
                var x = (JsonConvert.DeserializeObject<string>(responseBody.Result));
            }
            Thread.Sleep(30000);
        }

        /// <summary>
        /// The <see cref="SectionA" /> property's name.
        /// </summary>
        public const string SectionAPropertyName = "Sections";

        private ObservableCollection<GHSectionViewModel> _sectionAProperty = new ObservableCollection<GHSectionViewModel>();

        /// <summary>
        /// Sets and gets the Sections property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<GHSectionViewModel> SectionA
        {
            get
            {
                return _sectionAProperty;
            }

            set
            {
                if (_sectionAProperty == value)
                {
                    return;
                }

                _sectionAProperty = value;
                RaisePropertyChanged(SectionAPropertyName);
            }
        }

        /// <summary>
        /// The <see cref="SectionB" /> property's name.
        /// </summary>
        public const string SectionBPropertyName = "Sections";

        private ObservableCollection<GHSectionViewModel> _sectionBProperty = new ObservableCollection<GHSectionViewModel>();

        /// <summary>
        /// Sets and gets the Sections property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<GHSectionViewModel> SectionB
        {
            get
            {
                return _sectionBProperty;
            }

            set
            {
                if (_sectionBProperty == value)
                {
                    return;
                }

                _sectionBProperty = value;
                RaisePropertyChanged(SectionBPropertyName);
            }
        }

        /// <summary>
        /// The <see cref="SectionC" /> property's name.
        /// </summary>
        public const string SectionCPropertyName = "Sections";

        private ObservableCollection<GHSectionViewModel> _sectionCProperty = new ObservableCollection<GHSectionViewModel>();

        /// <summary>
        /// Sets and gets the Sections property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<GHSectionViewModel> SectionC
        {
            get
            {
                return _sectionCProperty;
            }

            set
            {
                if (_sectionCProperty == value)
                {
                    return;
                }

                _sectionCProperty = value;
                RaisePropertyChanged(SectionCPropertyName);
            }
        }

        /// <summary>
        /// The <see cref="SectionD" /> property's name.
        /// </summary>
        public const string SectionDPropertyName = "Sections";

        private ObservableCollection<GHSectionViewModel> _sectionDProperty = new ObservableCollection<GHSectionViewModel>();

        /// <summary>
        /// Sets and gets the Sections property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<GHSectionViewModel> SectionD
        {
            get
            {
                return _sectionDProperty;
            }

            set
            {
                if (_sectionDProperty == value)
                {
                    return;
                }

                _sectionDProperty = value;
                RaisePropertyChanged(SectionDPropertyName);
            }
        }
    }
}