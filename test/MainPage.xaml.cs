namespace test

{
    using System.ComponentModel;
    

    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private int pushUps;
        private int sitUps;
        private int squats;
        private double kilometers;

        public event PropertyChangedEventHandler PropertyChanged;

        public int PushUps
        {
            get => pushUps;
            set
            {
                pushUps = value;
                OnPropertyChanged(nameof(PushUps));
                OnPropertyChanged(nameof(DisplayPushUps));
            }
        }

        public int SitUps
        {
            get => sitUps;
            set
            {
                sitUps = value;
                OnPropertyChanged(nameof(SitUps));
                OnPropertyChanged(nameof(DisplaySitups));
            }
        }

        public int Squats
        {
            get => squats;
            set
            {
                squats = value;
                OnPropertyChanged(nameof(Squats));
                OnPropertyChanged(nameof(DisplaySquats));
            }
        }

        public double Kilometers
        {
            get => kilometers;
            set
            {
                kilometers = value;
                OnPropertyChanged(nameof(Kilometers));
                OnPropertyChanged(nameof(DisplayKM));
            }
        }

        public string DisplayKM => $"[{Kilometers}/10km]";
        public string DisplayPushUps => $"[{PushUps}/100] Push-Ups";
        public string DisplaySitups => $"[{SitUps}/100] Situps";
        public string DisplaySquats => $"[{Squats}/100] Squats";

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected void AddCounter(object sender, EventArgs args)
        {
            this.PushUps += 1;
            this.SitUps += 1;
            this.Squats += 1;
            this.Kilometers += 1.0; 
        }

        protected void SubCounter(object sender, EventArgs args)
        {
            this.PushUps -= 1;
            this.SitUps -= 1;
            this.Squats -= 1;
            this.Kilometers -= 1.0; 
        }
    }

}
