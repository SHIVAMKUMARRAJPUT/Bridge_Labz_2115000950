using System;
class MyStack{
    private int[] stack;
    private int top;
    private int capacity;

    public MyStack(int size){
        capacity = size;
        stack = new int[size];
        top = -1;
    }

    public void Push(int value){
        if (top == capacity - 1) return; // Stack overflow protection
        stack[++top] = value;
    }

    public void Pop(){
        if (top == -1) return; // Stack underflow protection
        top--;
    }

    public int Peek(){
        if (top == -1) return -1;
        return stack[top];
    }

    public bool IsEmpty(){
        return top == -1;
    }
}

class StockSpan{
    public static void CalculateSpan(int[] prices){
        int n = prices.Length;
        int[] span = new int[n];
        MyStack stack = new MyStack(n);

        for (int i = 0; i < n; i++){
            while (!stack.IsEmpty() && prices[stack.Peek()] <= prices[i]){
                stack.Pop();
            }

            span[i] = stack.IsEmpty() ? (i + 1) : (i - stack.Peek());
            stack.Push(i);
        }
        Console.WriteLine(string.Join(" ", span));
    }
}

class Test3{
   public static void Print(){
        int[] prices = {100, 80, 60, 70, 60, 75, 85};
        StockSpan.CalculateSpan(prices);
    }
}
