# Behavioral Design Patterns
Behavioral design patterns focus on how objects interact and communicate with each other. They define the responsibilities and relationships between objects, ensuring that complex interactions are managed efficiently while promoting loose coupling.
(Ils définissent comment les objets interagissent et communiquent entre eux pour gérer efficacement les responsabilités et les relations.)
## Strategy 
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
![image](https://github.com/user-attachments/assets/e6093fce-bd1b-48fd-a295-b11b9c53d4b0)
## Chain of Responsibility
Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
![image](https://github.com/user-attachments/assets/477903f1-4cb1-40b5-ac3b-fb97c30f3e7a)
## Command
Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
![image](https://github.com/user-attachments/assets/045244fa-a365-48ae-a898-2e8ccbc9e04b)
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
