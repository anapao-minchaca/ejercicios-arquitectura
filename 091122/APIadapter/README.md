# Diseño y arquitectura de software - TC3049
## Ana Paola Minchaca García - A01026744
### API Adapter

Este API Adapter consiste en la primera entrega de las actividades finales para la materia de TC3049. Consiste en un API que recibe desde un método GET información acerca del pronóstico del tiempo en formato JSON y la convierte a formato XML. Así que accediendo a los endpoints, se podrán ver los datos desplegados en pantalla.
Se tienen dos controladores, el *WeatherForecastController* que es quien nos da la información acerca del pronóstico del tiempo y el *AdapterController*, donde esperamos la respuesta del *WeatherForecastController* de manera asíncrona para convertirla a formato XML. De igual forma se tiene un método POST dentro de *WeatherForecastController*, que básicamente sirvió para probar que se estuviera convirtiendo en formato XML de manera correcta pero que no es necesario para el API. 

Como una pequeña nota, es importante aclarar que se tuvo que hacer un método extra, ya que a la hora de querer cambiar los datos a XML, había un problema de que solo puede convertir JSON que comienzan con un objeto, así que se le agregó la siguiente línea para que funcionara de manera correcta. 
``` C#
XNode xml = JsonConvert.DeserializeXNode("{\"element\":" + responseBody + "}", "root");
```

- [Endpoint 1](https://localhost:7076/WeatherForecast)
```
[{"date":"2022-11-16T11:50:13.4713793-06:00","temperatureC":25,"temperatureF":76,"summary":"Sweltering"},{"date":"2022-11-17T11:50:13.4713894-06:00","temperatureC":25,"temperatureF":76,"summary":"Balmy"},{"date":"2022-11-18T11:50:13.4713897-06:00","temperatureC":44,"temperatureF":111,"summary":"Chilly"},{"date":"2022-11-19T11:50:13.4713899-06:00","temperatureC":-16,"temperatureF":4,"summary":"Hot"},{"date":"2022-11-20T11:50:13.4713902-06:00","temperatureC":-15,"temperatureF":6,"summary":"Bracing"}]
```
- [Endpoint 2](https://localhost:7076/Adapter)
```
<root>
  <element>
    <date>2022-11-16T11:50:02.2061605-06:00</date>
    <temperatureC>24</temperatureC>
    <temperatureF>75</temperatureF>
    <summary>Freezing</summary>
  </element>
  <element>
    <date>2022-11-17T11:50:02.2061745-06:00</date>
    <temperatureC>-7</temperatureC>
    <temperatureF>20</temperatureF>
    <summary>Bracing</summary>
  </element>
  <element>
    <date>2022-11-18T11:50:02.206175-06:00</date>
    <temperatureC>-16</temperatureC>
    <temperatureF>4</temperatureF>
    <summary>Hot</summary>
  </element>
  <element>
    <date>2022-11-19T11:50:02.2061754-06:00</date>
    <temperatureC>33</temperatureC>
    <temperatureF>91</temperatureF>
    <summary>Chilly</summary>
  </element>
  <element>
    <date>2022-11-20T11:50:02.2061757-06:00</date>
    <temperatureC>-5</temperatureC>
    <temperatureF>24</temperatureF>
    <summary>Hot</summary>
  </element>
</root>
```

