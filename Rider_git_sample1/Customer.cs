namespace Rider_git_sample1;

public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; }


    public void SendInfoEvent()
    {
        Console.WriteLine($"Customer {this.Id}");
    }
}