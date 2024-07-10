namespace TBehaviourTree
{
    public abstract class Node
    {
        public abstract NodeState Tick(float deltaTime);
    }
}