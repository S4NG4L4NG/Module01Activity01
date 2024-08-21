using System.Xml.Serialization;

namespace Module01Activity01
{
    public partial class MainPage : ContentPage
    {

        public string firstname { get; set; }
        public Color ColorRed { get; set; }
        public MainPage()
        {
            InitializeComponent();

            firstname = "hello Maui";
            ColorRed = Colors.Red;

            this.BindingContext = this;
            
        }

        private void OnChangedLabelName(object sender, EventArgs e)
        {
            this.Resources["StaticUsername"] = "Petter Butter";
        }


        private void OnChangeNameDynamic(object sender, EventArgs e)
        {
            this.Resources["DynamicUsername"] = "Juan Dela Cruz";
        }

        private void OnChangeBackgroundColor(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightBlue;
        }

        private void OnChangeBackgroundColor1(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightPink;
        }

        private void OnChangeBackgroundColor2(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.White;
        }

        private void OnChangeBoxViewColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBoxColor"] = Colors.Cyan;
        }

    }

}
