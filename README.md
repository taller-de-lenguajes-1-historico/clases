# Clases — Taller de Lenguajes 1

Material de clases: presentaciones (slides en HTML) y proyectos de ejemplo ejecutables.

## Índice de clases

| Clase | Tema | Material |
|-------|------|----------|
| 6 | Clases (POO: miembros, métodos, visibilidad, clase estática) | [clase-06-clases](./clase-06-clases) |
| 7 | Colecciones en C# (arreglos, genéricos, colecciones, enum) | [clase-07-colecciones](./clase-07-colecciones) |

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
