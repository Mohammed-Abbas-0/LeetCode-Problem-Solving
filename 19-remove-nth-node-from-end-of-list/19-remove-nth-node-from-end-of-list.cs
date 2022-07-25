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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode temp=new ListNode();
        temp.next=head;
        ListNode current=temp,nth=temp;
        for(int i=0;i<=n;i++){
            current=current.next;
        }
        while(current!=null){
            current=current.next;
            nth=nth.next;
        }
        nth.next=nth.next.next;
        return temp.next;
    }
}