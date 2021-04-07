# Object-Oriented-Design-1-ObserverPattern

## What is this pattern ?

Observer pattern provides a way to **notify** other classes when it comes to specific change or occurence of an event.

1. Subject class who is in charge of notifying others keeps the list of observers ( other classes ) and may have methods for registering and unregistering observer classes.

2. Observer classes who are ready to **listen** are notified about an event by the subject class.

When subject class has a collection of observer classes, **interface** is be used for *loose coupling*. We will see this aspect in our example code below.  

## Sample code : Employee management system 

![Image](https://github.com/RobinKim-SWEngineer/Images-for-document/blob/4f07c86dd55931dcf03376f522800e7be88b9863/ObserverPatternDiagram.png)

The employee management system in the sample code, has three departments under it. When there's a new employeement or award of an employee, they can notify all the departments through observer pattern.

- In example
  - EmployeeManagementSystem class has a list of IObservable interface, which is a list of departments. 
    `private List<IObservable> _departments;`

  - When there's a new hire or award, it notifies all the departments through calling GetNotified() on the departments list.
   `public void NotifyDepartments(string message) => _departments.ForEach(department => department.GetNotified(message);`
    
  - In the future there might be other departments as the company grows, then we can simply add another department class that implements IObservable interface without having to modify EmployeeManagementSystem class. This fits well with **Open/Closed Principle ( OCP )**.
