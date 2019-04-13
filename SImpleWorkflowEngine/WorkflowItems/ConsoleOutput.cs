using System;

namespace SimpleWorkflowEngine.WorkflowItems
{
    public class ConsoleOutput : WorkflowItem
    {
        private readonly string _s;
        public ConsoleOutput(string s) {
            _s = s;
        }

        public override string Name => "ConsoleOutput";

        public override ItemInOutput Invoke(ItemInOutput input)
        {
            Console.WriteLine(_s);
            return input;
        }
    }
}
