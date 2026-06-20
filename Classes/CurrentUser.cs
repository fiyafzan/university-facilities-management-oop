public static class CurrentUser
{
    public static int UserId { get; set; }
    public static string Username { get; set; }
    public static string Role { get; set; }
    public static string Name { get; set; }
    public static string Email { get; set; }

    public static void Clear()
    {
        UserId = 0;
        Username = null;
        Role = null;
        Name = null;
        Email = null;
    }
}
