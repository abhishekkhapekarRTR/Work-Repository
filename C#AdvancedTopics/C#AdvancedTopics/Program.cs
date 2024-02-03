// See https://aka.ms/new-console-template for more information
using C_AdvancedTopics.Delegates;
using C_AdvancedTopics.EventsAndDelegates;
using C_AdvancedTopics.LambdaExpression;
using Nullable = C_AdvancedTopics.Generics;

//-------------------- Generic Implementation ----------------
var numbers = new Nullable.Generics<int>();
numbers.Add(1);

var number = new Nullable<int>();

Console.WriteLine("Has Value ? " + number.HasValue);
Console.WriteLine("Value : " + number.GetValueOrDefault());

Nullable.GenericList<int> list = new Nullable.GenericList<int>();
for (int i = 0; i < 10; i++)
{
    list.AddHead(i);
}

foreach (int i in list)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine("-----------------------------------------------");

//-------------------- Delegate Implementation ----------------
var processor = new PhotoProcessor();
var filters = new PhotoFilter();
PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;
filterHandler += RemoveRedEyefilter;
processor.Process("Photo.jpg", filterHandler);

static void RemoveRedEyefilter(Photo photo)
{
    Console.WriteLine("RemoveRedEyefilter function is called");
}

var photoProcessor = new PhotoProcessor();
var photoFilters = new PhotoFilter();
Action<Photo> actionFilterHandler = photoFilters.ApplyBrightness;
filterHandler += photoFilters.ApplyContrast;
processor.Process("Photo.jpg", filterHandler);
Console.WriteLine("-----------------------------------------------");

//-------------------- Lambda Expression ----------------
Func<int, int> Square = number => number * number;
Console.WriteLine("Number Square : " + Square(5));

Action<int> squareRootByAction = SquareRoot.MymberSquare;
squareRootByAction(10);

var books = new BookRepository().GetBooks();
var cheapBooks = books.FindAll(x => x.Price < 200);
foreach(var book in cheapBooks)
{
    Console.WriteLine(book.Title + " " + book.Price);
}
Console.WriteLine("-----------------------------------------------");

//-------------------- Events And Delegates ----------------

var video = new Video() { Title = "Video1" };
var videoEncoder = new VideoEncoder(); //Publisher
var mailService = new MailService(); //Subscriber
var messageService = new MessageService(); //Subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
videoEncoder.Encode(video);
Console.WriteLine("-----------------------------------------------");

//-------------------- Extension Methods ----------------
string post = "This is supposed to be a very very long blog post....";
var shortendPost = post.Shorten(5);

Console.WriteLine("Shortend post : " + shortendPost);
Console.WriteLine("-----------------------------------------------");

//-------------------- LINQ ----------------

var bookRepository = new BookRepository().GetBooks();

//var cheaperBooks = new List<Book>();

//foreach (var book in bookRepository)
//{
//    if (book.Price < 50)
//    {
//        cheaperBooks.Add(book);
//    }
//}

//LINQ extention methods
//var cheaperBooks = bookRepository.Where(x => x.Price < 50).OrderBy(x => x.Title).ToList();

//LINQ query operator
var cheaperBooks = from b in bookRepository
                   where b.Price < 50
                   orderby b.Title
                   select b;

foreach (var book in cheaperBooks)
{
    Console.WriteLine(book.Title + " " + book.Price);
}

Console.WriteLine("-----------------------------------------------");

//-------------------- Dynamic ----------------
//object wordObject = "Abhishek";
//wordObject.Optimize();

dynamic excelObject = "Abhishek";
excelObject.Optimize();

