1. Se importan las librerías necesarias:

	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Xamarin.Forms;

2. Se define la clase MainPage que hereda de ContentPage. Esta clase representa la página principal de la aplicación.

3. En el constructor MainPage(), se llama a InitializeComponent() para inicializar los componentes de la interfaz de usuario.

4. Se declaran algunas variables miembro en la clase MainPage:

	primerNumero: Almacena el primer número en una operación.
	nombreOperador: Almacena el operador (por ejemplo, +, -, *, /) seleccionado para la operación.
	isOperadorClicked: Un indicador booleano que señala si se ha hecho clic en un operador.

5. Hay varios manejadores de eventos para los botones que se ejecutan cuando se hace clic en ellos:

BtnCommon_Clicked: Maneja los dígitos y los muestra en la pantalla. Si ya se seleccionó un operador o la pantalla muestra "0", se inicia un nuevo número.
BtnClear_Clicked: Borra la pantalla y reinicia las variables de operación.
BtnX_Clicked: Elimina el último dígito en la pantalla.
BtnCommonOperation_Clicked: Registra el operador seleccionado y almacena el número actual en primerNumero.
BtnPorcentaje_Clicked: Calcula el porcentaje del número actual y muestra el resultado.
BtnEqual_Clicked: Realiza la operación matemática con el primer número, el operador y el número actual y muestra el resultado en la pantalla.

6. La función Calcular toma dos números y un operador como entrada y realiza la operación correspondiente. Devuelve el resultado de la operación.




