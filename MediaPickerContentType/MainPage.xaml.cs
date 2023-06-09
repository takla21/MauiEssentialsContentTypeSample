namespace MediaPickerContentType;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		var photo = await Dispatcher.DispatchAsync(async () => await MediaPicker.PickPhotoAsync());

        ContentTypeLabel.Text = photo.ContentType;
    }
}

