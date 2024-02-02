
WebSite web = new WebSite("Youtube", "/youtube", "Watching other videos", "https://youtube.com");
web.Output();

web.Input();

web.Output();   
class WebSite
{

    private string namesite;
    private string path;
    private string description;
    private string address;


    public WebSite(string namesite, string path, string description, string address)
    {
        this.namesite = namesite;
        this.path = path;
        this.description = description;
        this.address = address;
    }

    public void Input()
    {
        Console.WriteLine("Enter name site, his path, description and IP address");
        namesite = Console.ReadLine();
        path = Console.ReadLine();
        description = Console.ReadLine();
        address = Console.ReadLine();
    }

    public void Output()
    {
        Console.WriteLine($"Name website: {namesite}\nPath: {path}\nDescription: {description}\nIP address: {address}");
    }

    public string GetName() {
        return namesite;
    }
    public string GetPath() {
        return path;
    }
    public string GetDescription() {
        return description;
    }
    public string GetIpAddress() {
        return address;
    }
    public void SetN(string namesite) {
        this.namesite = namesite;
    }
    public void SetP(string path) {
        this.path = path;
    }
    public void SetDe(string description) {
        this.description = description;
    }
    public void SetIp(string address) {
        this.address = address;
    }
}