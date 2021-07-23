string characterName = "Adrew";
            int characterAge = 18;
            char grade = 'a'; //char only one
            double pi = 3.1415;
            bool isMale = true;

            Console.WriteLine("Hello, my name is" + characterName.ToLower());
            Console.WriteLine($"In upper case {characterName.ToUpper()}");
            Console.WriteLine($"Select letter in name: {characterName[0]}");// ever start in 0,1,2,3,4...
            Console.WriteLine($"letter start in: {characterName.IndexOf("r")}");
            Console.WriteLine($"letter start in: {characterName.Substring(2,3)}");//start,finish print on:
            Console.WriteLine($"In upper case {characterName.Contains("Mike")}");//search this name and return true/false 
            Console.WriteLine($"I'm {characterAge} years old");
            Console.WriteLine($"First letter in my name is {grade}");
            Console.WriteLine("");
            //num
            Console.WriteLine("NUMBERS * % / - +");
            int num = 5;
            num--;// -1
            Console.WriteLine(num);
            Console.WriteLine("Module:" + 5 % 2);
            Console.WriteLine(2 * (4 + 3));
            Console.WriteLine(Math.Abs(1.2));//Absolute value
            Console.WriteLine(Math.Max(1, 2));//Math value
            Console.WriteLine(Math.Round(2.6));
            //user
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Your age:");
            string age = Console.ReadLine();
            Console.WriteLine($"Hello {name} you are {age} years old");
            //convert
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            //text
            string color, pluralNoun, celebrity;

            Console.WriteLine("write collor:");
            color = Console.ReadLine();

            Console.WriteLine($"Enter pluralnoun:");
            pluralNoun = Console.ReadLine();

            Console.WriteLine($"enter name:");
            celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I love {celebrity}");
            //Array
            int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] friends = new string[5];
            friends[0] = "mike";
            friends[1] = "Jelly";
            Console.WriteLine(luckyNumbers[0]);
            Console.ReadLine();
            //statements if else
            bool isTall = true;
            bool isFat = true;

            if (isTall && isFat)
            {
                Console.WriteLine("You are Tall and Fat");
            }
            else if(isTall && !isFat)
            {
                Console.WriteLine("You are Tall but is not Fat");
            }
            else if (!isTall && isFat)
            {
                Console.WriteLine("You are short but is Fat");
            }
            else
            {
                Console.WriteLine("You are short and Fat");
            }
            //get max
            //static void Main(string[] args)
            //{
            //    Console.WriteLine(GetMax(2,10,10));
            //    Console.ReadLine();
            //}
            //static int GetMax(int num1, int num2, int num3)
            //{
            //    int result;
            //    if (num1 >= num2 && num1 >= num3)
            //    {
            //        result = num1;
            //    }
            //    else if (num2 >= num1 && num2 >= num3)
            //    {
            //        result = num2;
            //    }
            //    else
            //    {
            //        result = num3;
            //    }
            //}
            //neter anumber
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a operator * / + -: ");
            double op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid argument");
            }
            //getday
            static void Main(string[] args)
            {
                Console.WriteLine(GetDay(0));

                Console.ReadLine();
            }
            static string GetDay(int dayNum)
            {
                string dayName;
                switch (dayNum)
                {
                    case 0:
                        dayName = "Sunday";
                        break;
                    case 1:
                        dayName = "Monday";
                        break;
                    case 2:
                        dayName = "Tuesday";
                        break;
                    case 3:
                        dayName = "Wednesday";
                        break;
                    case 4:
                        dayName = "Thursday";
                        break;
                    case 5:
                        dayName = "Friday";
                        break;
                    case 6:
                        dayName = "Saturday";
                        break;
                    default:
                        dayName = "Invalid Argument";
                        break;
                }
                return dayName;
                //study array
                //study list
                //study param
                //dictionary key, value
            }
            //Loops do while
            static void Main(string[] args)
            {
                int index = 1;
                while (index <= 5)//print 1,2,3,4,5
                {
                    Console.WriteLine(index);
                    index++;//som more 1 
                }
                Console.ReadLine();
            }
            //guessing game
            static void Main(string[] args)
            {
                string secretWord = "girafe";
                string guess = "";
                int guessCount = 0;
                int guessLimit = 3;
                bool outOfGuesses = false;

                while (guess != secretWord && !outOfGuesses)
                {
                    if (guessCount < guessLimit)
                    {
                        Console.WriteLine("Enter guess:");
                        guess = Console.ReadLine();
                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;
                    }
                }
                if (outOfGuesses)
                {
                    Console.WriteLine("You lose");
                }
                else
                {
                    Console.WriteLine("You Win");
                }

                Console.ReadLine();
            }

            //for loop
            static void Main(string[] args)
            {
                int[] luckyNumbers = { 1, 2, 3, 4, 5, 6 };

                for (i = 1; i < luckyNumbers; i++)//can pass 3 arguments
                {
                    Console.WriteLine(luckyNumbers[i]); 
                }
                Console.ReadLine();
            }

            //exponent meyhod
            static void Main(string[] args)
            {
                Console.WriteLine(GetPow(3, 2));
                Console.ReadLine();
            }
            static int GetPow(int baseNum, int powNum)
            {
                int result = 1;

                for (int i = 1; i < powNum; i++)
                {
                    result = result * baseNum;
                }

                return result;
            }
            //2d array
            static void Main(string[] args)
            {
                int[,] numberGrid = {
                    {1, 2 },
                    {3, 4 },
                    {5, 6 }
                };
                //int[,] myarray = new int[2, 3];

                Console.WriteLine(numberGrid[0, 0]);
                Console.ReadLine();
            }

            //exeption handling
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter another number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num1 / num2);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Error");
                    Console.ReadLine();
                }
            }

            //obj
            static void Main(string[] args)
            {
                //best form to crate
                Book book0 = new Book("Tecnology","Anonymous",350, 5.5);

                //other form to create
                Book book1 = new Book();//can pass things inside Book(x)
                book1.title = "Adventure";
                book1.author = "Jim well";
                book1.pages = 400;

                Console.WriteLine(book0.HasGodAvaliation());

                Console.ReadLine();
            }
            //create new class(for obj)
            class Book
            {
                //crate clas best form (is contructor)
                public Book(string aTitle, string aAuthor, int aPages)
                {
                    title = aTitle;
                    author = aAuthor;
                    pages = aPages;
                }
                public bool HasGodAvaliation()
                {
                    if (HasGodAvaliation >= 6.0)
                    {
                        return true;
                    }
                    return false;
                }

                //other for to crate
                public string title;
                public string author;
                public int pages;
            }

        //get set
        static void Main(string[] args)
        {
            Movie avenges = new Movie("The Avengers", "Marvel");
            Movie nemo = new Movie("Searching nemo", "Disney");
            //G, PG, PG-13, R, NR
            nemo.Rating = "R";

            Console.WriteLine(nemo.rating);
            Console.ReadLine();
        }
        public Movie
        {
            public string title;
            public string company;
            private string rating;

            public Movie(string ATitle, string aCompany, string aRating)
            {
                title = aTitle;
                director = aCompany;
                rating = aRating;
            }
            public string Rating
            {
                get { return rating;  }
                set { 
                    if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                    {
                        rating = value;
                    }
            }
//static class atribute
static void Main(string[] args)
{
	Song holiday = new Song("Holiday", "Geen Day", 200);
	Console.WriteLine(Song.songCount);
	Song kashmir = new Song("kashmir", "Led Zeppelin", 150);
	Console.WriteLine(kashmir.getSongCount);

	Console.ReadLine()
}

//crate class
class Song
{
	public string title;
	public string artist;
	public int duration;
	public static int songCout = 0;

	public Song(string aTitle, string aArtist, int aDuration)
	{
		title = aTitle;
		artist = aArtist;
		duration = aDuration;
		songCount++;
	}
	
	public int getSongCount()
	{
		return songCount;
	}
}

//static method & class
static void Main(string[] args)
{
	UseFulTools tools = new UseFulTools();
	UsefulTools.SayHi("Mike");
	Console.ReadLine();
}

class UseFulTools
{
	public static sayHi(string name)
	{
		Console.writeLine("Hello" + name);
	}
}

//inheritance
static void Main(string[] args)
{
	//super class
	Chef chef = new Chef();
	chef.MakeChicken();//here you can test
	
	//sub class
	ItaliaChef italiaChef = new ItaliaChef();
	italiaChef.MakeChicken();
	
	Console.ReadLine();
}
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
//create class
class ItaliaChef : Chef
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

