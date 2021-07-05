# CSharp C#
## About OOP
  OOP(Object Orientation Program) POO(Programação Orientada a Objeto)
  Esse termo foi criado para fazer a conexao do mundo real com a programacao
  transformar uma problema real em código 
  Sao encapsuladas em cada objeto
	Criar classe separar cada tratacao em calsses
  
#### CLASSES
Define objeto(s) define o que os objetos são e como se comportam
Objetos ficam dentro de classes, cada classe pode ter mais que um objeto
```csharp
public class car //crate class
{
    //content class
}
```
#### OBJETO
- Estado (propriedades, valores) 
- comportamento(como ele vai reagir com outros objetos)
- Entidade(identificador do objeto)
representa instancia da classe
```csharp
public class car //crate class
{
    	var car = new Object(); //create Obj
	car.fabrication = "Ford"; //info Obj
	car.model = "Mustang";
	car.year = 1969;
	
	public String getCar() //get Object
	{
        	return car; //return value
    	}
	public void setModel(String model)
	{
		this.model = model;
	}
}
```
#### METODOS
Um método é um bloco de código que contém uma série de instruções. Um programa faz com que as instruções sejam executadas chamando o método e especificando os argumentos de método necessários
- Accessor methods: getNameAttribute (getValue)
- Modifier methods: setNameAttribute (setValue)
```csharp
static void Main() //Main is a method
{
	Console.WriteLine("My top speed is {0}", speed);
}
```
#### CONDICIONAIS
Sem loop (executara se)
- if else, swith case

Com loop (executara enquanto, usado em listas)
- while do, for each

#### ARRAY
A estrutura basica de um array
```csharp
// Tipodedado[] nomeArray = new tipodedado [tamanhoArray];
int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //Array int
int[] luckyNumbers = { "name1", "name2", "name3" }; //Array string
```
Voce pode add() remove()...
```csharp
ArrayList a1 = new ArrayList(); //create array
ArrayList.add(element) //kind of const
```
Um exemplo mais estruturado, parecido com um dicionario
```csharp
string[] names = new string[4];
names[0] = "Abner";
names[1] = "Jhon";
names[2] = "Frank";
names[3] = "July";

Console.WriteLine(names[2]);
//return: Frank
```

#### LIST
```csharp
string[] input = { "Brachiosaurus",
	"Amargasaurus",
	"Mamenchisaurus" };

List<string> dinosaurs = new List<string>(input); //create a list

Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

Console.WriteLine();
foreach( string dinosaur in dinosaurs )
{
Console.WriteLine(dinosaur);
}
```

#### DICTIONARY
A estrutura do dicionario
- Key = Value
```csharp
private static Dctionary<string, object> dict;

private static void Add(string strKey, object dataType)
{
	if(!dict.ContainsKey(strKey))
	{
		dict.Add(strKey, dataType);
	}
	else
	{
		dict[strKey] = dataType;
	}
	
	private staic T GetAnyValue<T>(string strKey)
	{
		object obj;
		T retType;
		
		dict.TryGetValue(strKey, out obj);
		
		try
		{
			retType = (T)obj;
		}
		catch
		{
			retType = default(T);
		}
		return retType;
		
		static void Main(string[] args)
		{
			dict = new Dictionary<string, object>();
			
			//key = value
			Add("pi", 3.14159);
			Add("delta", "b*b -4*a*c");
			Add("",)
			
			Console.WriteLine("pi" + GetAnyValue<duble>("pi"));
			Console.WriteLine("pi" + GetAnyValue<string>("delta"));
			
			Console.ReadLine();
		}
	}
}
```



#### OOP/POO
- Abstração
- Encapsulamento
- Composição
- Agregação
- herança
- Polimorfismo
- Modularidade
- Mensagens

