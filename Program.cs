

// lets try it on 3 Methods

Runner();

                                                    // uncomment any part you want 
                                                    // only one part at the time :)
Console.ReadKey();

#region Synchronous programming

static async void Runner()
{
    Method1();
    Method2();
    Method3();
} 

static void Method1()
{
    Thread.Sleep(8000);
    Console.WriteLine("Method1 is done ! " + DateTime.Now);
}

static void Method2()                                 //As you can see here is every method
{                                                     //runs after the other one!
    Thread.Sleep(4000);
    Console.WriteLine("Method2 is done ! " + DateTime.Now);
}
static void Method3()
{
    Thread.Sleep(6000);
    Console.WriteLine("Method3 is done ! " + DateTime.Now);
}

#endregion

#region Asynchorous programming  // Running at the same time !
/*
static void Runner()
{
    Method1();
    Method2();
    Method3();
}
static async Task Method1()
{
    await Task.Run(() =>
    {
        Thread.Sleep(8000);
        Console.WriteLine("Method1 is done ! " + DateTime.Now);
    });
}

static async Task Method2()
{
    await Task.Run(() =>
    {
        Thread.Sleep(4000);
        Console.WriteLine("Method2 is done ! " + DateTime.Now);
    });
}

static async Task Method3()
{
    await Task.Run(() =>
    {
        Thread.Sleep(6000);
        Console.WriteLine("Method3 is done ! " + DateTime.Now);
    });
}
*/
#endregion

#region Asynchronous programming // wait for and return valeu !
/*
static async void Runner()
{
    var task1 = Method1();
    await task1;
    var task2 = Method2();
    var task3 = Method3();
    Task.WaitAll(task1,task2,task3);

    Console.WriteLine(task2.Result);
    Console.WriteLine(task3.Result);
    Console.WriteLine(task1.Result);
}
static async Task<string> Method1()
{
    await Task.Run(() =>
    {
        Thread.Sleep(8000);
    });
    return "Method1 is done ! " + DateTime.Now;
}

static async Task<string> Method2()
{
    await Task.Run(() =>
    {
        Thread.Sleep(4000);
    });
    return "Method2 is done ! " + DateTime.Now;
}

static async Task<string> Method3()
{
    await Task.Run(() =>
    {
        Thread.Sleep(6000);
    });
    return "Method3 is done ! " + DateTime.Now;
}
*/
#endregion