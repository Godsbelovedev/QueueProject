// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// var stack = Attendance();
// LastFive(stack);

// static Stack<string> Attendance()
// {
//     var stack = new Stack<string>();
//     System.Console.WriteLine("how many student are in the class");
//     int numOfStudents = int.Parse(Console.ReadLine());

//     for (int i = 0; i <numOfStudents; i++)
//     {
//         System.Console.WriteLine("Enter your Name");
//         string name = System.Console.ReadLine();

//         name = name +", "+DateTime.Now.ToString();
//         stack.Push(name);
//     }
//     return stack;
// }


// static void LastFive(Stack<string> firstfive)
// {
//     int count = 0;
//     System.Console.WriteLine("thos are the first five student tha came early");
//     System.Console.WriteLine();

//     foreach (var item in firstfive)
//     {
//         count++;
//         if (count == 6)
//         {
//             break;
//         }
//         else
//         {
//             System.Console.WriteLine(item);
//             System.Console.WriteLine();
//         }
//     }
// }



// var queue = Attendance();
// firstFive(queue);

// static Queue<string> Attendance()
// {
//     var queue = new Queue<string>();
//     System.Console.WriteLine("how many student are in the class");
//     int numOfStudents = int.Parse(Console.ReadLine());

//     for (int i = 0; i <numOfStudents; i++)
//     {
//         System.Console.WriteLine("Enter your Name");
//         string name = System.Console.ReadLine();

//         name = name +", "+DateTime.Now.ToString();
//         queue.Enqueue(name);
//     }
//     return queue;
// }


// static void firstFive(Queue<string> firstfive)
// {
//     int count = 0;
//     System.Console.WriteLine("these are the first five student that came early");
//     System.Console.WriteLine();

//     foreach (var item in firstfive)
//     {
//         count++;
//         if (count == 6)
//         {
//             break;
//         }
//         else
//         {
//             System.Console.WriteLine(item);
//             System.Console.WriteLine();
//         }
//     }
// }


// for (int i = 0 ; i < 10; i++)
// {
//     Thread.Sleep(2000);
//     System.Console.Beep();
// }

var x = ToDo();
Alarm(x);


static Queue<string> ToDo()
{
    var queue = new Queue<string>();

    System.Console.WriteLine("please enter the number of task");
    int numOfTask = int.Parse(Console.ReadLine());

    for (int i = 0; i < numOfTask; i++)
    {
        System.Console.WriteLine("input tasks");
        string tasks = Console.ReadLine();
        queue.Enqueue(tasks);



    }
    return queue;
}

static void Alarm (Queue<string> alarm)
{
    
foreach (var item in alarm)
{
    
    System.Console.WriteLine(item);
    Thread.Sleep(2000);
    System.Console.Beep(1000, 500);

}

}
int a = 10;
System.Console.WriteLine(a);
// i love coding
