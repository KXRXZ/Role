namespace Role
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();


            var image1 = new Image
            {
                Source = "teacher_with_transparent.png",
                WidthRequest = 10,
                Aspect = Aspect.AspectFit
            };

            var image2 = new Image
            {
                Source = "student_with_transparent.png",
                WidthRequest = 10,
                Aspect = Aspect.AspectFit
            };


        }
    }
}