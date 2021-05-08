﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{

    public class MyMapNode<K, V>  //initializing the hashtable class
    {
        public struct keyValue<k, v>
        {

            public k Key { get; set; }
            public v Value { get; set; }

        }
        private readonly int size;

        private readonly LinkedList<keyValue<K, V>>[] items;


        public MyMapNode(int size)
        {
            this.size = size;
            //array of linkedlist size is defined
            this.items = new LinkedList<keyValue<K, V>>[size];
        }

        protected int GetArrayPosition(K key)
        {

            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        protected LinkedList<keyValue<K, V>> GetLinkedList(int position)
        {

            LinkedList<keyValue<K, V>> linkedList = items[position];

            if (linkedList == null)
            {
                linkedList = new LinkedList<keyValue<K, V>>();
                //adding a linkedlist in the given array position
                items[position] = linkedList;
            }

            return linkedList;
        }

        protected V Get(K key)
        {

            int position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedList = GetLinkedList(position);

            foreach (keyValue<K, V> item in linkedList)
            {

                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        public void Add(K key, V value)
        {

            int position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedList = GetLinkedList(position);

            keyValue<K, V> item = new keyValue<K, V>() { Key = key, Value = value };

            linkedList.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            keyValue<K, V> foundItem = default(keyValue<K, V>);
            foreach (keyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            //if item is found, it is removed
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        public void Display()
        {

            foreach (var linkedList in items)
            {

                if (linkedList != null)
                    foreach (keyValue<K, V> keyvalue in linkedList)
                    {

                        Console.WriteLine(keyvalue.Key + "\t" + keyvalue.Value);
                    }
            }
        }

        internal void Set(K key, V value)
        {
            int position = GetArrayPosition(key);
            var linkedList = GetLinkedList(position);
            KeyValue<K, V> temp = new KeyValue<K, V>();
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    temp = item;
                }
            }
            temp.Value = value;
        }

        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
    }



}
}
