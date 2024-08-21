using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AverageLevel
    {
        public IList<double> AverageOfLevels(TreeNode root) {
            var result = new List<double>();
            var queue= new Queue<TreeNode>();
            queue.Enqueue(root); //start by enqueuing the root
            while (queue.Count > 0) { // queue is NOT empty here
                int levelItemCount = queue.Count; //the queue count is the number of items at current level
                double levelSum = 0; //this variable is used to add up all element values
                for (int i = 0; i < levelItemCount; i++) { //this will dequeue as many times as there are items in the queue
                    var node = queue.Dequeue(); //dequeue a node
                    levelSum += node.val; //add node val to the level sum
                    if (node.left != null) queue.Enqueue(node.left); // the node has left child? enqueue it for the next level
                    if (node.right != null) queue.Enqueue(node.right);// the node has right child? enqueue it for the next level
                }

                result.Add(levelSum/ levelItemCount); // the end of while loop means the end of a level.
                //calculate average by dividing levelsum by level item count
            }
            return result;
        }
    }
}
