
using Class_Inheritance_Practice;

//Person person = new()
//{
//    id = 1,
//    fullName = "Fatime Qayxanove",
//    age = 22,
//    position = "Student"
//};
//Person person = new Person();
//person.fullName ="Fatime Qayxanova";
//person.id =1;
//Console.WriteLine(person.id);

//Person person = new(1, "Hacixan Hacixanov", 19, "student");

//Console.WriteLine(person.id);


//Person person = new Person("azerbaycan");
Person person1 = new()
{
    id = 1,
    fullName = "Ilqar Shriyev",
    age = 26
};
Person person2 = new()
{
    id = 2,
    fullName = "Rashad Aghayev",
    age = 21
};
Person person3 = new()
{
    id = 3,
    fullName = "Nurlan Umudov",
    age = 22
};
Person person4 = new()
{
    id = 4,
    fullName = "Elmir Qafarzade",
    age = 21
};

 Person[] people = {person1, person2, person3, person4};
Person GetPersonById(int id)
{
    Person person=people.FirstOrDefault(p => p.id == id);
    return person;
}



//Person result=GetPersonById(2);
//if (result!=null)
//{
//    string response = ("name:" + " " + result.fullName + " " + "age:" + result.age + " id:" + " " + result.id);

//    Console.WriteLine(response);
//}
//else
//{
//    Console.WriteLine("data not found");
//}

Person[] GetPeopleByName(Person[] people,string name)
{
    return people.Where(m=>m.fullName==name).ToArray();
}


void ShowPeopleByName(Person[] people)
{
    foreach(Person person in people)
    {
        string response = "id:" + " " + person.id + " " + person.fullName;
    }
}


//ShowPeopleByName(GetPeopleByName(people, "Rashad Aghayev"));

//////////////////////////////////////////////////////////////
///


Animal animal = new();
animal.id = 1;  
animal.name = "Qartal";
//Console.WriteLine(animal.name);
Bird bird = new()
{
    id = 1,
    name = "qaraqush",
    age=1
};

//bird.Sound();

//Animal animal2 = new("salam");

