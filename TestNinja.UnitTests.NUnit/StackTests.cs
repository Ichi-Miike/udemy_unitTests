namespace TestNinja.UnitTests.NUnit;

[TestFixture]
public class StackTests
{
    private Fundamentals.Stack<string?> _stack;
    private Fundamentals.Stack<string?> _emptyStack;

    [SetUp]
    public void Setup()
    {
        _stack = new Fundamentals.Stack<string?>();
        _emptyStack = new Fundamentals.Stack<string?>();

        for (int i = 0; i < 5; i++)
            _stack.Push($"Test {i + 1}");
    }

    //  Count
    [Test]
    public void Count_StackHasFiveEntries_ReturnFive()
    {
        Assert.That(_stack.Count, Is.EqualTo(5));
    }

    //  Push
    [Test]
    public void Push_NullObjectPushed_ThrowArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => _stack.Push(null));
    }

    [Test]
    public void Push_WhenCalled_AddsSuppliedValueToStack()
    {
        _stack.Push("Pushed from test");

        Assert.That(_stack.Count, Is.EqualTo(6));
    }

    //  Pop
    [Test]
    public void Pop_NoItemsOnStack_ThrowInvalidOperationException()
    {
        Assert.Throws<InvalidOperationException>(() => _emptyStack.Pop());
    }

    [Test]
    public void Pop_WhenCalled_ReturnLastValueAndRemoveFromStack()
    {
        var value = _stack.Pop();

        Assert.That(value, Is.EqualTo("Test 5"));
        Assert.That(_stack.Count, Is.EqualTo(4));
    }

    //  Peek
    [Test]
    public void Peek_NoItemsOnStack_ThrowInvalidOperationException()
    {
        Assert.Throws<InvalidOperationException>(() => _emptyStack.Peek());
    }

    [Test]
    public void Peek_WhenCalled_ReturnLastValueFromStack()
    {
        var value = _stack.Peek();
        
        Assert.That(value, Is.EqualTo("Test 5"));
        Assert.That(_stack.Count, Is.EqualTo(5));
    }

}