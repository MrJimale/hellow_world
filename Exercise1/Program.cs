// Retirement Calculator
Console.WriteLine("We Calculate the retirement Age but fisr inter you name");
String Name  = Console.ReadLine();
Console.WriteLine("Ok MR. "+ Name +" Now enter your Age");
int Age = Convert.ToInt32(Console.ReadLine());
int YearsFromrETIREMNT = 64 - Age;
bool IsRetired = false;
if (YearsFromrETIREMNT <= 0)
{
     IsRetired = true;

}

Console.WriteLine("Mr. " + Name + "You are " + YearsFromrETIREMNT + "away from the returement so you are " + IsRetired);
