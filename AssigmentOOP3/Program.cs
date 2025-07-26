using System.Runtime.Intrinsics.X86;

namespace AssigmentOOP3
{
    internal class Program
    {
        static void Main()
        {
            #region Part 1
            #region Question 1:

            // What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance
            //b) To define a blueprint for a class
            //c) To declare abstract methods and properties
            //d) To create instances of objects
            // Answer: (b)
            #endregion

            #region Question 2:

            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            //b) protected
            //c) internal
            //d) public

            //Answer :(a)
            #endregion

            #region Question 3:


            // Can an interface contain fields in C#?
            //a) Yes
            //b) No
            //c) Only if they are static
            //d) Only if they are read only

            //Answer : (b)

            #endregion

            #region Question 4:

            //In C#, can an interface inherit from another interface?
            //a) No, interfaces cannot inherit from each other
            //b) Yes, interfaces can inherit from multiple interfaces
            //c) Yes, but only if they have the same methods
            //d) Only if the interfaces are in the same namespace
            //Answer :(a)

            #endregion

            #region Question 5:

            //Which keyword is used to implement an interface in a class in C#?
            //a) inherit
            //b) use
            //c) extends
            //d) implements
            //Answer: (d)

            #endregion

            #region Question 6:


            //Can an interface contain static methods in C#?
            //a) Yes
            //b) No
            //c) Only if the interface is sealed
            //d) Only if the methods are private
            //Answer :(a)

            #endregion

            #region Question 7:

            // In C#, can an interface have explicit access modifiers for its members?
            //a) Yes, for all members
            //b) No, all members are implicitly public
            //c) Yes, but only for abstract members
            //d) Only if the interface is sealed7
            //Answer :(b)


            #endregion

            #region Question 8:

            // What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access
            //b) To provide a clear separation between interface and class members
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution
            //Answer:(a)


            #endregion

            #region Question 9:
            //In C#, can an interface have a constructor?
            //a) Yes, but it must be private
            //b) No, interfaces cannot have constructors
            //c) Yes, but only if the interface is sealed
            //d) Only if the constructor is static
            //Answer :(b)

            #endregion

            #region Question 10:

            // How can a C# class implement multiple interfaces?
            //a) By using the "implements" keyword
            //b) By using the "extends" keyword
            //c) By separating interface names with commas
            //d) A class cannot implement multiple interfaces
            //Answer : (c)
            #endregion

            #endregion


            #region Question 1 :

            //IShape circle = new Circle(5.0);
            //IShape rectangle = new Rectangle(4.0, 6.0);

            //Console.WriteLine("Shape Information:");
            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Question 2:
            //IAuthenticationService authenticationService = new BasicAuthenticationService();


            //bool IAuthenticateUser = authenticationService.AuthenticateUser("mansour", "0502535573");
            //bool AuthorizeUser = authenticationService.AuthorizeUser("Abdelrahman", ".net");

            //Console.WriteLine($"Abdelrahman is  {(IAuthenticateUser ? "authenticateuser" : "not authenticateuser")}");
            //Console.WriteLine($"Mahmoud is     {(AuthorizeUser ? "authorizeuser" : "not authorizeuser")}"); 
            #endregion

            #region Question 3:
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();


            //string recipient = "Abdo@Yahoo.com";
            //string message = " This is a test notification.";


            //Console.WriteLine("Sending Notifications:");
            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification(recipient, message);
            //pushService.SendNotification(recipient, message); 
            #endregion

        }
    }
}
