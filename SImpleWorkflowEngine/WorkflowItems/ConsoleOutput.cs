using System;

namespace SimpleWorkflowEngine.WorkflowItems
{
    public class ConsoleOutput : WorkflowItem
    {
        private readonly string _s;
        public ConsoleOutput(string s) {
            _s = s;
        }

        private string _Guid = null;

        public string Guid {
            get {
                if(_Guid == null) {
                    _Guid = System.Guid.NewGuid().ToString();
                }
                return _Guid;
            }
        }

        public override string Name => "ConsoleOutput" + Guid;

        public override ItemInOutput Invoke(ItemInOutput input)
        {
            Console.WriteLine($"{Name} -> {_s}");
            return input;
        }
    }
}
