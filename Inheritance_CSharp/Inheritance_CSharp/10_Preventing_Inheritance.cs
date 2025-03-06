using System;

sealed class SecuritySystem
{
    public void AuthenticateUser()
    {
        Console.WriteLine("User authenticated.");
    }
}

// class AdvancedSecurity : SecuritySystem {} // this will cause a compilation error

