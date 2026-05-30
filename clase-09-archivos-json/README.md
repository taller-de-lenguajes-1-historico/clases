# Clase 9 — Archivos JSON

Qué es JSON, su historia y comparación con XML, los tipos de datos que acepta, la serialización/deserialización con `System.Text.Json` y el consumo de servicios web con `HttpClient`.

## Contenido

- `archivos-json-slides.html` — presentación (20 slides).
- `img/` — imágenes usadas en la presentación.
- `proyecto-ejemplo/` — proyecto de consola .NET con ejemplos ejecutables.

## Temas

1. Qué es JSON, historia (vs XML) y usos (REST, AJAX).
2. Formato de ejemplo, tipos de datos y comparación JSON vs XML.
3. Conceptos a tener en cuenta (comillas dobles, comas, etc.).
4. Serialización y deserialización: concepto y para qué sirve.
5. JSON en .NET: `System.Text.Json` vs `Newtonsoft.Json` y componentes principales.
6. Serializar y deserializar con `JsonSerializer` (pasos + código).
7. Servicios web: qué son, HTTP (request/response) y `HttpClient`.

## Ver la presentación

Abrí `archivos-json-slides.html` en el navegador.

## Correr los ejemplos

```bash
cd proyecto-ejemplo
dotnet run
```

Serializa/deserializa un objeto y consume una API pública (el consumo está protegido con try/catch por si no hay conexión).
