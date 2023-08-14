using HelloMethods;
//or I could take off above "using" statement and make line below be:
// string message = HelloMethods.Message.GetMessage(" ");


string message = Message.GetMessage(" ");
Console.WriteLine(message);
Console.ReadLine();