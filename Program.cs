using StudentDatabase.Data;
using StudentDatabase.Models;

// main program - this is where everything runs

// create the database context
var context = new SchoolContext();


// create the databse if it doesnt exist yet
// EnsureCreated() will make the tables for us automatically
context.Database.EnsureCreated();

Console.WriteLine("Database created successfully!");


// create new student object
// i tried to use Add() directly on the model but that didnt work
// Student.Add(student1);  <-- this was wrong lol

var student1 = new Student
{
    FirstName = "Hasan",
    LastName = "AOLCC",
    EnrollmentDate = DateTime.Now
};


// add the student to the Students table
context.Students.Add(student1);


// save everything to the databse
context.SaveChanges();

Console.WriteLine($"Student added: {student1.FirstName} {student1.LastName}");


Console.WriteLine("All done!");
