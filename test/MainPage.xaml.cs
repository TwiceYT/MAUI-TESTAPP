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

            //Pushup Max Increase
            if(this.PushUps < 100) 
            { 
                this.PushUps += 1;
            }
            else if(this.PushUps == 100)
            {
                this.PushUps = 100;
            }

            //Situps Max Increase
            if (this.SitUps < 100)
            {
                this.SitUps += 1;
            }
            else if (this.SitUps == 100)
            {
                this.SitUps = 100;
            }

            //Squats Max Increase
            if (this.Squats < 100)
            {
                this.Squats += 1;
            }
            else if (this.Squats == 100)
            {
                this.PushUps = 100;
            }

            //KM Max Increase
            if (this.Kilometers < 10)
            {
                this.Kilometers += 1;
            }
            else if (this.Kilometers == 10)
            {
                this.Kilometers = 10;
            }
        }

        protected void SubCounter(object sender, EventArgs args)
        {

            //Pushups Decrease
            if (this.PushUps >= 1) 
            {
                this.PushUps -=1;
            }
            else if(this.PushUps == 0) //Its not going down to negative
            {
                this.PushUps = 0;
            }

            //Situps Decrease
            if (this.SitUps >= 1)
            {
                this.SitUps -= 1;
            }
            else if (this.SitUps == 0) //Its not going down to negative
            {
                this.SitUps = 0;
            }

            //Squats Decrease
            if (this.Squats >= 1)
            {
                this.Squats -= 1;
            }
            else if (this.Squats == 0) //Its not going down to negative
            {
                this.Squats = 0;
            }

            //KM Decrease
            if (this.Kilometers >= 1)
            {
                this.Kilometers -= 1;
            }
            else if (this.Kilometers == 0) //Its not going down to negative
            {
                this.Kilometers = 0;
            }



        }

        protected void AddPushUp(object sender, EventArgs args)
        {
            this.PushUps += 1;
        }

        protected void SubPushUp(object sender, EventArgs args)
        {
            this.PushUps -= 1;
        }

        protected void AddSitUp(object sender, EventArgs args)
        {
            this.SitUps += 1;
        }

        protected void SubSitUp(object sender, EventArgs args)
        {
            this.SitUps -= 1;
        }

        protected void AddSquat(object sender, EventArgs args)
        {
            this.Squats += 1;
        }

        protected void SubSquat(object sender, EventArgs args)
        {
            this.Squats -= 1;
        }

        protected void AddKilometer(object sender, EventArgs args)
        {
            this.Kilometers += 1.0;
        }

        protected void SubKilometer(object sender, EventArgs args)
        {
            this.Kilometers -= 1.0;
        }
    }

}
