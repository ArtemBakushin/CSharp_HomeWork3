Console.WriteLine("Введите пятизначное число: ");
var StrNumber = Console.ReadLine();
int number;
bool isNumber = int.TryParse(StrNumber, out number);

if (isNumber &&  StrNumber.Length == 5)
{
Console.WriteLine("Успешно! В вашем запросе только цифры.");
    if(StrNumber[0] == StrNumber[4] && StrNumber[1] == StrNumber[3])
    {
        Console.WriteLine($"Число {number} является палиндромом ");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    } 
}
else
{
Console.WriteLine("Ошибка!!!!!");

}



