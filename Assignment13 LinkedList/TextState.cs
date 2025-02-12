using System;

class TextState{
    public string Content;
    public TextState Prev;
    public TextState Next;

    public TextState(string content){
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor{
    private TextState current;
    private int maxHistory;
    private int count;

    public TextEditor(int historySize = 10){
        current = null;
        maxHistory = historySize;
        count = 0;
    }

    public void AddState(string content){
        TextState newState = new TextState(content);
        if (current != null){
            newState.Prev = current;
            current.Next = newState;
        }
        current = newState;
        count++;
        
        // Limit history size
        if (count > maxHistory){
            TextState temp = current;
            while (temp.Prev != null){
                temp = temp.Prev;
            }
            temp.Next.Prev = null;
            temp.Next = null;
            count--;
        }
    }

    public void Undo(){
        if (current != null && current.Prev != null){
            current = current.Prev;
            Console.WriteLine("Undo: " + current.Content);
        } else {
            Console.WriteLine("No more undo actions available.");
        }
    }

    public void Redo(){
        if (current != null && current.Next != null){
            current = current.Next;
            Console.WriteLine("Redo: " + current.Content);
        } else {
            Console.WriteLine("No more redo actions available.");
        }
    }

    public void DisplayCurrentState(){
        if (current != null){
            Console.WriteLine("Current Text: " + current.Content);
        } else {
            Console.WriteLine("No text available.");
        }
    }
}

class Test8{
    public static void Print(){
        TextEditor editor = new TextEditor();

        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");
        editor.DisplayCurrentState();

        editor.Undo();
        editor.Undo();
        editor.Redo();
        editor.Redo();
        editor.Undo();
        editor.DisplayCurrentState();
    }
}
