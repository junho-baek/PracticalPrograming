
namespace CSharpExaple
{
public class Student
  {
    public string Name {get; private set;}
    public string ID {get; private set;}

    public Student(string name, string id)
    {
      Name = name;
      ID = id;
    }

    public bool TryChangeName(string name)
    {
      if(Name != name){
        Name = name;
        return true;
      }
      return false;
    }
  }
}