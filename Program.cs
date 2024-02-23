namespace ProtectedMultipleObjects;

public class Club
{
    protected string _clubName;
    protected int _establishedYear;
    protected int _memberCount;

    public Club()
    {
        _clubName = string.Empty;
        _establishedYear = 0;
        _memberCount = 0;
    }

    public Club(string name, int year, int members)
    {
        _clubName = name;
        _establishedYear = year;
        _memberCount = members;
    }

    public virtual void addChange()
    {
        Console.Write("Club Name=");
        _clubName = Console.ReadLine();
        Console.Write("Establishment Year=");
        _establishedYear = int.Parse(Console.ReadLine());
        Console.Write("Membership Count=");
        _memberCount = int.Parse(Console.ReadLine());
    }

    public virtual void print()
    {
        Console.WriteLine();
        Console.WriteLine($"Club Name: {_clubName}");
        Console.WriteLine($"Establishment Year: {_establishedYear}");
        Console.WriteLine($"Members: {_memberCount}");
    }
}

public class GamingClub : Club
{
    protected string _gamingPlatform;
    protected int _gameCount;

    public GamingClub()
    {
        _clubName = string.Empty;
        _establishedYear = 0;
        _memberCount = 0;
        _gamingPlatform = string.Empty;
        _gameCount = 0;
    }

    public GamingClub(string name, int year, int members, string platform, int games)
    {
        _clubName = name;
        _establishedYear = year;
        _memberCount = members;
        _gamingPlatform = platform;
        _gameCount = games;
    }

    public override void addChange()
    {
        Console.Write("Club Name=");
        _clubName = Console.ReadLine();
        Console.Write("Establishment Year=");
        _establishedYear = int.Parse(Console.ReadLine());
        Console.Write("Membership Count=");
        _memberCount = int.Parse(Console.ReadLine());
        Console.Write("Gaming Platform=");
        _gamingPlatform = Console.ReadLine();
        Console.Write("Game Count=");
        _gameCount = int.Parse(Console.ReadLine());
    }

    public override void print()
    {
        Console.WriteLine("GamingClub Information");
        Console.WriteLine($"Club Name: {_clubName}");
        Console.WriteLine($"Establishment Year: {_establishedYear}");
        Console.WriteLine($"Members: {_memberCount}");
        Console.WriteLine($"Gaming Platform: {_gamingPlatform}");
        Console.WriteLine($"Game Count: {_gameCount}");
    }
}

class Program
{
    static void Main()
    {
        Club[] clubs = new Club[2];
        clubs[0] = new Club("Book Club", 2000, 50);
        clubs[1] = new GamingClub("Gamer's Club", 2010, 100, "PC", 30);

        foreach (var club in clubs)
        {
            club.print();
            club.addChange();
            Console.WriteLine("-------------");
        }
    }
}