using System.Collections.Generic;

public class DocumentHistory
{
    public Queue<DocumentState> states = new Queue<DocumentState>();

    public void Push(DocumentState state) => states.Enqueue(state);

    public DocumentState Pop => states.Dequeue();

}