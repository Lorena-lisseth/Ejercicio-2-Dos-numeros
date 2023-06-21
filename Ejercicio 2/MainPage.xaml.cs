namespace Ejercicio_2;
///<Summary>
///<Createddate>2023/06/19</createddate>
///<company>SandBox</company>
///<lastmodificationdate>2023/06/21</lastmodificationdate>
///<lastmodificationdescription>
///se agrego un mensaje de error
///</lastmodificationdescription>
//////<lastmodifierautor>Lorena Vasquez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		///<summary>
		///ponemos string.IsNullOrEmpty para verifica si los campos estan o no vacios
		///luego se hace una suma, de los dos numeros para luego hacer una multiplicación
		///de ultimo hacemos la division, luego con un resul para que se muestre el resultado
		///luego se manda un mensaje de error.
		///</summary>
		if(!String.IsNullOrEmpty(A.Text) && !String.IsNullOrEmpty(B.Text))
		{
			var ValorA = Convert.ToInt32(A.Text);
			var ValorB = Convert.ToInt32(B.Text);
			double Resultado=Math.Pow(ValorA+ValorB,2)/2;

			Resul.Text = Resultado.ToString("N2");	
		}
		else
		{
			DisplayAlert("Error", "Ha surgido un error al ingresar los datos","OK");
		}
    }
}

