// Question 1
Book myBook = new Book();
myBook.Title = "C# Basics";
myBook.Pages = 200;

object obj = myBook;
Console.WriteLine(obj);


// Question 2
Console.WriteLine(myBook.ToString());
Console.WriteLine(myBook.Equals(myBook));
Console.WriteLine(myBook.GetHashCode());
Console.WriteLine(myBook.GetType());


// Question 3
int pages = 464;
Console.WriteLine(pages);



// Question 4
try
{
    int x = 10;
    int y = 0;
    int result = x / y;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}


// Question 5
int bookPages = 300;
double dPages = bookPages;
Console.WriteLine(dPages);


// Question 6
double price = 49.99;
int intPrice = (int)price;
Console.WriteLine(intPrice);



// Question 7
string pagesText = "464";
int convertedPages = Convert.ToInt32(pagesText);
Console.WriteLine(convertedPages);


// Question 8
string yearText = "2023";
int year = int.Parse(yearText);
Console.WriteLine(year);

string badText = "abc";
bool success = int.TryParse(badText, out int parsedResult);
if (!success)
{
    Console.WriteLine("Invalid number");
}



// Question 9
int numPages = 464;
string textPages = numPages.ToString();
Console.WriteLine(textPages.GetType());


// Question 10
int copies = 100;
object boxed = copies;
int unboxed = (int)boxed;

Console.WriteLine(boxed);
Console.WriteLine(unboxed);

class Book
{
    public string Title;
    public int Pages;
}
