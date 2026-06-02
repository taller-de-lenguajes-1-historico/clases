# Clases — Taller de Lenguajes 1

Material de clases: presentaciones (slides en HTML) y proyectos de ejemplo ejecutables.

[Navegación online del contenido](https://tudominio.com](https://taller-de-lenguajes-1-historico.github.io/clases/index.html)

## Índice de clases

| Clase | Tema | Material |
|-------|------|----------|
| 5 | Introducción a C# y .NET (lenguaje, SDK, CLI, tipos, control de flujo, compilación) | [clase-05-introduccion-net](./clase-05-introduccion-net) |
| 6 | Clases (POO: miembros, métodos, visibilidad, clase estática) | [clase-06-clases](./clase-06-clases) |
| 7 | Colecciones en C# (arreglos, genéricos, colecciones, enum) | [clase-07-colecciones](./clase-07-colecciones) |
| 8 | Manejo de archivos (System.IO, File/Directory, streams, FileStream) | [clase-08-manejo-archivos](./clase-08-manejo-archivos) |
| 9 | Archivos JSON (serialización con System.Text.Json, servicios web con HttpClient) | [clase-09-archivos-json](./clase-09-archivos-json) |

## Framework de presentaciones

Las presentaciones usan **[slidedeck](https://github.com/Spktro/slidedeck)** (un solo `deck.css` + `deck.js`), incluido vía jsDelivr CDN. Cada slide es HTML plano dentro de `<div class="deck">`; el framework agrega tema claro/oscuro, selector de tamaño, navegador de miniaturas, copiar código y export a PDF.

## Estructura

Cada clase es una carpeta autocontenida:

```
clase-XX-tema/
├── *.html          → presentación (se abre en el navegador)
├── img/            → imágenes de la presentación
└── proyecto-ejemplo/  → proyecto .NET ejecutable (dotnet run)
```

## Cómo ver una presentación

Abrí el archivo `.html` de la clase en cualquier navegador.
Navegación: `→` / `←` / `Espacio`, o clic en la mitad izquierda/derecha.
Para exportar a PDF: `Cmd/Ctrl + P` → guardar como PDF.

## Cómo correr un proyecto de ejemplo

Requiere el [.NET SDK](https://dotnet.microsoft.com/download).

```bash
cd clase-XX-tema/proyecto-ejemplo
dotnet run
```
