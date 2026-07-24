using CarpinteriaArtesanal.Models;

namespace CarpinteriaArtesanal.Data
{
    public class ListaTalleres
    {
        public List<Taller> GetTalleres()
        {
            return new List<Taller>
            {
                new Taller {
                    id = 1, nombretaller = "Introducción al Encastre Clásico", dictado = "Juan Perez",
                    duracion = "2 Sábados (8 horas totales)", materiales = "Incluye madera de pino, adhesivos y apuntes teóricos",
                    precio = "35.000", activo = true
                },
                new Taller {
                    id = 2, nombretaller = "Lustre y Acabados de Alta Resistencia", dictado = "Lucas Martinez",
                    duracion = "1 Sábado (4 horas totales)", materiales = "Incluye lacas, poliuretanos, tintes y pinceles profesionales",
                    precio = "22.000", activo = true
                },
                new Taller {
                    id = 3, nombretaller = "Construcción de Muebles Estilo Escandinavo", dictado = "Ana Rodriguez",
                    duracion = "4 Clases (16 horas totales)", materiales = "Incluye madera de paraíso seleccionada para armar una mesa de luz",
                    precio = "75.000", activo = false
                },
                new Taller {
                    id = 4, nombretaller = "Torneado de Madera Artesanal", dictado = "Pedro Gomez",
                    duracion = "3 Miércoles (9 horas totales)", materiales = "Uso de tornos del taller, gubias de corte y bloques de cedro",
                    precio = "48.000", activo = true
                },
                new Taller {
                    id = 5, nombretaller = "Tallado a Mano y Alivio de Superficies", dictado = "Sofia Lopez",
                    duracion = "2 Sábados (6 horas totales)", materiales = "Incluye tacos de madera blanda para práctica y uso de gubias",
                    precio = "28.000", activo = true
                },
                new Taller {
                    id = 6, nombretaller = "Diseño de Muebles y Maquetación 3D", dictado = "Clara Ortega",
                    duracion = "4 Clases Virtuales (8 horas totales)", materiales = "Incluye software de libre acceso y guías digitales paso a paso",
                    precio = "18.000", activo = true
                },
                new Taller {
                    id = 7, nombretaller = "Carpintería de Estilo Industrial (Hierro y Madera)", dictado = "Laura Benitez",
                    duracion = "3 Sábados (12 horas totales)", materiales = "Incluye perfiles de hierro estructural y tablones de pino",
                    precio = "62.000", activo = false
                },
                new Taller {
                    id = 8, nombretaller = "Tratamientos Rústicos y Quemado Shugi Ban", dictado = "Martin Silva",
                    duracion = "1 Sábado (5 horas totales)", materiales = "Incluye sopletes de taller, cepillos de acero y maderas de prueba",
                    precio = "25.000", activo = true
                },
                new Taller {
                    id = 9, nombretaller = "Restauración y Recuperación de Muebles Antiguos", dictado = "Maria Diaz",
                    duracion = "4 Sábados (16 horas totales)", materiales = "Removedores, lijas de grano vario, ceras naturales y masillas",
                    precio = "55.000", activo = true
                },
                new Taller {
                    id = 10, nombretaller = "Enchapados Finos y Marquetería Inicial", dictado = "Elena Paz",
                    duracion = "2 Jueves (6 horas totales)", materiales = "Hojas de chapa de maderas exóticas, pegamentos y herramientas de corte",
                    precio = "32.000", activo = true
                }
            };
        }
        }
    }