#### ABSTRACAO
extrair informacoes e principais caracteristicas
caracteristicas em comum aos objetos
interfaces ou classes que escondam algo
ex: seu carro estava com probema vc levou no concerto e ele voltou arrumado, 
o processo que ele passou para arrumar nao e tao relevante para voce o que importa
e que ele esta funcionando
```csharp
//other form
abstract class Conta 
{

	private double saldo;

	public void setSaldo(double saldo)
	{
		this.saldo = saldo;
	}

	public double getSaldo() 
	{
		return saldo;
	}

	public abstract void imprimeExtrato();

}
```
tabem temos metodos abstratos
```csharp
public abstract void MyMethod(); //abstract method
```

#### ENCAPSULAMENTO
Um obj nao pode alterar outro(privar)
Atributos privados ou protegidos
modificadores de acesso
this
resolve problema de ambiguidade relacionada ao objeto
uso do if

Nao perder a essencia do encapsulamento
Pessoa a1 = new Pessoa ("Ana",25)
a var a1 nao guarda o objeto, mas sim faz referencia a ele do tipo pessoa
classe statica pode ser acessada somente por ela mesmo
variavel statica ex: int
```csharp
class Conta
{
    private double saldo;

    private int numero;

    // outros atributos e métodos da conta

    public double PegaSaldo() 
    {
        return this.saldo;
    }
}
```
#### COMPOSICAO
relacionamento
Composições são blocos de construção críticos de muitas estruturas de dados básicas, incluindo a união rotulada, lista ligada e árvore binária, bem como o objeto utilizado em programação orientada a objetos. ... Objetos compostos são frequentemente referidos como tendo um relacionamento "tem um".
dar um new obj na sub-classe da super classe e dar um new obj desta mesmaclasse
```csharp
class Usuarios {
    class Comum
    {
    	//...
    }
    class Adm
    {
    	//...
    }
}

//other form
class NotaFiscal: IDisposable {
    IList<ItemNotaFiscal> Itens {get;set;}
}

class ItemNotaFiscal: IDisposable { ... }
```
#### AGREGACAO
```csharp
class Time {
    IList<Pessoa> Integrantes {get;set;}
}

class Pessoa {}
```

#### HERANCA
Hierarquisazacao
Associacao 1 para 1, 1 para 2
sub-classe herda de super classe 
reutilizar ou modificar metodos de classes ja existentes
somente 1 superclasse pode ter N subClasses
exemplo de transporte
modificadores de acesso public, private, protected(visibilidade para subclasses)

usando o "super" para chamar o construtor e adicionando nas sub classes

vantagens economizar tempo
desvantagens aumenta o acoplamento da classe(uma alteração na implementação de um método numa classe base pode provocar anomalias nas suas classes derivadas),
 tira o encapsulamento, -flexivel +complexo

casse generica = class object
toString() hashcode() equals()

```csharp
//create class
class Chef
{
	public void MakeChicken()
	{
		Console.writeLine("The chef makes chiken");
	}

	public void MakeSalad()
	{
		Console.writeLine("The chef makes salad");
	}

	public void MakeSpecialDish()
	{
		Console.writeLine("The chef makes barbeque ribs");
	}
}

//create herance class, other file
class ItaliaChef : Chef //the italian chef has the same caracteristics
{
	public override void MakeSpecialDish()//override from super class
	{
		Console.writeLine("The chef makes chicken parm");
	}
	
	public void MakePasta()
	{
		Console.WriteLine("The italian chef makes pasta");
	}
}
```

#### POLIMORFISMO
relacao de individuos ex: macacos, baleias, passaro todos pertence a seres vivos
exemplificacao que ambos se reagem a diferente forma de se mover
voce nao pode puxar um dado da casse principal
```csharp
public class Vehicle
{
	private string tipo;
	public string Tipo
	{
		get{ return = tipo;}
		set{ tipo = value;}
	}
	
	public Vehicle(string tipoVehicle)
	{
		this.tipo = tipoVehicle;
	}
	
	public virtual void Move()
	{}
}

//other file
public class Airplane : Vehicle
{
	public Airplane(string tipoVehicle)
	: base(tipoVehicle)
	{}
	
	public override void Move()
	{
		Console.WriteLine("Fly");
	}
}

//other file
public class Car : Vehicle
{
	public Car(string tipoVehicle)
	: base(tipoVehicle)
	{}
	
	public override void Move()
	{
		Console.WriteLine("Run");
	}
}
```

