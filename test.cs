using System;
using System.Collections.Generic;

// Define a basic TreeNode class
public class TreeNode
{
    public int Value { get; }
    public List<TreeNode> Children { get; }

    public TreeNode(int value)
    {
        Value = value;
        Children = new List<TreeNode>();
    }

    public void AddChild(TreeNode childNode)
    {
        Children.Add(childNode);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating nodes for the tree
        TreeNode rootNode = new TreeNode(1);

        TreeNode childNode1 = new TreeNode(2);
        TreeNode childNode2 = new TreeNode(3);
        TreeNode childNode3 = new TreeNode(4);

        TreeNode grandChildNode1 = new TreeNode(5);
        TreeNode grandChildNode2 = new TreeNode(6);

        // Building the tree structure
        rootNode.AddChild(childNode1);
        rootNode.AddChild(childNode2);
        rootNode.AddChild(childNode3);

        childNode1.AddChild(grandChildNode1);
        childNode1.AddChild(grandChildNode2);

        // Accessing the tree
        Console.WriteLine($"Root Node Value: {rootNode.Value}");
        Console.WriteLine($"Number of Children of Root Node: {rootNode.Children.Count}");

        Console.WriteLine($"Child Node 1 Value: {childNode1.Value}");
        Console.WriteLine($"Number of Children of Child Node 1: {childNode1.Children.Count}");

        Console.WriteLine($"Grandchild Node 1 Value: {grandChildNode1.Value}");
        Console.Writ
