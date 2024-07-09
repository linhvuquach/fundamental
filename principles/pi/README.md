# The Persistence Ignorance principle

The Persistence Ignorance principle is another important concept in software design, particularly in the context of object-oriented programming and software architecture. This principle encourages **separating the domain model (business logic and entities) from the details of how data is persisted (stored and retrieved)** from a storage medium, such as a database.

## Persistence Ignorance benefits

1. Flexibility: The domain model remains independent of changes to the data storage mechanism. This allows you to switch databases or modify the data access layer without affecting the core domain logic.

2. Testability: Since the domain model is not tightly coupled to the database, it becomes easier to write unit tests for the business logic without involving the database.

3. Maintenance: Changes to the database schema or data access layer do not require changes to the domain model, making maintenance less complex.

4. Portability: The domain model can potentially be reused in different applications or contexts, regardless of the data storage strategy.

5. Simplicity: The domain model can focus purely on representing the business concepts without being cluttered by database-specific code.

## How can achieve Persistence Ignorance

To achieve Persistence Ignorance, developers often use design patterns such as the **Repository Pattern or the Data Mapper Pattern**. These patterns provide an abstraction layer between the domain model and the data access layer, allowing the domain model to interact with the database through well-defined interfaces.

## Example

For example, consider a simple class Product that represents a product in an e-commerce application:

```c#
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
```

With Persistence Ignorance, the Product class doesn't need to know about the details of how it's stored in the database. Instead, a separate repository class can handle the interactions with the database, translating between the domain model and the database schema.

```c#
public interface IProductRepository
{
    Product GetById(int id);
    void Save(Product product);
    void Delete(int id);
}

public class ProductRepository : IProductRepository
{
    // Implementaion of the repository methods
}
```

## In conclusion

By adhering to the Persistence Ignorance principle, you create a more modular and maintainable codebase. Changes to the database or data access layer have **minimal impact** on the core business logic, and the domain model **remains focused on** its primary responsibilities.
