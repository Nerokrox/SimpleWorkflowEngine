using System;
using System.Collections.Generic;

namespace SimpleWorkflowEngine
{
    public class Workflow
    {
        // workflow name
        public string Name { get; private set; }
        private List<WorkflowItem> workflowList = new List<WorkflowItem>();
        public Workflow(string name)
        {
            Name = name;
        }

        public void AddItem(WorkflowItem item)
        {
            if (!string.IsNullOrWhiteSpace(item.Name))
                workflowList.Add(item);
            else
                throw new ArgumentException("Workflow item has no name");

            if(!CheckSoundness()) {
                throw new Exception("Workflow is not sound.");
            }
        }

        public void RemoveItem(string name)
        {
            workflowList.RemoveAll(x => x.Name.Equals(name));
            if (!CheckSoundness())
            {
                throw new Exception("Workflow is not sound.");
            }
        }

        private bool CheckSoundness(List<WorkflowItem> workList = null)
        {
            if (workList == null)
                workList = workflowList;
            WorkflowItem lastItem = null;
            var sound = true;
            foreach(var item in workList) {
                if(lastItem == null) {
                    lastItem = item;
                    continue;
                }
                var lt = lastItem.GetOutputType();
                var it = item.GetInputType();
                sound = sound && (lt == it);
                lastItem = item;
            }
            return sound;
        }

        public void Run(ItemInput input = null) {
            ItemInOutput context = input;
            foreach(var wi in workflowList) {
                context = wi.Invoke(context);
            }
        }
    }
}