###### INTERFACES(polimorfismo)
interfaces
- classes abstratas
- classes concretas
substitui class
Assinatura de uma classe que obriga ela a passar todos os metodos(funcoes)
metodos default
evite heranca, prefira composicao

Interface funcional
Comparable(Object o)
clone() usado no return para uma outra classe nao conseguir alterar este
Collection, List, Set = interfaces
Contains()
Remove()
Add()
Size()

#### COLLECTIONS
Como vetores mas nao necessariamente acessiveis pelo indice
Nao sao dinamicos(ficar mudando o valor, vai precisar usar clone)
utiliza o reuso
Interface Collection
- Interface List
- AddAll(int index, Collection c)
- SubList(int fromindex, int toIndex)
- List
- ArrayList > metodos nao sincronizados
- Vector > metodos assincronos(multithred)
- LinkedList > mais rapido que os dois, implementa com listas ligadas
- interator()
- it.hasnext() ve se existe um prox elemento sreturn boolean
- it.next()
- Listiterator(int index) > indice list
- Classe Colections(static methods)busca, ordenacao, comparacao
- sort(list)
- binarySearch(list,key)
- reverse(list)
- suffle(list) 'embaralha'
- min()
- ```csharp
Console.WriteLine(Math.min(1, 2));//min value
```
- max()
```csharp
Console.WriteLine(Math.Max(1, 2));//Max value
```
- frequency()
- int result=Collections.frequency(list,key)
- disjoint(list1,list2)
- bool result=Collections.disjoint(list1,list2)

Interface Set
retainAll()clac semelhance
addAll()calc mais de uma list
removeAll()uma subtraindo a outra
Interfce Map
key = value
put(object key, object value)
get(object key)
remove(object key)

operacao de volume
putAll()
keySet()
values()		
clear()
		
int size()		
boolean inEmpty()
boolean containsKey(Object key)
boolean containsValue(Object value)
TreeSet treeMap(mapas ordenados)
headSet()
tailSet()
first()primeiro elemento
last()ultimo elemento
	
HashSet HashMap

treeSet gasta O(log(n))
hashset gasta O(n) constante, tabela de espenhamento


#### Classes e metodos genericos
modos de listagem
integerArray = {1,2,3,4,5}
doubleArray = {1.1,2.2,3.3,4.4,5.5}
	
sessao de parametros de tipo
public static <T> void printArray(T[] inputArray)

metodos genericos
classe generica

#### tratamento de excecoes
	forma sequecial se der erro na primeira linha do catch
	try{
		linha de codigo que pode causar excecao		
	}
	catch(classe excecao obj excecao){
	codigo de tratamento da excecao
	}
	public void read(BufferReader in)throws class exception, class exception
	printStackTrace() sequecia de metodos ate o ponto do erro
	getMessage() retorna o problema que ocorreu
	throw = error, exception
	catch-or-declare(capture ou declare a excecao que aconteceu)
	
#### ARQUIVOS E SERIALIZACAO
	Arquivo binario(legivel para programas)
	arquivo texto(legivel por humanos)
	writeObject()
	readObject()
	Fluxo de bytes
	Inputstream OutputStream

#### execucao de codigo
Correntes x paralelo
	
useful links
- [Microsoft](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1.getrange?view=net-5.0)
- [Learn](https://onlinecursosgratuitos.com/10-apostilas-de-linguagem-c-c-e-c-para-download-em-pdf/)
