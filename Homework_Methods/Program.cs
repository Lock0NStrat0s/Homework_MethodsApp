
// Create a Welcome method, a method to ask for user's name
// and another to tell that user "Hello <name>".
// Call these methods from program.cs

using Homework_Methods;

Welcome.WelcomeUser();
string firstName = Welcome.GetFirstName();
Welcome.GreetUser(firstName);