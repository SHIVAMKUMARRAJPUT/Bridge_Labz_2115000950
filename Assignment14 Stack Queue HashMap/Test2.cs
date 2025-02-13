using System;

class MStack
{
    private int[] stack;
    private int top;
    private int capacity;

    public MStack(int size)
    {
        capacity = size;
        stack = new int[size];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == capacity - 1) return;   
        stack[++top] = value;
    }

    public int Pop()
    {
        if (top == -1) return -1;  
        return stack[top--];
    }

    public int Peek()
    {
        if (top == -1) return -1;
        return stack[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}

class StackSorter
{
    public static void SortStack(MStack stack)
    {
        if (!stack.IsEmpty())
        {
            int temp = stack.Pop();
            SortStack(stack);
            InsertSorted(stack, temp);
        }
    }

    private static void InsertSorted(MStack stack, int value)
    {
        if (stack.IsEmpty() || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(stack, value);
        stack.Push(temp);
    }
}

class Test2
{
    public static void Print()
    {
        MStack stack = new MStack(5);
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);
        stack.Push(5);

        StackSorter.SortStack(stack);

        while (!stack.IsEmpty())
        {
            Console.Write(stack.Pop() + " ");
        }
    }
}
