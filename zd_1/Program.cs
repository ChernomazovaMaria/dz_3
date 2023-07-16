// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число");
string a=Console.ReadLine();
bool is_palyndrome = true;
for(int i=0;i<a.Length; i++){
    if (a[i] != a[a.Length-1-i]){
        is_palyndrome = false;
    }
}
if (is_palyndrome == true) {
Console.WriteLine("Число является палиндромом");
} else
{
    Console.WriteLine("Число не является палиндромом");
};