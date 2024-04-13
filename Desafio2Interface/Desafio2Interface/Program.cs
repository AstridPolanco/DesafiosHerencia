using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificable notificacionEmail = new NotificacionEmail("luarg05@gmail.com");
            INotificable notificacionWhatsApp = new NotificacionWhatsApp("5008-3486");
            INotificable notificacionSMS = new NotificacionSMS("5008-3486");

            string mensaje = "Esta es la clase de Programacion I";

            notificacionEmail.Notifica(mensaje);
            notificacionWhatsApp.Notifica(mensaje);
            notificacionSMS.Notifica(mensaje);

            Console.ReadLine();
        }
    }

    public interface INotificable
    {
        void Notifica(string mensaje);
    }

    public class NotificacionEmail : INotificable
    {
        public string DireccionCorreo { get; set; }

        public NotificacionEmail(string direccionCorreo)
        {
            DireccionCorreo = direccionCorreo;
        }

        public void Notifica(string mensaje)
        {
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine($"Se está enviando el correo a {DireccionCorreo}: {mensaje}");
            Console.WriteLine("________________________________________________________________________________________________________");
        }
    }

    public class NotificacionWhatsApp : INotificable
    {
        public string NumeroTelefono { get; set; }

        public NotificacionWhatsApp(string numeroTelefono)
        {
            NumeroTelefono = numeroTelefono;
        }
        public void Notifica(string mensaje)
        {
            Console.WriteLine($"Se está enviando este mensaje en WhatsApp al número {NumeroTelefono}: {mensaje}");
            Console.WriteLine("________________________________________________________________________________________________________");
        }
    }

    public class NotificacionSMS : INotificable
    {
        public string NumeroTelefono { get; set; }

        public NotificacionSMS(string numeroTelefono)
        {
            NumeroTelefono = numeroTelefono;
        }

        public void Notifica(string mensaje)
        {
            Console.WriteLine($"Se está enviando este SMS al número {NumeroTelefono}: {mensaje}");
            Console.WriteLine("________________________________________________________________________________________________________");
        }
    }
}
