using System;
public record Product(int Id, string Name, double Price);

public interface IDBService
{
    bool saveItemToShoppingCart(Product product);
    bool removeItemToShoppingCart(int? productId);

}

public class ShoppingCart
{
    private readonly IDBService _dbService;
    public ShoppingCart(IDBService dBService)
    {
        this._dbService = dBService;
    }

    public bool AddProduct(Product? product)
    {
        if(product == null) return false;
        if(product.Id == 0) return false;

        _dbService.saveItemToShoppingCart(product); 
        return true;

    }

    public bool DeleteProduct(int? id){
        if(id==null) return false;
        if(id==0) return false;
        _dbService.removeItemToShoppingCart(id);
        return true;
    }
}