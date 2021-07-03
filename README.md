# CSharp C#
## About OOP
  OOP(Object Orientation Program) POO(Programação Orientada a Objeto)
  Esse termo foi criado para fazer a conexao do mundo real com a programacao
  transformar uma problema real em código 
  Sao encapsuladas em cada objeto
	Criar classe separar cada tratacao em calsses
  
#### CLASSES
Define conjunto de objeto(s) define o que os objetos são e como se comportam
Objetos ficam dentro de classes
#### OBJETO
estado (propriedades, valores), comportamento(como ele vai reagir com outros objetos), entidade(identificador do objeto)
define a instancia da classe

#### OOP/POO
- Abstração
- Encapsulamento
- Composição/agregação
- herança
- Polimorfismo
- Modularidade
- Mensagens

#### EXEMPO CLASS/OBJ

```csharp

public class car
{
    	var car = new Object(); //create Obj
	car.fabrication = "Ford"; //info Obj
	car.model = "Mustang";
	car.year = 1969;
	
	public String getCar() 
	{
        	return car;
    	}
	public void setModel(String model)
	{
		this.model = model;
	}
}
```
```csharp
//method
static void Main(string[] args)
{
    SayHi("July", 19);
    SayHi("Jeffersson", 23);
    SayHi("Cleiton", 33);

    int cubeNumber = cube(5);
    Console.WriteLine(cubeNumber);

    Console.ReadLine();
}
static void SayHi(string name, int age)
{
    Console.WriteLine("Hello User" + name + "you are" + age);
}
static double cube(int num);
{
    int result = num * num * num * num);
    return result;
}
```
useful links
[Learn](https://onlinecursosgratuitos.com/10-apostilas-de-linguagem-c-c-e-c-para-download-em-pdf/)
