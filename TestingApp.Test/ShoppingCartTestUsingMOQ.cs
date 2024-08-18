using Moq;
using Xunit;

public class ShoppingCartTestUsingMOQ
{
    public readonly Mock<IDBService> _dbServiceMock = new();
    [Fact]
    public void AddProduct_Success()
    {
        // Given
        var shopping = new ShoppingCart(_dbServiceMock.Object);

        // When 
        var pr = new Product(1,"Shoes",150);
        var ProcessResult = shopping.AddProduct(pr);

    
        // Then
        Assert.True(ProcessResult);
        _dbServiceMock.Verify(x => x.saveItemToShoppingCart(It.IsAny<Product>()),Times.Once);
    }

    [Fact]
    public void AddProduct_Failure_DueToInvalidPayload()
    {
        // Given
        var shopping = new ShoppingCart(_dbServiceMock.Object);

        // When
     
        var ProcessResult = shopping.AddProduct(null);

    
        // Then
        Assert.False(ProcessResult);

        _dbServiceMock.Verify(x => x.saveItemToShoppingCart(It.IsAny<Product>()),Times.Never);
    
    }

    [Fact]
    public void RemoveProduct()
    {
        // Given

        var shopping = new ShoppingCart(_dbServiceMock.Object);
        var pr = new Product(1,"Shoes",150);
        var ProcessResult = shopping.AddProduct(pr);
    
        // When
        var deletedRecord = shopping.DeleteProduct(pr.Id);
    
        // Then
        Assert.True(deletedRecord);
        _dbServiceMock.Verify(x => x.saveItemToShoppingCart(It.IsAny<Product>()),Times.Once);

    }
}