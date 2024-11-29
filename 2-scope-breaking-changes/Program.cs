// See https://aka.ms/new-console-template for more information
using _2_scope_breaking_changes;
class Program
{
    public static void Main()
    {
        scoped myScoped = new("This 'scoped' object has been created");
        Console.WriteLine(myScoped.Message);
    }
}
