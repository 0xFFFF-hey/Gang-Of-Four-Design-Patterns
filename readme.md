# Table of Contents
- [SOLID Principles](#solid-principles)
- [UML Relations](#uml-relations)
- [Behavioral Design Patterns](#behavioral-design-patterns)
  - [Strategy](#strategy)
  - [Chain of Responsibility](#chain-of-responsibility)
  - [Command](#command)
  - [Iterator](#iterator)
  - [Mediator](#mediator)
  - [Memento](#memento)
  - [Observer](#observer)
  - [State](#state)
  - [Template](#template)
  - [Visitor](#visitor)
- [Structural Design Patterns](#structural-design-patterns)
  - [Adapter](#adapter)
  - [Proxy](#proxy)
  - [Bridge](#bridge)
  - [Composite](#composite)
  - [Decorator](#decorator)

# SOLID Principles
SOLID is an acronym for five design principles that promote cleaner, more maintainable code. These principles are widely used in object-oriented programming (OOP).
## S: Single Responsibility Principle (SRP)
  - A class should have only one reason to change, meaning it should only have one job or responsibility.
  - Example: A class that handles both database operations and business logic should be split into two classes, one for each responsibility.
## O: pen/Closed Principle (OCP)
  - Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. This means you can add new functionality to a class without changing its existing code.
  - Example: You can add new types of payment methods to a payment system without modifying the existing payment processing class, by extending it
## L: Liskov Substitution Principle (LSP)
  - Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.
  - Example: If you have a Shape class and a Rectangle subclass, replacing an object of type Shape with a Rectangle should not cause any unexpected behavior or errors.
## I: Interface Segregation Principle (ISP)
  - Clients should not be forced to implement interfaces they do not use. In other words, it’s better to have several small, specific interfaces than a large, general one.
  - Example: If a Printer interface has methods for both print() and fax(), but not all printers support faxing, you should split the interface into two: Printable and Faxable.
## D: Dependency Inversion Principle (DIP)
  - High-level modules should not depend on low-level modules. Both should depend on abstractions (e.g., interfaces or abstract classes). Additionally, abstractions should not depend on details; details should depend on abstractions.
  - Example: Instead of directly instantiating objects inside a class (e.g., new DatabaseConnection()), use dependency injection to pass an abstraction (e.g., an interface for DatabaseConnection) to the class.
# DRY (Don't Repeat Yourself)
  - Concept: Avoid duplicating code. If you notice the same logic is used in multiple places, refactor it into a single reusable module or function.
  - Example: Instead of writing the same validation code for email in multiple classes, create a separate utility function that handles email validation.
# KISS (Keep It Simple, Stupid)
  - Concept: Keep your software design as simple as possible. Avoid overcomplicating solutions when a simpler one would suffice.
  - Example: If you can solve a problem with a basic loop and conditional statement, don’t over-engineer it with unnecessary complexity like recursion or multiple design patterns.
# YAGNI (You Aren't Gonna Need It)
  - Concept: Don’t add functionality unless it’s absolutely necessary. Avoid building features that might be useful in the future but are not required at the moment.
  - Example: Don’t implement an admin panel if you don’t currently need it, just because you think you might in the future.
# Composition Over Inheritance
  - Concept: Favor object composition over inheritance. Inheritance can create tight coupling between classes, while composition allows for greater flexibility by allowing objects to delegate tasks to other objects.
  - Example: Instead of creating a Car class that inherits from a Vehicle class, compose a Car class with a Engine and Wheels objects.

# UML Relations

## 1. Dependency
- **Definition**: A relationship where one class depends on another for its operation or behavior.
- **Example**: A `Printer` class depends on the `Paper` class.

## 2. Association
- **Definition**: A structural relationship that represents how objects are connected to each other.
- **Example**: A `Teacher` teaches `Students`.

## 3. Aggregation
- **Definition**: A "whole-part" relationship where the part can exist independently of the whole.
- **Example**: A `Classroom` has `Students`, but `Students` can exist without the `Classroom`.

## 4. Composition
- **Definition**: A stronger form of aggregation where the parts cannot exist without the whole. If the whole is destroyed, the parts are destroyed too.
- **Example**: A `House` contains `Rooms`, and if the house is demolished, the rooms no longer exist.

## 5. Generalization
- **Definition**: A relationship where one class (subclass) inherits from another class (superclass).
- **Example**: A `Car` is a type of `Vehicle`.

## 6. Realization
- **Definition**: A relationship between an interface and a class that implements the interface.
- **Example**: A `Dog` class implements the `Animal` interface.

![image](https://github.com/user-attachments/assets/4092cf5b-58a5-46f6-b776-be92362589f6)

# Behavioral Design Patterns
Behavioral design patterns focus on how objects interact and communicate with each other. They define the responsibilities and relationships between objects, ensuring that complex interactions are managed efficiently while promoting loose coupling.
(Ils définissent comment les objets interagissent et communiquent entre eux pour gérer efficacement les responsabilités et les relations.)
## Strategy 
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
![image](https://github.com/user-attachments/assets/b3830967-d5cd-4cf2-aff5-049ada8dc63b)
Example :
![Strategy drawio](https://github.com/user-attachments/assets/74a30996-15cc-4860-8fc6-4db7e68879fa)
## Chain of Responsibility
Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
![image](https://github.com/user-attachments/assets/477903f1-4cb1-40b5-ac3b-fb97c30f3e7a)
Example :
![ChainOfRespo](https://github.com/user-attachments/assets/abb0a4b2-92d4-424b-b624-c3f6862d9f36)
## Command
Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
![image](https://github.com/user-attachments/assets/045244fa-a365-48ae-a898-2e8ccbc9e04b)
Example : 
![Command drawio](https://github.com/user-attachments/assets/4a8b842f-88c7-45ee-a7ff-7aca18bea345)
## Iterator
Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
![image](https://github.com/user-attachments/assets/7b7acfc5-d89c-41d1-8c66-afca9e79947b)
## Mediator 
Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.
![image](https://github.com/user-attachments/assets/36437204-5131-4066-9ee0-50c592263e42)
## Memento 
Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.
![image](https://github.com/user-attachments/assets/d8b0c556-f97c-4597-8e1a-c8185fcae9ec)
## Observer 
Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
![image](https://github.com/user-attachments/assets/c5bc000c-7566-48dc-88dc-844459a3836e)
## State 
Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
![image](https://github.com/user-attachments/assets/757ae378-ce31-4e41-9720-b345c836b224)
## Template
Define the skeleton of an algorithm in the superclass but let subclasses override specific steps of the algorithm without changing its structure.
![image](https://github.com/user-attachments/assets/625d0cc8-d64e-4e63-a0d6-87af4746ff76)
## Visitor 
Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates
![image](https://github.com/user-attachments/assets/89f07c71-a3c1-4cf2-b22d-1caf1c03b5e5)
# Structural Design Patterns
## Adapter
Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
![image](https://github.com/user-attachments/assets/f3c4869c-68b4-439f-8d2a-1b2c9e7e16a9)
## Proxy
Provide a surrogate or placeholder for another object to control access to it.
![image](https://github.com/user-attachments/assets/9cbe25e1-c7a5-4326-98d4-afd010920db5)
## Bridge
Decouple an abstraction from its implementation so that the two can vary independently.
![image](https://github.com/user-attachments/assets/f39648df-e6fb-4544-91b6-d69e4187f2f1)
## Composite
Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
![image](https://github.com/user-attachments/assets/841823ea-2995-4da1-9cfc-1c1b3c823973)
## Decorator
Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
![image](https://github.com/user-attachments/assets/a68387e4-c65b-4b85-a0a6-ed13432ad947)



