using CommonCollections.Models;
using System.Collections;

Dictionary<int, TestModel> dictionary = new()
{
    //keys must be unique.
    {
        1,
        new()
        {
            Num = 14,
            Text = "Lorem"
        }
    },
    {
        2,
        new()
        {
            Num = 130,
            Text = "Lorem"
        }
    }
};


HashSet<int> numbers =
[
    //values must be unique.
    1,
    2,
];

numbers.Add(3);


Hashtable hashtable = new();

hashtable.Add(1, new TestModel()
{
    Num = 1,
    Text = "Lorem"
});

Queue<int> queue = new();

//First In - First out
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

Console.WriteLine(queue.Dequeue());

//Last In - First out
Stack<int> stack = new();

stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine(stack.Pop());



Console.ReadKey();
