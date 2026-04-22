/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head)
    {
        if(head == null)
        {
            return head;
        }
        Dictionary<Node, (int, int)> dictOrder = new Dictionary<Node, (int, int)>();
        Dictionary<int, Node> dictOrderClone = new Dictionary<int, Node>();
        Node current = head;
        int index = 0;
        while(current != null)
        {
            dictOrder.Add(current, (index, 0));
            current = current.next;
            index++;
        }
        current = head;
        while(current != null)
        {
            if(current.random != null && dictOrder.ContainsKey(current.random))
            {
                var data = dictOrder[current.random];
                var (value, _) = dictOrder[current];
                dictOrder[current] = (value, data.Item1);
            }
            else
            {
                var (value, _) = dictOrder[current];
                dictOrder[current] = (value, -1);
            }
            current = current.next;
        }

        current = head;
        index = 0;
        Node cloneList = new Node(current.val);
        Node tempClone = cloneList;
        dictOrderClone.Add(0, cloneList);
        current = current.next;
        index++;
        while(current != null)
        {
            Node cloneNode = new Node(current.val);
            cloneList.next = cloneNode;
            cloneList = cloneNode;
            dictOrderClone.Add(index, cloneList);
            current = current.next;
            index++;
        }
        cloneList = tempClone;
        current = head;
        Node currentClone = cloneList;

        while(current != null)
        {
            var data = dictOrder[current].Item2;
            if(data == -1)
            {
                currentClone.random = null;
            }
            else
            {
                Node nodeRandom = dictOrderClone[data];
                currentClone.random = nodeRandom;
            }
            current = current.next;
            currentClone = currentClone.next;
        }

        return cloneList;
    }

}


