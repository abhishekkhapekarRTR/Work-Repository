// See https://aka.ms/new-console-template for more information

using JsonWorkaround;

int options = 0;

Console.WriteLine("------------------ Welcome to Json Workaround ------------------");
Console.WriteLine("Press 1 for Creating Json file");
Console.WriteLine("Press 2 for Accessing Json file");
options = Convert.ToInt32(Console.ReadLine());

switch(options)
{
    case 0:
        CreatJsonFile.WriteJsonAsync();
        break;
    case 1:
        AccessJsonFile.ReadJsonAsync();
        break;
    default: Console.WriteLine("Please select correct option!");
        break;
}

Console.ReadLine();