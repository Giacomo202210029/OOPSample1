namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrder(int id, int customerId)
{
    public int Id { get;  } = id;
    public int CustomerId { get;  } = customerId;

    private readonly List<SalesOrderItem> _items = []; 
    
    //el unico que alberga la logica de negocio de agregar un aggregate es un aggregate
    public void AddItem(int productId, int quantity, double unitPrice)
    {
        _items.Add(new SalesOrderItem(Id, productId, quantity, unitPrice));
    }
}