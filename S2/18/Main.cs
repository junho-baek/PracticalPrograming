using System;
namespace CSharpExaple
{
  class Program18{
    
    static void Main(string[] args){
      Student student = new Student("junho baek", "2020122060");
      student.TryChangeName("junjunjun");
      
      Console.WriteLine("Student name: {0}\n Student ID: {1}", student.Name, student.ID);
    }
  }
}
