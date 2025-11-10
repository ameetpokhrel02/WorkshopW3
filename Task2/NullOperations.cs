public class NullOperations
{
    public string PerformNullChecks()
    {
        string username = null;
        
        string result1 = (username == null) ? "Username is not available" : username;
        
        string result2 = username ?? "Username is not available";
        
        username ??= "DefaultUser";
        
        return $"Ternary: {result1}, Coalescing: {result2}, After Assignment: {username}";
    }
}