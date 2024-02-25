//2. CustomMath adinda class yaradin, hemin clasin icinde ashagidaki methodlar olacaq. Hemin methodlari proqram classda cagirib ishledin. 
//     1)Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.
//     2)Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.
//     3) Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
//     4) Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.


using ClassTasks;
using System;
using System.Runtime.CompilerServices;
using System.Security.Claims;


CustomMath info = new CustomMath();

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
int result = info.SumOfOddInArray(arr);

//Console.WriteLine(result);
//Console.WriteLine(info.OddOrEvenNUmber(13));

int[] arr1 = { 1, 2, 3, 4, 5, 6 };
//Console.WriteLine(info.SquareSumEvenNumber(arr1));
//Console.WriteLine(info.ResultOfNumber(5));




//3. Employee adinda class yaradin, Class -in id, name, surname, address, email, age fieldleri olacaq. Proqram.cs - de ashagidaki methodlari      yazin. 
//    1)  Yashi methoda parametr kimi gelen yashdan boyuk olan 
//employee -lerin  siyahisini qaytaran method.
//    2)  Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.
//    3)  Butun Emloyeelerin yashlarinin cemini qaytaran method.
//    4)  Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method.




Employee employee = new Employee();
Employee employee1 = new Employee();
employee1.id = 1;
employee1.name = "Test1";
employee1.surname = "Testov1";
employee1.address = "Neftciler";
employee1.email = "Resadrona1@gmail.com";
employee1.age = 45;


Employee employee2 = new Employee();
employee2.id = 2;
employee2.name = "Test2";
employee2.surname = "Testov2";
employee2.address = "Neftciler";
employee2.email = "Mauro2@gmail.com";
employee2.age = 25;

Employee employee3 = new Employee();
employee3.id = 3;
employee3.name = "Test3";
employee3.surname = "Testov3";
employee3.address = "Neftciler";
employee3.email = "Aghayev3@gmail.com";
employee3.age = 15;

Employee employee4 = new Employee();
employee4.id = 4;
employee4.name = "Test4";
employee4.surname = "Testov4";
employee4.address = "Neftciler";
employee4.email = "Resad4@gmail.com";
employee4.age = 40;

Employee[] employees = {employee1, employee2, employee3, employee4};

//1)  Yashi methoda parametr kimi gelen yashdan boyuk olan
void AgeMethod(int age)
{
    foreach (Employee item in employees)
    {
        if (age < item.age)
        {
            Console.WriteLine(item.name+" "+item.surname+" "+item.address + " " +item.age + " " +item.id);
        }
       
    }
   
}

//AgeMethod(41);
//////////////////////////////////////////////////////////////////////////////////////////////////////
//2)  Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.
 int IntervalAgeMethod(int n,int m)// n<m qebul edirik ve ya kodda bunu nezere ala bilerik
{
    int count = 0;
    foreach (Employee item in employees)
    {
        if (n < item.age&&item.age<m)
        {
            count++;
            
        }
        
    }
    return count;

}

//Console.WriteLine( IntervalAgeMethod(20,30));


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///
//3)  Butun Employeelerin yashlarinin cemini qaytaran method.
int AllEmployeAgeSum()
{
int sum = 0;
    foreach (Employee item in employees)
    {
       sum+= item.age;
    }
    return sum;
}
//Console.WriteLine(AllEmployeAgeSum());


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//4)  Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method.

void SearchMethod(string str) //string
{

    foreach (Employee item in employees)
    {
        item.email.ToLower().Trim().Contains(str.ToLower().Trim());

        //item.email.ToCharArray();
        //str.ToCharArray();
        for (int i = 0; i < item.email.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == item.email[i])
                {
                  

                    Console.WriteLine(item.name + " " + item.surname + " " + item.address + " " + item.age + " " + item.id + " " + item.email);
                    break;
                }
                break;
            }
        }

    }
     

}
//SearchMethod("Resad");












































