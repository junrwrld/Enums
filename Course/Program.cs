using Course.Entities;
using Course.Entities.Enums;
using System;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Declarando o tipo ENUM em tipo STRING
            string txt = OrderStatus.PendingPayment.ToString();
            //Declarando STRING para tipo ENUM
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            //IMPORTANTE RESSALTAR QUE PRECISA SER O NOME EXATO, NÃO PODE FALTAR CARACTERE
            //EXEMPLO: "Delivere"

            //RESULTADO:
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}