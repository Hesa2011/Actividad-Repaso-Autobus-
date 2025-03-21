using System;
using System.Collections.Generic;

namespace CobroPasajes
{
    class Programa
    {
        static void Main(string[] args)
        {
            // Flota de autobuses
            List<Autobus> autobuses = new List<Autobus>
            {
                new Autobus("Auto Bus Platinum", 22, 1000),
                new Autobus("Auto Bus Gold", 15, 1300)
            };

            // Rutas disponibles
            List<Ruta> rutas = new List<Ruta>
            {
                new Ruta("San Pedro", "Punta Cana"),
                new Ruta("San Pedro", "Puerto Plata"),
                new Ruta("San Pedro", "Santiago")
            };

            // Horarios disponibles
            Horario horario = new Horario();

            // Vender boletos
            autobuses[0].VenderBoleto(5); // 5 pasajeros en Platinum
            autobuses[1].VenderBoleto(3); // 3 pasajeros en Gold

            // Mostrar información de autobuses
            Console.WriteLine("\nInformación de Autobuses:");
            foreach (var autobus in autobuses)
            {
                autobus.MostrarInformacion();
            }

            // Mostrar rutas
            Console.WriteLine("\nRutas Disponibles:");
            foreach (var ruta in rutas)
            {
                ruta.MostrarRuta();
            }

            // Mostrar horarios
            Console.WriteLine("\nHorarios Disponibles:");
            horario.MostrarHorarios();
        }

        private class Autobus
        {
            public string Nombre { get; set; }
            public int Capacidad { get; set; }
            public double PrecioBoleto { get; set; }
            public int BoletosVendidos { get; set; }

            public Autobus(string nombre, int capacidad, double precioBoleto)
            {
                Nombre = nombre;
                Capacidad = capacidad;
                PrecioBoleto = precioBoleto;
                BoletosVendidos = 0;
            }

            public void VenderBoleto(int cantidad)
            {
                if (BoletosVendidos + cantidad <= Capacidad)
                {
                    BoletosVendidos += cantidad;
                }
                else
                {
                    Console.WriteLine($"No hay suficientes asientos disponibles en {Nombre}.");
                }
            }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre}, Capacidad: {Capacidad}, Boletos Vendidos: {BoletosVendidos}, Precio por Boleto: {PrecioBoleto}");
            }
        }

        private class Ruta
        {
            public string Origen { get; set; }
            public string Destino { get; set; }

            public Ruta(string origen, string destino)
            {
                Origen = origen;
                Destino = destino;
            }

            public void MostrarRuta()
            {
                Console.WriteLine($"Origen: {Origen}, Destino: {Destino}");
            }
        }

        private class Horario
        {
            private List<string> horarios;

            public Horario()
            {
                horarios = new List<string>
                {
                    "08:00 AM",
                    "12:00 PM",
                    "04:00 PM",
                    "08:00 PM"
                };
            }

            public void MostrarHorarios()
            {
                foreach (var horario in horarios)
                {
                    Console.WriteLine(horario);
                }
            }
        }
    }
}


