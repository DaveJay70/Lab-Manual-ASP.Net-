using System.Collections;
using System.Collections.Generic;
//Console.WriteLine("-------------------------------Lab4.1----------------------");
//Console.WriteLine("------------------------Array List-------------------------------- ");
//ArrayList a1 = new ArrayList();

//a1.Add("Jay");
//a1.Add("Jayesh");
//a1.Add("Parth");
//a1.Add("Mohit");
//a1.Add("Yash");
//a1.Add("Mudit");
//foreach (string obj in a1)
//{
//    Console.WriteLine(obj);
//}
//a1.Remove("Parth");
//Console.WriteLine("-----------------Remove------------------------");
//foreach (string obj in a1)
//{
//    Console.WriteLine(obj);
//}
//a1.RemoveRange(4, 1);
//Console.WriteLine("-----------------RemoveRange------------------------");
//foreach (string obj in a1)
//{
//    Console.WriteLine(obj);
//}
//a1.Clear();
//Console.WriteLine("-----------------clear------------------------");
//foreach (string obj in a1)
//{
//    Console.WriteLine(obj);
//}

//Console.WriteLine("-------------------------------Lab4.2----------------------");

//Console.WriteLine("------------------------List-------------------------------- ");
//List<string> studentList = new List<string>();
//studentList.Add("Jay");
//studentList.Add("Jayesh");
//studentList.Add("Parth");
//studentList.Add("Mohit");
//studentList.Add("Yash");
//studentList.Add("Mudit");
//foreach (string obj in studentList)
//{
//    Console.WriteLine(obj);
//}
//studentList.Remove("Parth");
//Console.WriteLine("-----------------Remove------------------------");
//foreach (string obj in studentList)
//{
//    Console.WriteLine(obj);
//}
//studentList.RemoveRange(4, 1);
//Console.WriteLine("-----------------RemoveRange------------------------");
//foreach (string obj in studentList)
//{
//    Console.WriteLine(obj);
//}
//studentList.Clear();
//Console.WriteLine("-----------------clear------------------------");
//foreach (string obj in studentList)
//{
//    Console.WriteLine(obj);
//}

//Console.WriteLine("-------------------------------Lab4.3----------------------");

//Console.WriteLine("--------------------------------Stack-------------------------------");

//Stack st = new Stack();

//st.Push(10);
//st.Push(20);
//st.Push(30);
//st.Push(40);
//st.Push(50);
//st.Pop();
//Console.Write("Peek Elements are :-");
//Console.WriteLine(st.Peek());
//foreach (object o in st)
//{
//    Console.WriteLine(o);
//}
//Console.Write("Contains:-");
//Console.WriteLine(st.Contains(10));
//Console.Write("Stack Clear");
//st.Clear();
//foreach (object o in st)
//{
//    Console.WriteLine(o);
//}

Console.WriteLine("-------------------------------Lab4.4----------------------");
Console.WriteLine("-------------------------------Queue----------------------");

Queue q1 = new Queue();
q1.Enqueue(10);
q1.Enqueue(20);
q1.Enqueue(30);
q1.Enqueue(40);
q1.Enqueue(50);
Console.WriteLine("Elements are :-");
foreach (object o in q1)
{
    Console.WriteLine(o);
}

q1.Dequeue();
Console.WriteLine("After Dequeue opration Queue  are :-");
foreach (object o in q1)
{
    Console.WriteLine(o);
}
Console.Write("Peek Elements are :-");
Console.WriteLine(q1.Peek());

Console.Write("Contains:-");
Console.WriteLine(q1.Contains(20));
Console.Write("Queue Clear");
q1.Clear();
foreach (object o in q1)
{
    Console.WriteLine(o);
}








