using System.Runtime.CompilerServices;

namespace TestNinja.UnitTests.MSTest;

[TestClass]
public class StackTests
{
    private Fundamentals.Stack<string?> _stack;
    private Fundamentals.Stack<string?> _emptyStack;

    [TestInitialize]
    public void Setup()
    {
        _stack = new Fundamentals.Stack<string?>();
        _emptyStack = new Fundamentals.Stack<string?>();
        
        for (int i = 0; i < 5; i++)
            _stack.Push($"Test {i + 1}");
    }

    //  Count
    [TestMethod]
    public void Count_StackHasFiveEntries_ReturnFive()
    {
        Assert.AreEqual(5, _stack.Count);
    }

    //  Push
    [TestMethod]
    public void Push_NullObjectPushed_ThrowArgumentNullException()
    {
        Assert.ThrowsException<ArgumentNullException>(() => _stack.Push(null));
    }

    [TestMethod]
    public void Push_WhenCalled_AddsSuppliedValueToStack()
    {
        _stack.Push("Pushed from test");
        
        Assert.AreEqual(6, _stack.Count);
    }
    
    //  Pop
    [TestMethod]
    public void Pop_NoItemsOnStack_ThrowInvalidOperationException()
    {
        Assert.ThrowsException<InvalidOperationException>(() => _emptyStack.Pop());
    }

    [TestMethod]
    public void Pop_WhenCalled_ReturnLastValueAndRemoveFromStack()
    {
        var value = _stack.Pop();
        
        Assert.AreEqual("Test 5", value);
        Assert.AreEqual(4, _stack.Count);
    }
    
    //  Peek
    [TestMethod]
    public void Peek_NoItemsOnStack_ThrowInvalidOperationException()
    {
        Assert.ThrowsException<InvalidOperationException>(() => _emptyStack.Peek());
    }

    [TestMethod]
    public void Peek_WhenCalled_ReturnLastValueFromStack()
    {
        var value = _stack.Peek();

        Assert.AreEqual("Test 5", value);
        Assert.AreEqual(5, _stack.Count);
    }
}