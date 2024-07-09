using System;

namespace Company.ClassLibrary1;

// Violates SRP
public class User
{
    public void SaveUser(User user)
    {
        // Save user to database
    }

    public void SendEmail(User user)
    {
        // Send email to user
    }
}

// Follow SRP
public class UserRepository
{
    public void SaveUser(User user)
    {
        // Save user to database
    }
}

public class EmailService
{
    public void SendEmail(User user)
    {
        // Send email to user
    }
}
