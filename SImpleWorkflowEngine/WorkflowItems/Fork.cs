using System;

namespace SimpleWorkflowEngine.WorkflowItems {
    public class Fork<I> : WorkflowItem where I : ItemInOutput
    {
        public override Type GetInputType()
        {
            return typeof(I);
        }

        public override Type GetOutputType()
        {
            return typeof(O);
        }

        public override ItemInOutput Invoke(ItemInOutput input)
        {
            return input;
        }
    }
}