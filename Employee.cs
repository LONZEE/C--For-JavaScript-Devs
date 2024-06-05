// Purpose: Contains the Employee class, which is used to create employee objects.
//
// The Employee class is used to create employee objects. Each employee object has a first name and a last name. The GetFullName method is used to return the full name of the employee. The Employee class is used in the Program class to create employee objects and print the full names of the employees.
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Employee
  {
    private string FirstName;
    private string LastName;
    private int Id;
    private string PhotoUrl;
    public Employee(string firstName, string lastName, int id, string photoUrl)
    {
      FirstName = firstName;
      LastName = lastName;
      Id = id;
      PhotoUrl = photoUrl;
    }
    public string GetFullName()
    {
      return FirstName + " " + LastName;
    }

    public int GetId()
    {
      return Id;
    }

    public string GetPhotoUrl()
    {
      return PhotoUrl;

    }
    public string GetCompanyName()
    {
      return "Cat Worx";
    }
  }
}