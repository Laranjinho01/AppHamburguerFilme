namespace AppHamburguerFilme;

public partial class AppFlyoutPage : FlyoutPage
{
	public AppFlyoutPage()
	{
		InitializeComponent();
        Detail = new NavigationPage(new MainPage());
    }

    private void mementoClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Memento());
        IsPresented = false;
    }

    private void alienClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Alien());
        IsPresented = false;
    }

    private void duroClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Duro());
        IsPresented = false;
    }

    private void poetasClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Sociedade());
        IsPresented = false;
    }

    private void menuClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new MainPage());
        IsPresented = false;
    }
}