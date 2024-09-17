### Ejercicio práctico - NetCore - 2022-Q

## Objetivo
Crear una API Rest para consumir y almacenar información de [Pokémon](https://pokeapi.co/)

---

## Indicaciones Generales

- Crear una rama con el nombre del participante: Ejemplo: Q2022-apellido1-appelido2-nombre1-nombre2.
- Subir cambios a sus ramas una vez terminado el tiempo establecido.
    - Al finalizar el tiempo el repositorio no permitirá nuevos cambios.
- Implementar Pruebas unitarias.
- Implementar Genéricos.
- Implementar Logs (Nuget BP o ILogger), Ejm: ||clase||nombre_método||acción||resultado||
- Implementar Excepciones personalizadas.
- Implementar Mapeo de entidades - Dto.
- Implementar Clean Code

<strong>Nota: </strong> Copiar la carpeta opt a la ruta D:/ o C:/

---

## Ejercicio 1: Administración de Pokémon
<p><strong>Con el objetivo</strong> de poder obtener información de Pokémon del API remota y almacenarla<br>
<strong>Como</strong> consumiendo el API remota de Pokémon<br>
<strong>Quiero</strong> obtener una lista de Pokémon y almacenar 5 o más Pokémon </p>

#### <strong>Criterios de aceptación</strong>

#### Escenario: Listar Pokémon del API remota - [Pokémon API](https://pokeapi.co/api/v2/pokemon?limit=100)
<p><strong>Dado</strong> que se necesita la lista de Pokémon<br>
<strong>Cuando</strong> se consuma el API remota de Pokémon enviándo el límite de resultados<br>
<strong>Entonces</strong> se debe mapear el resultado<br>
<strong>Y</strong> se debe devolver la lista de Pokémon</p>

#### Escenario: Obtener y almacenar Pokémon - https://pokeapi.co/api/v2/pokemon/{id-nombre}
<p><strong>Dado</strong> que se necesita la información del Pokémon seleccionado<br>
<strong>Cuando</strong> se envié el {id} o {nombre} del Pokémon seleccionado<br>
<strong>Entonces</strong> se debe obtener la información<br>
<strong>Y</strong> se debe almacenar los siguientes campos: name, heigth, weight, base_experience, abilities[0].ability.name (opcional)</p>

#### Tareas

- Crear un endpoint para listar Pokémon del API remota.
- Crear un endpoint para almacenar Pokémon.

#### Expectativas técnicas del ejercicio

- Buenas prácticas.
- Clean Code.
- Logs
- Excepciones
- Mapeado de entidad a un DTO (Data Transfer Object).
- Micro commits. 

---

### Ejercicio 2: Servicio para obtener mis Pokémon almacenados
<p><strong>Con el objetivo</strong> de poder obtener la información de mis Pokémon<br>
<strong>Como</strong> consumiendo un servicio<br>
<strong>Quiero</strong> obtener una lista de Pokémon almacenados </p>

#### <strong>Criterios de aceptación</strong>

#### Escenario: Listar mis Pokémon
<p><strong>Dado</strong> que necesito obtener mis Pokémon<br>
<strong>Cuando</strong> se consuma el servicio<br>
<strong>Entonces</strong> se debe devolver la lista de Pokémon<br>

#### Tareas

- Crear un endpoint para listar mis Pokémon.
- Crear un atributo adicional donde se mostrará el nombre del Pokémon Encriptado

#### Expectativas técnicas del ejercicio

- Buenas prácticas.
- Clean Code.
- Logs
- Excepciones
- Mapeado de entidad a un DTO (Data Transfer Object).
- Micro commits. 

#### Estructura de respuesta

```
{
	"Pokemones": [
		{
			"Id": 1,
			"Nombre": "bulbasaur",
			"Peso": 69,			
			"Altura": 7,
			"ExperienciaBase" : 64,
            "PrimeraHabilidad": "overgrow"

		},
		{
			"Id": 2,
			"Nombre": "charizard",
			"Peso": 905,			
			"Altura": 17,
			"ExperienciaBase" : 267,
            "PrimeraHabilidad": "blaze"
		}
	]
}
````

---