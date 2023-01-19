initial: int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
string sign = Console.ReadLine();
switch (sign)
{
	case "+":
		Console.WriteLine(number1 + number2);
		break;
	case "-":
		Console.WriteLine(number1 - number2);
		break;
		
	case "*":
			Console.WriteLine(number1 * number2);
		        break;
		case "/":
			Console.WriteLine(number1 / number2);
		        break;





	default: 
Console.Clear();
		Console.WriteLine("wrong input");
		break;
}
goto initial;