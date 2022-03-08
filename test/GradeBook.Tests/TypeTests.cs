using System;
using Xunit;

namespace GradeBook.Tests;

public delegate string WritetLogDelegate(string logMessage);


public class TypeTests
{
    int count = 0;


    [Fact]
    public void WriteDelegateCanPointMethod(){
        WritetLogDelegate log = returnMessage;
        log += new WritetLogDelegate(returnMessage);
        log += IncrementCount;

        var result = log("Hello!");
        Assert.Equal(3, count);
    }

    string IncrementCount(string message){
        count ++;
        return message;
    }
    string returnMessage(string message){
        count ++;
        return message;
    }


    [Fact]
    public void StringValueType()
    {
        var x = GetInt();
        setInt(ref x);

        Assert.Equal(3, x);

    }

    [Fact]
    public void ValueTypealsoValueType()
    {
        var x = GetInt();
        setInt(ref x);

        Assert.Equal(3, x);

    }

    private void setInt(ref int x)
    {
        x = 42;
    }

    private int GetInt()
    {
        return 3;
    }

    [Fact]
    public void CSharpPssbyRef()
    {
        // arrange
        var book1 = GetBook("Book 1");
        GetBookSetName(ref book1, "New Name");

        // Act

        // Assert
        Assert.Equal("Book 1", book1.Name);
    }

    private void GetBookSetName(ref Book book, string name)
    {
        book = new Book(name);
        book.Name = name;
    }


    [Fact]
    public void CSharpPssbyValue()
    {
        // arrange
        var book1 = GetBook("Book 1");
        GetBookSetName(book1, "New Name");

        // Act

        // Assert
        Assert.Equal("Book 1", book1.Name);
    }

    [Fact]
    public void CanSetNameFromReference()
    {
        // arrange
        var book1 = GetBook("Book 1");
        GetBookSetName(book1, "New Name");

        // Act

        // Assert
        Assert.Equal("Book 1", book1.Name);
    }

    private void GetBookSetName(Book book, string name)
    {
        book = new Book(name);
        book.Name = name;
    }

    [Fact]
    public void GetBookReturnDiferentObject()
    {
        // arrange
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        // Act

        // Assert
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TowbookscanReferencesameObejcts()
    {
        // arrange
        var book1 = GetBook("Book 1");
        var book2 = book1;

        // Act

        // Assert
        Assert.Equal("Book 1", book1.Name);
        Assert.Same(book1, book2);
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
}