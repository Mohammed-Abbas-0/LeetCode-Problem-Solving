/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null) return head;
        ListNode Temp = head;
        while(Temp.next != null)
        {
            if(Temp.val == Temp.next.val) Temp.next = Temp.next.next;
            else Temp = Temp.next;
        }
        return head;
    }
}
