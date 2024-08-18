// using System;
// using Xunit;

// public class DBServiceMock : IDBService
// {
//     public bool ProcessResult { get; set; }
//     public Product ProductBeignProcessed { get; set; }
//     public int ProductIdBeignProcessed { get; set; }

//     public bool removeItemToShoppingCart(int? productId)
//     {
//         if(productId!=null)
//         ProductIdBeignProcessed = Convert.ToInt32(productId); 
//         return ProcessResult;
//     }
//     public bool saveItemToShoppingCart(Product product)
//     {
//         if(product==null) 
//             return false;

//         this.ProductBeignProcessed = product;
//         return ProcessResult;
//     }
// }
// public class ShoppingCartTest
// {
//     [Fact]
//     public void AddProduct_Success()
//     {
//         // Given
//         DBServiceMock dbMock = new DBServiceMock
//         {
//             ProcessResult = true
//         };
//         var shopping = new ShoppingCart(dbMock);

//         // When
//         var pr = new Product(1,"Shoes",150);
//         var ProcessResult = shopping.AddProduct(pr);

    
//         // Then
//         Assert.True(ProcessResult);

//         Assert.Equal(ProcessResult, dbMock.ProcessResult);
//         Assert.Equal("Shoes",dbMock.ProductBeignProcessed.Name);
//     }

//     public void AddProduct_Failure_DueToInvalidPayload()
//     {
//         // Given
//         DBServiceMock dbMock = new DBServiceMock
//         {
//             ProcessResult = false
//         };
//         var shopping = new ShoppingCart(dbMock);

//         // When
     
//         var ProcessResult = shopping.AddProduct(null);

    
//         // Then
//         Assert.False(ProcessResult);

//         Assert.Equal(ProcessResult, dbMock.ProcessResult);
    
//     }

//     [Fact]
//     public void RemoveProduct()
//     {
//         // Given
//         DBServiceMock dbMock = new DBServiceMock
//         {
//             ProcessResult = true
//         };
//         var shopping = new ShoppingCart(dbMock);
//         var pr = new Product(1,"Shoes",150);
//                 var ProcessResult = shopping.AddProduct(pr);




    
//         // When

//         var deletedRecord = shopping.DeleteProduct(pr.Id);
    
//         // Then
//         Assert.True(deletedRecord);
//         Assert.Equal(deletedRecord, ProcessResult);
//     }
// }