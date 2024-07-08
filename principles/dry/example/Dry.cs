using System;

namespace Company.ClassLibrary1;

// Violates DRY
public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public bool IsValidFirstName()
    {
        return !string.IsNullOrWhiteSpace(FirstName) && FirstName.Length >= 2 && FirstName.Length <= 50;
    }

    public bool IsValidLastName()
    {
        return !string.IsNullOrWhiteSpace(LastName) && LastName.Length >= 2 && LastName.Length <= 50;
    }

    public bool IsValidEmail()
    {
        // Valid email logci
    }
}

// Follow DRY
public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public bool IsValidFirstName()
    {
        return IsValidName(FirstName);
    }

    public bool IsValidLastName()
    {
        return IsValidName(LastName);
    }

    public IsValidName(string name)
    {
        return !string.IsNullOrWhiteSpace(name) && name.Length >= 2 && name.Length <= 50;
    }

    public bool IsValidEmail()
    {
        // Valid email logci
    }
}

// Other case follow DRY
public class Utilities
{
    public static string FormatCurrency(decimal amount)
    {
        // Your format
    }
}

public class Invoice
{
    public decimal Total { get; set; }

    public string GetFormattedTotal()
    {
        return Utilities.FormatCurrency(Total);
    }
}

public class Product
{
    public decimal Price { get; set; }

    public string GetFormattedPrice
    {
        return Utilities.FormatCurrency(Price);
    }
}