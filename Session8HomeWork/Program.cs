Console.WriteLine("***Calculator with set values***");

double number1 = 15;
double number2 = 256;
char operation = '+';

char [] operationsArray = { '+', '-', '/', '*', '%', 'p', 'b', 's', 'z'};
for (int i = 0; i < operationsArray.Length; i++)
{
    operation = operationsArray[i];
    switch (operation)
    {
        case '+':
            Console.WriteLine($"Sum equals {number1 + number2}");
            break;

        case '-':
            Console.WriteLine($"Difference equals {number1 - number2}");
            break;

        case '/':
            Console.WriteLine($"Quotient equals {number1 / number2}");
            break;

        case '*':
            Console.WriteLine($"Product equals {number1 * number2}");
            break;

        case '%':
            Console.WriteLine($"Remainder is {number2 % number1}");
            break;

        case 'p':
            Console.WriteLine($"Number one is {number1} and number two is {number2}");
            break;

        case 'b':
            if (number1 > number2)
            {
                Console.WriteLine("Number one is bigger than number two");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Number two is bigger than number one");
            }
            else
            {
                Console.WriteLine("Number one is equal to number two");
            }
            break;

        case 's':
            if (number1 < number2)
            {
                Console.WriteLine("Number one is smaller than number two");
            }
            else if (number1 > number2)
            {
                Console.WriteLine("Number two is smaller than number one");
            }
            else
            {
                Console.WriteLine("Number one is equal to number two");
            }
            break;

        default:
            Console.WriteLine("The operation is not supported");
            break;
    }

}


Console.WriteLine("***Calculator with user input values***");

Console.WriteLine("Please, enter the first number:");
double number3 = double.Parse(Console.ReadLine());

Console.WriteLine("Please, enter the second number:");
double number4 = double.Parse(Console.ReadLine());

Console.WriteLine("Please, enter the operation:");
char operation2 = (char)Console.Read();

switch (operation2)
{
    case '+':
        Console.WriteLine($"Sum equals {number3 + number4}");
        break;

    case '-':
        Console.WriteLine($"Difference equals {number3 - number4}");
        break;

    case '/':
        if (number4 == 0)
        {
            Console.WriteLine("Warning! Division by zero detected!");
        }
        else
        {
            Console.WriteLine($"Quotient equals {number3 / number4}");
        }
        break;

    case '*':
        Console.WriteLine($"Product equals {number3 * number4}");
        break;

    case '%':
        Console.WriteLine($"Remainder is {number3 % number4}");
        break;

    case 'p':
        Console.WriteLine($"Number one is {number3} and number two is {number4}");
        break;

    case 'b':
        if (number3 > number4)
        {
            Console.WriteLine("Number one is bigger than number two");
        }
        else if (number3 < number4)
        {
            Console.WriteLine("Number two is bigger than number one");
        }
        else
        {
            Console.WriteLine("Number one is equal to number two");
        }
        break;

    case 's':
        if (number3 < number4)
        {
            Console.WriteLine("Number one is smaller than number two");
        }
        else if (number3 > number4)
        {
            Console.WriteLine("Number two is smaller than number one");
        }
        else
        {
            Console.WriteLine("Number one is equal to number two");
        }
        break;

    default:
        Console.WriteLine("The operation is not supported");
        break;
}