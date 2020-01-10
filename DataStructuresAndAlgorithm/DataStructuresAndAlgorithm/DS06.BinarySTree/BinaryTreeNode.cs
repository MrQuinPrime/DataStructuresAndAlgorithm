using System;
using System.Collections.Generic;
using System.Text;

namespace DS06.BinarySTree
{
    public class BinaryTreeNode
    {
        public string Name;              // 节点名称
        public double Value;             // 节点对象
        public BinaryTreeNode LeftNode;  // 左节点 
        public BinaryTreeNode RightNode; // 右节点

        public BinaryTreeNode(string name, double value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
