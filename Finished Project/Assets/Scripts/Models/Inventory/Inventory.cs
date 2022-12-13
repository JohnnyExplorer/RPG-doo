
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Models.Inventory
{

    public class Inventory : MonoBehaviour
    {

        #region Singleton

        public static Inventory instance;

        void Awake()
        {
            Console.WriteLine("test");
            instance = this;
        }

        #endregion

        public delegate void OnItemChanged();
        public OnItemChanged onItemChangedCallback;

        public int space = 10;  // Amount of item spaces

        // Our current list of items in the inventory
        public List<Item> items = new List<Item>();



        public bool AddInInventory(Item item)
        {
            if (items.Count >= space)
            {
                return false;
            }
            items.Add(item);
            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
            return true;
        }

        // Add a new item if enough room
        public void Add(Item item)
        {
            if (item.showInInventory)
            {
                if (items.Count >= space)
                {
                    Debug.Log("Not enough room.");
                    return false;
                }

                items.Add(item);

                if (onItemChangedCallback != null)
                    onItemChangedCallback.Invoke();

            }
        }

        // Remove an item
        public void Remove(Item item)
        {
            items.Remove(item);

            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }

    }
}
