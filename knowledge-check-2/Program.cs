namespace knowledge_check_2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Sandwich>();
        for (int i = 0;
             i < numberOfRecords;
             i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var myClass = new Sandwich();

            Console.WriteLine("Enter the value for name?");
            myClass.name = Console.ReadLine();
            Console.WriteLine("Enter the value for health it restores?");
            myClass.health = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for tastyness?");
            myClass.tastyness = Convert.ToInt32(Console.ReadLine());

            recordList.Add(myClass);
        }

    // Print out the list of records using Console.WriteLine()
    foreach (var sandwich in recordList)
    {
        Console.WriteLine(sandwich.ToString());
    }
    }
}