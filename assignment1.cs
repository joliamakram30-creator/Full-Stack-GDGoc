
// Q1
int pages = 464;

if (pages > 300)
{
    Console.WriteLine("Long Book");
}
else
{
    Console.WriteLine("Short Book");
}


// Q2
bool isAvailable = true;

if (pages > 300 && isAvailable)
{
    Console.WriteLine("You can borrow this book");
}


// Q3
string title = "Refactoring";

switch (title)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;

    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;

    default:
        Console.WriteLine("Never heard of it");
        break;
}



// Q4
string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
Console.WriteLine(sizeLabel);
string[] books = {
    "Clean Code",
    "The Pragmatic Programmer",
    "Refactoring"
};


// Q5
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine((i + 1) + ". " + books[i]);
}


// Q 6
int j = 0;

while (j < books.Length)
{
    Console.WriteLine(books[j]);
    j++;
}


// Q7
int count = 0;

do
{
    Console.WriteLine("Checking book...");
    count++;
}
while (count < 3);


// Q8
foreach (string book in books)
{
    Console.WriteLine(book);
}


// Q9
foreach (string book in books)
{
    if (book == "Refactoring")
    {
        break;
    }

    Console.WriteLine(book);
}


// Q10
foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
    {
        continue;
    }

    Console.WriteLine(book);
}


// Q11
void PrintFirstBook()
{
    if (books.Length == 0)
    {
        return;
    }

    Console.WriteLine(books[0]);
}

PrintFirstBook();



