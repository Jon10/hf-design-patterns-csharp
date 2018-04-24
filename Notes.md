HEAD FIRST DESIGN PATTERNS
==========================

### OO BASICS
* Abstraction
* Encapsulation
* Polymorphism
* Inheritance

---

### OO PRINCIPLES
* Encapsulate what varies.
* Favor composition over inheritance.
* Program to interfaces, not implementations.
* Strive for loosely coupled design between objects that interact.
* Classes should be open for extension but closed for modification.
* Depend on abstractions. Do not depende on concrete classes.
* Only talk to your friends (Law of Demeter/Principle of Least Knowledge)
* Don't call us, we'll call you.
* A class should have only one reason to change.

---

### OO PATTERNS
**_Strategy_** defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

---

**_Observer_** defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

---

**_Decorator_** attach additional responsibilities to an object dynamically. Alternative to subclassing for extending functionality.

---

**_Abstract Factory_** provide an interface for creating families of related or dependent objects without specifying their concrete classes.

**_Factory Method_** define an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to the subclasses.

---

**_Singleton_** ensure a class only has once instance and provide a global point of access to it.

---

**_Command_** encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.

---

**_Adapter_** converts the interface of a class to another interface clients expect. Lets classes work together that couldn't otherwise because of incompatible interfaces.

**_Facade_** provides a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.

---

**_Template Method_** define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method redefines certain steps of an algorithm without changing the algorithm's structure.

---

**_Iterator_** provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

**_Composite_** compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and composition of objects uniformly.

---

**_State_** allow an object to alter its behavior when its internal state changes. The object will appear to change its class.

---

**_Proxy_** provide a surrogate or placeholder for another object to control access to it.

---

**_Compound_** combines two or more patterns into a solution that solves a recurring or general problem.