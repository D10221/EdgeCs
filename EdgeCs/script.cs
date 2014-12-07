using System.Threading.Tasks;

public class Startup
{
    public async Task<object> Invoke(dynamic input)
    {
        return new {Data = "Hi"}; 
    }
}