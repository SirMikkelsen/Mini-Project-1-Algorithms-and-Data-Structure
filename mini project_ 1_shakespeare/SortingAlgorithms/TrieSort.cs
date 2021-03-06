﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mini_project__1_shakespeare
{
    /// <summary>
    ///  Algorithm founded on the net
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TrieSort <String>  where String : IComparable
    {
      
        public Node rootNode;

        /* to make new trie*/
        public TrieSort()
        {
            rootNode = null;
        }

        // function to insert  
        // a string in trie 
        public void insert(string key, int index)
        {
            // making a new path 
            // if not already 

            if (rootNode == null)
            {
                rootNode = new Node();
            }

            Node currentNode = rootNode;
            //Console.WriteLine(key);

            for (int i = 0; i < key.Length; i++)
            {
                char keyChar = char.ToLower(key[i]);
                if(keyChar < 'a' || keyChar > 'z')
                {
                    continue;
                }
                //Console.WriteLine(currentNode);
                //Console.ReadLine();
                if (currentNode.getChild(keyChar) == null)
                {
                    currentNode.addChild(keyChar);
                }

                // go to next node
                currentNode = currentNode.getChild(keyChar);
            }

           // mark leaf(end of string)
             //    and store index of 'str'
        //     in index[]
            currentNode.addIndex(index);
        }

        public void traversePreorder(String[] array)
        {
            traversePreorder(rootNode, array);
        }

        // function for preorder 
        // traversal of trie 
        public void traversePreorder(Node node,
                                String[] array)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.getIndices().Count);

            if (node.getIndices().Count > 0)
            {
                foreach (int index in node.getIndices())
                {
                    Console.Write(array[index] + " ");
                }
            }

            for (char index = 'a'; index <= 'z'; index++)
            {
                traversePreorder(node.getChild(index), array);
            }
        }

        public class Node
        {
            public static Node[] children;
            public List<int> indices;

            public Node()
            {
                children = new Node[26];
                indices = new List<int>(0);
            }

            public Node getChild(char index)
            {
                if (index < 'a' || index > 'z')
                {
                    return null;
                }

                return children[index - 'a'];
            }

            public void addChild(char index)
            {
                if (index < 'a' || index > 'z')
                {
                    return;
                }

                Node node = new Node();
                children[index - 'a'] = node;
            }

            public List<int> getIndices()
            {
                return indices;
            }

            public void addIndex(int index)
            {
                indices.Add(index);
            }
        }
    }

}
