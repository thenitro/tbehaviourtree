namespace TBehaviourTree
{
    public class SelectorNode : Node
    {
        private Node[] _children;
        
        public SelectorNode(Node[] children)
        {
            _children = children;
        }

        public override NodeState Tick()
        {
            foreach (var child in _children)
            {
                var state = child.Tick();

                if (state is NodeState.Running or NodeState.Success)
                {
                    return state;
                }
            }

            return NodeState.Failure;
        }
    }
}