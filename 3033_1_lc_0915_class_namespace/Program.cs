// Fenix Strickland 113437176
// MIS 3033 class namespace

//simple: int char double bool
//complex: string

using MIS3033_classFolder;
using MIS3033_classFolder.MIS3033_subFolder;

int age;
age = 20;

Person p1;
p1 = new Person();

string ageInputStr = Console.ReadLine();
p1.age = Convert.ToInt32(ageInputStr);



Student stu;
stu = new Student();

stu.name = "Fenix Strickland";
stu.age = 22;
stu.stuID = "111111111111";

//Console.WriteLine(stu.ToString());

mis3033_fenixstrickland.Student stu2;
stu2 = new mis3033_fenixstrickland.Student();

Student stu3;
stu3 = new Student();
stu3.name = "new name";
stu3.stuID = "new id";
Console.WriteLine(stu3.ToString());


Console.ReadLine();





    public class Student:Person
    {
        public string stuID;

       public override string ToString()
    {
        string outMesStr = string.Format($"student ID: {this.stuID} name: {this.name}");
        return outMesStr;
    }

    }



