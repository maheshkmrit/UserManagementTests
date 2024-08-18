using Xunit;
using System.Linq;
public class UserManagementTesting
{
    [Fact]
    public void Add_CreateUser()
    {
        // Given //Arrange
        var UserManagement = new UserManagement();
        
        // When //Act
        UserManagement.Add(new("Mahesh","Kumar"));
    
        // Then //Assert
        var savedUser = Assert.Single(UserManagement.AllUsers);
        Assert.NotNull(savedUser);
        Assert.Equal("Mahesh", savedUser.firstName);
        Assert.Equal("Kumar", savedUser.lastName);
        Assert.False(savedUser.IsEmailVerified);
    }

    [Fact]
    public void Update_UpdateMobileNumber()
    {
        // Given
        var UserManagement = new UserManagement();
    
        // When
           UserManagement.Add(new("Mahesh","Kumar"));
           var dbuser = UserManagement.AllUsers.First();
           dbuser.Phone = "7250833924";
           UserManagement.Update(dbuser);

    
        // Then
         var savedUser = Assert.Single(UserManagement.AllUsers);
        Assert.NotNull(savedUser);
        Assert.Equal("7250833924", savedUser.Phone);



    }
}