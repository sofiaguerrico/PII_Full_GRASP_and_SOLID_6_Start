# PII Full GRASP and SOLID
## FIT
### Universidad Católica del Uruguay

En este programa trabajaremos con recetas de cocina que involucran ingredientes y equipamiento.

## Desafío(s)
️➡️ **En la clase Recipe:**
* Agregar un método ```int GetCookTime()``` que retorna la suma del tiempo de todos los pasos
* Agregar una propiedad bool Cooked de sólo lectura; es ```false``` al inicio y pasa a ```true``` cuando se invoca ```void Cook()``` y pasa el tiempo indicado por ```GetCookTime()```
* Agregar un método ```void Cook()```. Usando la clase ```CountdownTimer``` provista, debe pasar la propiedad Cooked a true cuando pase el tiempo indicado por ```GetCookTime()```
* A efectos de este ejemplo, una receta se puede cocinar invocando el método ```void Cook()``` sólo una vez.

️➡️ **La clase CountdownTimer y la interfaz TimerClient no se pueden modificar ni se puede modificar el tipo de Recipe luego de los cambios anteriores**

Para "ver" como se cocina la receta, agreguen el siguiente código al final del método ```void Main(string[])``` de la clase Program:

```Csharp
Console.WriteLine($"Cooked: {recipe.Cooked}");
recipe.Cook();
Thread.Sleep(500); // 0.5 segundos
Console.WriteLine($"Cooked: {recipe.Cooked}");
```
La clase ```Thread``` está definida en el espacio de nombres ```System.Threading```.


️➡️ **Que patrón(es) o principio(s) has usado para esto?**

En el caso del método ```GetCookTime()``` fue aplicado el patrón Expert ya que este dice que se asigna las responsabildades a la clase que es experta en esa informacion, por ende en Recipe se encunetra la lista que contiene los steps correspondientes.

Por otro lado, para la parte dos y tres se puede ver reflejado el principio ISP, el cual dice que los clientes no deben ser forzados a conocer tipos que no usan. Para resolver este problema no se podía cambiar el tipo de la clase Recipe, por lo que se creó una nueva clase llamada TimerCounterClient que implementa la interfaz TimerClient para que se pueda utilizar el método ```TimeOut()``` en Recipe. Allí se relacionan la clase con la interfaz, entonces, faltaría que Recipe y esta nueva clase se conozcan, por lo que también se implementará una instancia de tipo Recipe en el constructor de la clase. 


