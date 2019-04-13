using System;

namespace SimpleWorkflowEngine
{
    public abstract class WorkflowItem
    {
        public abstract string Name { get; }

        public abstract ItemInOutput Invoke(ItemInOutput input);

        public Type GetInputType() {
            return typeof(ItemInOutput);
        }
        public Type GetOutputType() {
            return typeof(ItemInOutput);
        }
    }

    public abstract class ItemInOutput {}
    public abstract class ItemInput : ItemInOutput { }
    public abstract class ItemOutput : ItemInOutput { }
}