namespace P6Assets20241_CamiloR.Views;
using P6Assets20241_CamiloR.ViewModels;
using P6Assets20241_CamiloR.Models;

public partial class UserSignUpPage : ContentPage
{
    //Para poder comunicarse con la base de datos debemos pasar las operaciones 
    //Por medio del view model, que se encarga de intermediar dichas operaciones.
    //

    UserViewModel? vm;
	public UserSignUpPage()
	{
		InitializeComponent();

        BindingContext = vm = new UserViewModel();

        //Y ahora llamamos la funcion que se encarga de llenar el picker 
        //Con los datos de los roles de usuario 

        LoadUserRoles();


	}

    private async void LoadUserRoles()
    {
        CboxUserRole.ItemsSource = await vm.GetAllUserRolesAsync();

    }

    private void BtnAdd_Clicked(object sender, EventArgs e)
    {

    }

    private async void  BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

    }
}