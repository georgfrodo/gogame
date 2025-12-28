namespace ShardTypes;

public static class BaseAddress
{
    public static string Address => 
        #if DEBUG
                "http://localhost:5039";
        #else
                "https://api.example.com";  // TODO: REPLACE WITH YOUR PRODUCTION URL
        #endif
}