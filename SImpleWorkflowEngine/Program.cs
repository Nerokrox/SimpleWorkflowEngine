using System;
using SimpleWorkflowEngine.WorkflowItems;

namespace SimpleWorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Workflow test
            var wf = new Workflow("TestWorkflow");
            wf.AddItem(new ConsoleOutput("1"));
            wf.AddItem(new ConsoleOutput("2"));
            wf.AddItem(new ConsoleOutput("3"));
            wf.Run();
            Console.ReadKey();
        }
    }
}
