namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrderItem(int salesOrderId, int productId, int quantity, double unitPrice)
{
    //el constructor permite traer valores del exterior

    public Guid Id { get;  } = GenerateOrderItemId(); //vinculamos con el metodo privado que genera un valor aleatorio
    //el constructor todo lo de abajo permite traer valores del exterior
    public int SalesOrderId { get;  } = salesOrderId;
    public int ProductId { get;} = productId;
    public int Quantity { get;  } = quantity;
    public double UnitPrice { get;  } = unitPrice;

    private static Guid GenerateOrderItemId()
    { //guid permite devolver valores aleatorios
        return Guid.NewGuid(); 
    }

    public double CalculateItemPrice()
    {
        return Quantity * UnitPrice; 
    }
    
}