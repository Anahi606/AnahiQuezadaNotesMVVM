namespace AnahiQuezadaNotes.Views;

public partial class AQAllNotesPage : ContentPage
{
	public AQAllNotesPage()
	{
		InitializeComponent();

    }
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }
}