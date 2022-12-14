using Realms;
using TESTMAUI.Models;

namespace TESTMAUI;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();


    }

	private void WriteDataToRealm(object sender, EventArgs e)
	{

        var realm = Realm.GetInstance();
        realm.Write(() =>
        {
            realm.Add(new TaskObj()
            {
                Partition = "4323495943053",
                Name = "Test",
            });
        });

        var allTasks = realm.All<TaskObj>();

        Console.WriteLine(allTasks);
    }
}

