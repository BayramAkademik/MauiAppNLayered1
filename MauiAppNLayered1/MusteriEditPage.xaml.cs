namespace MauiAppNLayered1;

public partial class MusteriEditPage : ContentPage
{
	public MusteriEditPage()
	{
		InitializeComponent();
	}

    public Action<string,string ,string,string,string> AddUserMethod;

    private void OkButton_Clicked(object sender, EventArgs e)
    {
        if (AddUserMethod != null)
            AddUserMethod(txtAd.Text, txtSoy.Text, txtTel.Text, txtMai.Text, txtAdr.Text);

        Navigation.PopModalAsync();
    }

    private void CancelButton_Clicked(object sender, EventArgs e)
    {

    }
}