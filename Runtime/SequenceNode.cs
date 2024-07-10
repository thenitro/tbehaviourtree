namespace TBehaviourTree
{
    public class SequenceNode : Node
    {
        private Node[] _children;

        public SequenceNode(Node[] children)
        {
            _children = children;
        }

        public override NodeState Tick(float deltaTime)
        {
            foreach (var child in _children)
            {
                var state = child.Tick(deltaTime);

                if (state is NodeState.Running or NodeState.Failure)
                {
                    return state;
                }
            }

            return NodeState.Success;
        }
    }
}