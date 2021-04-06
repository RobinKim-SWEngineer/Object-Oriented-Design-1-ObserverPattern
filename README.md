# Object-Oriented-Design-1-ObserverPattern

## What is this pattern ?

Observer pattern provides a way to **notify** other classes when it comes to specific change or occurence of an event.

1. Subject class who is in charge of notifying others keeps the list of observers ( other classes ) and may have methods for registering and unregistering observer classes.

2. Observer classes who are ready to **listen** are notified about an event by the subject class.

When subject class has a collection of observer classes, **interface** should be used for *loose coupling*. We will see this aspect in our example code below.  

## Sample code : Employee management system 

![Image](https://github.com/RobinKim-SWEngineer/Images-for-document/blob/4f07c86dd55931dcf03376f522800e7be88b9863/ObserverPatternDiagram.png)

There`re two seperate examples, which of the each implements same behavior, one through delegate and another through interface. 

There is a Bank class, which needs three objects who are able to transfer, save and invest. The bank class actually has no knowledge about who and how they to that, it only knows those objects will have these 3 abilities.

- In example
  - Delegate : Bank class needs 3 delegate instances to be instantiated. Those 3 delegate instances should be objects of methods that have same signature as that of delegate definition. One of them is
    `public delegate double InvestmentDelegate(double money);`
  
    When instantiating the bank class, three methods are hooked as delegate instances so Bank class can implement them.
    `Bank happyBank = new Bank(HappyTransactionCorporation.TransactMoney, HappySaveCorporation.Save, HappyInvestCorporation.Invest);`
    
  - Interface : Bank class needs 3 interface instances to be instantiated. Those 3 interface instances should be objects of class or struct that have same members as that of interface. One of them is
    `public interface IInvestable 
    { 
        double Invest(double money);
    }`
  
    When instantiating the bank class, three instances are instantiated and passed so Bank class can implement them.
    `Bank happyBank = new Bank(new HappyTransactionCorporation(), new HappySaveCorporation(), new HappyInvestCorporation());`

## And where is the extensibility ?
In our example, there used to be only one transaction funcionality provider, which is HappyTransactionCorporation. And now the rival company appeared whose name is GloomyTransactionCorporation. So how do we switch to the new provider ?

Simply like the following, without changing Bank class !
- In the delegate exmaple : 
`Bank happyBank = new Bank(GloomyTransactionCorporation.Transact, HappySaveCorporation.Save, HappyInvestCorporation.Invest);`

- In the Interface example :
`Bank happyBank = new Bank(new GloomyTransactCorporation(), new HappySaveCorporation(), new HappyInvestCorporation());`

We just pass new delegate or interface instance to tha bank class, and that instance`s method or members will be called by bank class correspondingly.



