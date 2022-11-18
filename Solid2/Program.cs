using System;

namespace Solid2
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    //Dependency inversion principle + single responsibility

/*Зверніть увагу на клас EmailSender. Крім того, що за допомогою методу Send, він відправляє повідомлення, 
він ще і вирішує як буде вестися лог. В даному прикладі лог ведеться через консоль.
Якщо трапиться так, що нам доведеться міняти спосіб логування, то ми будемо змушені внести правки в клас EmailSender.
Хоча, здавалося б, ці правки не стосуються відправки повідомлень. Очевидно, EmailSender виконує кілька обов'язків і, 
щоб клас ні прив'язаний тільки до одного способу вести лог, потрібно винести вибір балки з цього класу.*/
internal class Email
    {
        public string Theme { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }

internal interface ILogger<in T>
{
    void Log(T data);
}

internal interface IEmailSender
{
    void Send(Email email);
}

internal class EmailLogger : ILogger<Email>
{
    public void Log(Email email)
    {
        Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was send");
    }
}

internal class EmailSender : IEmailSender
{
    private readonly ILogger<Email> _logger;

    public EmailSender(ILogger<Email> logger)
    {
        _logger = logger;
    }

    public void Send(Email email)
        {
            // ... sending...
            _logger.Log(email);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
            var e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
            var e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
            var e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
            var e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
            var e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

            var logger = new EmailLogger();
            var es = new EmailSender(logger);
            es.Send(e1);
            es.Send(e2);
            es.Send(e3);
            es.Send(e4);
            es.Send(e5);
            es.Send(e6);

            Console.ReadKey();
        }
    }
}