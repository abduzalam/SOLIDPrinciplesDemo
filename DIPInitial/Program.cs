// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dependency Inversion Principle ( DIP )");
Console.WriteLine();

// The basic idea of behind DIP is that, we should create higher level modules with complex logic in such a way
// to be reusable and unaffected by any change from a lower level modules in our application

// This means higher level modules should not depend on lower level modules, both should depends on abstractions
// Abstractions should not depend on details, details should depend on abstractions

// Abstraction, example think of ATM machine, though the machine perform multiple things like check balance, deposit, withdrwal etc, the user does not know how these
// things are actually happening behind the scene, only the front end is visible to the user ( remaing are hidden from the user)


// The high-level modules describe those operations in our application that have more abstract nature and contain more complex logic.
// These modules orchestrate low-level modules in our application.

// The low-level modules contain more specific individual components focusing on details and smaller parts of the application.
// These modules are used inside the high-level modules in our app.

// See the example here