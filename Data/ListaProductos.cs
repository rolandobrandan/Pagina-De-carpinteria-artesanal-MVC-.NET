using CarpinteriaArtesanal.Models;

namespace CarpinteriaArtesanal.Data
{
    public class ListaProductos
    {
        public List<Producto> GetProductos()
        {
            return new List<Producto>
            {
                new Producto {
                    id = 1, nombre = "Mesa de Luz Nórdica", elaborado = "Paraíso Macizo", categoria = "Dormitorio",
                    descripcion = "Lustrado al poliuretano semi-mate, cajón con guías telescópicas y patas de madera real.",
                    alto = "65 cm", largo = "45 cm", profundidad = "35 cm", precio = "85.000", destacado = true, activo = true
                },
                new Producto {
                    id = 2, nombre = "Mesa Ratona Industrial", elaborado = "Hierro y Pino", categoria = "Living",
                    descripcion = "Estructura de hierro estructural negro mate con tapa de pino macizo de 2 pulgadas.",
                    alto = "40 cm", largo = "100 cm", profundidad = "60 cm", precio = "120.000", destacado = false, activo = true
                },
                new Producto {
                    id = 3, nombre = "Placard Premium Corredizo", elaborado = "MDF Enchapado", categoria = "Dormitorio",
                    descripcion = "Puertas corredizas con sistema de aluminio, perchero metálico y zapatero interno.",
                    alto = "210 cm", largo = "180 cm", profundidad = "60 cm", precio = "450.000", destacado = false, activo = false
                },
                new Producto {
                    id = 4, nombre = "Rack para TV Escandinavo", elaborado = "Paraíso y MDF", categoria = "Living",
                    descripcion = "Mueble bajo con dos puertas volcables y espacio pasacables centralizado.",
                    alto = "55 cm", largo = "150 cm", profundidad = "40 cm", precio = "175.000", destacado = true, activo = true
                },
                new Producto {
                    id = 5, nombre = "Barra de Cocina Desayunadora", elaborado = "Eucalipto Alistonado", categoria = "Cocina",
                    descripcion = "Tapa pulida con laca impermeabilizante de alta resistencia, ideal para banquetas altas.",
                    alto = "100 cm", largo = "140 cm", profundidad = "50 cm", precio = "140.000", destacado = false, activo = true
                },
                new Producto {
                    id = 6, nombre = "Bajo Mesada Modular", elaborado = "Melamina sobre MDF", categoria = "Cocina",
                    descripcion = "Módulo de tres puertas y cajonera con correderas metálicas suaves. No incluye bacha.",
                    alto = "85 cm", largo = "120 cm", profundidad = "57 cm", precio = "210.000", destacado = false, activo = true
                },
                new Producto {
                    id = 7, nombre = "Mesa de Comedor Extensible", elaborado = "Madera de Cedro", categoria = "Comedor",
                    descripcion = "Mesa familiar con sistema de apertura central que extiende su capacidad para 8 personas.",
                    alto = "78 cm", largo = "160 cm", profundidad = "90 cm", precio = "380.000", destacado = true, activo = false
                },
                new Producto {
                    id = 8, nombre = "Biblioteca Estilo Escalera", elaborado = "Pino Seleccionado", categoria = "Estudio",
                    descripcion = "Estantería moderna tipo repisa con 5 niveles de profundidad escalonada.",
                    alto = "180 cm", largo = "60 cm", profundidad = "35 cm", precio = "65.000", destacado = false, activo = true
                },
                new Producto {
                    id = 9, nombre = "Escritorio Gamer Pro", elaborado = "Hierro y MDF", categoria = "Estudio",
                    descripcion = "Superficie reforzada con bordes biselados, soporte flotante para cables y patas regulables.",
                    alto = "75 cm", largo = "130 cm", profundidad = "70 cm", precio = "115.000", destacado = true, activo = true
                },
                new Producto {
                    id = 10, nombre = "Silla de Comedor Tapizada", elaborado = "Madera de Guatambú", categoria = "Comedor",
                    descripcion = "Estructura interna encolada, asiento acolchado con espuma de alta densidad y pana antimanchas.",
                    alto = "95 cm", largo = "48 cm", profundidad = "45 cm", precio = "52.000", destacado = false, activo = true
                },
                new Producto {
                    id = 11, nombre = "Cama Turca con Cajones", elaborado = "MDF Laqueado", categoria = "Dormitorio",
                    descripcion = "Base de cama reforzada para colchón de dos plazas, incluye 4 cajones inferiores integrados.",
                    alto = "35 cm", largo = "195 cm", profundidad = "145 cm", precio = "290.000", destacado = false, activo = false
                },
                new Producto {
                    id = 12, nombre = "Aparador Vajillero Retro", elaborado = "Paraíso Lustrado", categoria = "Comedor",
                    descripcion = "Diseño vintage con patas cónicas, tres cajones centrales y dos puertas laterales.",
                    alto = "80 cm", largo = "160 cm", profundidad = "42 cm", precio = "245.000", destacado = true, activo = true
                },
                new Producto {
                    id = 13, nombre = "Estante Flotante Minimalista", elaborado = "Pino Macizo", categoria = "Accesorios",
                    descripcion = "Repisa individual con sistema de fijación invisible incorporado en la madera.",
                    alto = "4 cm", largo = "80 cm", profundidad = "20 cm", precio = "18.500", destacado = false, activo = true
                },
                new Producto {
                    id = 14, nombre = "Perchero de Pie Nórdico", elaborado = "Madera de Álamo", categoria = "Accesorios",
                    descripcion = "Estructura trípode con 6 ganchos torneados a diferentes alturas para abrigos y carteras.",
                    alto = "175 cm", largo = "40 cm", profundidad = "40 cm", precio = "34.000", destacado = false, activo = true
                },
                new Producto {
                    id = 15, nombre = "Espejo de Cuerpo Entero", elaborado = "Madera de Kiri", categoria = "Dormitorio",
                    descripcion = "Marco de madera natural de veta expuesta, incluye soporte trasero para mantenerse de pie.",
                    alto = "160 cm", largo = "50 cm", profundidad = "3 cm", precio = "78.000", destacado = false, activo = true
                },
                new Producto {
                    id = 16, nombre = "Botinero Organizador Bajo", elaborado = "Melamina Blanca", categoria = "Dormitorio",
                    descripcion = "Mueble zapatero compacto con dos puertas volcables y capacidad para 12 pares.",
                    alto = "90 cm", largo = "65 cm", profundidad = "25 cm", precio = "89.000", destacado = false, activo = true
                },
                new Producto {
                    id = 17, nombre = "Vanitory Flotante de Baño", elaborado = "MDF Hidrófugo", categoria = "Baño",
                    descripcion = "Mueble colgante protegido con laca marina antihumedad, incluye bacha de loza blanca.",
                    alto = "50 cm", largo = "60 cm", profundidad = "45 cm", precio = "135.000", destacado = true, activo = true
                },
                new Producto {
                    id = 18, nombre = "Mueble Alacena Aéreo", elaborado = "Melamina sobre MDF", categoria = "Cocina",
                    descripcion = "Módulo superior de cocina con dos puertas vidriadas y pistones neumáticos de apertura.",
                    alto = "60 cm", largo = "80 cm", profundidad = "32 cm", precio = "98.000", destacado = false, activo = false
                },
                new Producto {
                    id = 19, nombre = "Bodega de Pared Colgante", elaborado = "Hierro y Pino", categoria = "Living",
                    descripcion = "Estante organizador rústico con espacio para 6 botellas y soporte inferior para colgar copas.",
                    alto = "45 cm", largo = "70 cm", profundidad = "15 cm", precio = "46.000", destacado = false, activo = true
                },
                new Producto {
                    id = 20, nombre = "Banco de Entrada Recibidor", elaborado = "Paraíso y Hierro", categoria = "Accesorios",
                    descripcion = "Banco compacto ideal para el hall de entrada, con estante inferior de rejilla para calzado.",
                    alto = "45 cm", largo = "90 cm", profundidad = "35 cm", precio = "68.000", destacado = true, activo = true
                }
            };
        }

    }
}
