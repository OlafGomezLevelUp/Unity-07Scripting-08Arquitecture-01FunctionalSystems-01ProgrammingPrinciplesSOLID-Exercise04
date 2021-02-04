**FECHA DE ENTREGA 20/01/2021**


**Requisitos:**
- Unity 2020.x.
- Visual Studio.

**Objetivos:**
1. Crear los siguientes sistemas e implementar el principio de abierto/cerrado:
* a.  Sistema de disparo.
2. Estructurar y comentar el código correctamente.
3. Compilar el proyecto de Unity para Windows.


**Procedimientos:**
1. Crear un sistema de disparo que dispare al presionar la tecla espacio y aplicarlo al prefab “Player”, el punto de origen del proyectil será la posición del objeto hijo “Weapon”. Generar tres tipos de armas:
* a.  Disparo de un solo proyectil hacia adelante. Utiliza como proyectil el prefab “ShotLaser”.
* b.  Disparo de tres proyectiles simultáneamente en cono. Utiliza como proyectil el prefab “ShotShell”
* c.  Disparo de un proyectiles perseguidor hacía el enemigo más cercano. Utiliza como proyectil el prefab “Missile”
2. Crear un sistema de destrucción de objetos que ejecute su lógica al colisionar. Aplicar este sistema a los prefabs “ShotLaser”, “ShotShell” y “Missile” para que se destruyan al tocar un enemigo o al tocar el collider de la parte superior de la pantalla.
3. Estructurar y comentar el código utilizando las regiones adecuadas y comentarios.
4. El proyecto se debe compilar para ser ejecutado en Windows. La compilación del proyecto se debe guardar en una carpeta llamada "build" en la raíz del proyecto de Unity.
