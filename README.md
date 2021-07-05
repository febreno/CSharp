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
estado (propriedades, valores), comportamento(como ele vai reagir com outros objetos), entidade(identificador do objeto)
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
//Accessor methods: getNameAttribute
//Modifier methods: setNameAttribute
```csharp
static void Main() //Main is a method
{
	Console.WriteLine("My top speed is {0}", speed);
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
public class BaseClass
{
	int exempleNum = 18;
}

//Other file
public class ContaPoupanca : BaseClass
{
	//...
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
dar um new obj na sub-classe da super classe e dar um new obj desta mesmaclasse
```csharp
class NotaFiscal: IDisposable {
    IList<ItemNotaFiscal> Itens {get;set;}
}

class ItemNotaFiscal: IDisposable { ... }
```
#### AGRAGACAO
```csharp
class Time {
    IList<Pessoa> Integrantes {get;set;}
}

class Pessoa {}
```
03
Mini projeto exemplo
	Calcular o saldo de uma conta(saldo nunca pode ter um valor neg)
	criar variavei que no final retornan a funcao na propria classe
	Registro de contas
	Conta
	Data
	Conta corrente

04
HERANCA
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

#### POLIMORFISMO
relacao de individuos ex: macacos, baleias, passaro todos pertence a seres vivos
exemplificacao que ambos se reagem a diferente forma de se mover
voce nao pode puxar um dado da casse principal

#### INTERFACES(polimorfismo)
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
Interface List
AddAll(int index, Collection c)
SubList(int fromindex, int toIndex)
List
ArrayList
metodos nao sincronizados
Vector
metodos assincronos(multithred)
LinkedList
mais rapido que os dois, implementa com listas ligadas

#### COLLECTIONS

interator()
it.hasnext() ve se existe um prox elemento sreturn boolean
it.next()
Listiterator(int index) > indice list
	Classe Colections(static methods)busca, ordenacao, comparacao
	sort(list)
	binarySearch(list,key)
	reverse(list)
	suffle(list) 'embaralha'
	min()
	max()
	frequency()
		int result=Collections.frequency(list,key)
	disjoint(list1,list2)
		bool result=Collections.disjoint(list1,list2)
	interfaces
	classes abstratas
	classes concretas

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
14
execucao de codigo:
Correntes x paralelo
#### EXEMPO CLASS/OBJ

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
