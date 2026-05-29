# Clase 8 — Manejo de archivos

Archivos y directorios, tipos y formatos de archivo (texto vs binario, extensiones, magic numbers), la librería `System.IO`, el concepto de stream y las clases para leer y escribir.

## Contenido

- `manejo-archivos-slides.html` — presentación (21 slides).
- `img/` — imágenes usadas en la presentación.
- `proyecto-ejemplo/` — proyecto de consola .NET con ejemplos ejecutables.

## Temas

1. Directorios y archivos; texto plano vs binario.
2. Formatos: extensión, metadatos, cabecera, magic number y EOF.
3. `System.IO`: clases principales (`File`, `FileInfo`, `Directory`, `DirectoryInfo`, `Path`).
4. Objetos `Directory` y `File` (métodos más usados).
5. Streams: concepto, fuente → destino, flujo de texto vs bytes.
6. La clase `Stream` y sus implementaciones (`FileStream`, `MemoryStream`, …).
7. `FileStream`: `FileMode`, leer bytes y convertir a texto con `Encoding`.
8. Helpers: `StreamReader/Writer` y `BinaryReader/Writer`.

## Ver la presentación

Abrí `manejo-archivos-slides.html` en el navegador.

## Correr los ejemplos

```bash
cd proyecto-ejemplo
dotnet run
```

Los ejemplos usan una carpeta temporal del sistema, así que funcionan en cualquier plataforma.
