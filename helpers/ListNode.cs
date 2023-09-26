namespace Nodes
{
    class ListNode(int Val = 0, ListNode? Next = null)
    {
        public int val = Val;
        public ListNode? next = Next;

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            return false;
            ListNode anotherNode = (ListNode) obj;
            bool result = true;
            if(next != null && anotherNode.next != null) result = result && next.Equals(anotherNode.next);
            return anotherNode.val == val && result;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + val.GetHashCode();
            if(next != null)
                hash = hash * 23 + next.GetHashCode();
            return hash;
        }
    }
}