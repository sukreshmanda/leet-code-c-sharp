using Nodes;

namespace AddTwoNumbers
{
    class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var listNode = new ListNode();
            var head = listNode;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int sum = carry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                carry = sum / 10;
                sum %= 10;
                var node = new ListNode(sum);
                listNode.next = node;
                listNode = listNode.next;
            }
            if(carry > 0){
                var node = new ListNode(carry);
                listNode.next = node;
                _ = listNode.next;
            }
            if (head.next != null)
                return head.next;
            else return head;
        }
    }
}