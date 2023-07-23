# Indicaciones generales
- Crea un repositorio en github
- Intenta agrupar funcionalidades en commits individuales, perderás puntos si creas commits grandes sin relación.

# Challenge Back-end
- Vas a utilizar la última versión estable de .NET.
- Crea migraciones,  modelos, para 2 tablas, cada una con 3 columnas (sin contar el ID, o timestamps).
- Crea 2 endpoints GET de API para cada tabla/modelo, el 1ero para toda la colección (todos los datos); eje: api/persona, el 2do para el recurso (un registro en especifico, vía su ID); eje: api/persona/1.
- Crea 1 endpoint POST para cada tabla/modelo, donde puedas crear una nueva fila. Debes agregar validaciones adecuadas, y retornar estados correctos.

## Puntos extra
- Mientras más creativo seas con tú código, mientras más robusto sea, cubras la mayoría de casos (aún no pensados), vas a tener una mejor calificación de este challenge.


### Generate migrations
dotnet ef migrations add InitialCreate -c ApplicationDbContext -s ../DigitalRoots.Api --output-dir Migrations