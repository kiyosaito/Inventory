//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//namespace Linear
//{
//    public class Inventory : MonoBehaviour
//    {
//        #region Variables
//        public List<Item> inv = new List<Item>();
//        public Item selectedItem;
//        public bool showInv;

//        public Vector2 scr;
//        public Vector2 scrollPos;
//        public int money;

//        public string sortType = "";

//        public Transform dropLocation;

//        [System.Serializable]
//        public struct equipment
//        {
//            public string name;
//            public Transform location;
//            public GameObject curItem;
//        };
//        public equipment[] equipmentSlots;

//        public GUISkin skin;
//        public GUIStyle boxStyle;

//        public ScrollRect view;
//        public GameObject invButton;
//        public RectTransform content;

//        public Image icon;
//        #endregion


//        private void Start()
//        {
//            content.sizeDelta = new Vector2(292, 30);
//            inv.Add(ItemData.CreateItem(0));
//            inv.Add(ItemData.CreateItem(1));
//            inv.Add(ItemData.CreateItem(2));
//            inv.Add(ItemData.CreateItem(100));
//            inv.Add(ItemData.CreateItem(400));
//            inv.Add(ItemData.CreateItem(501));
//            Time.timeScale = 1;
//            Cursor.lockState = CursorLockMode.Locked;
//            Cursor.visible = false;
//            for (int i = 0; i < inv.Count; i++)
//            {
//                GameObject clone = Instantiate(invButton, content);
//                clone.name = inv[i].Name;
//                clone.GetComponentInChildren<Text>().text = inv[i].Name;
//            }
//        }
//        private void Update()
//        {
//            content.sizeDelta = new Vector2(292, 30 * inv.Count);
//            if (Input.GetKey(KeyCode.I))
//            {
//                inv.Add(ItemData.CreateItem(Random.Range(0, 3)));
//                GameObject clone = Instantiate(invButton, content);
//                clone.name = inv[inv.Count - 1].Name;
//                clone.GetComponentInChildren<Text>().name = inv[inv.Count - 1].Name;
//                clone.GetComponent<Button>().onClick.AddListener(() => {IconView(); });
//            }
//            if (Input.GetKeyDown(KeyCode.Tab))
//            {
//                showInv = !showInv;
//                if (showInv)
//                {
//                    Time.timeScale = 0;
//                    Cursor.lockState = CursorLockMode.None;
//                    Cursor.visible = true;
//                    return;
//                }
//                else
//                {
//                    Time.timeScale = 1;
//                    Cursor.lockState = CursorLockMode.Locked;
//                    Cursor.visible = false;
//                    return;
//                }
//            }
//            if (Input.GetKeyDown(KeyCode.P))
//            {
//                inv[5].Amount += 3;
//            }

//        }
//        public void IconView()
//        {
//            //icon.sprite = selectedItem.Icon;
//        }
//        private void OnGUI()
//        {
//            if (showInv)
//            {
//                scr.x = Screen.width / 16;
//                scr.y = Screen.height / 9;

//                GUI.Box(new Rect(0, 0, scr.x * 8, Screen.height), "");

//                if (GUI.Button(new Rect(4.25f * scr.x, 0, scr.x, 0.25f * scr.y), "All"))
//                {
//                    sortType = "All";
//                }
//                if (GUI.Button(new Rect(5.25f * scr.x, 0, scr.x, 0.25f * scr.y), "Food"))
//                {
//                    sortType = "Food";
//                }
//                if (GUI.Button(new Rect(6.25f * scr.x, 0, scr.x, 0.25f * scr.y), "Armour"))
//                {
//                    sortType = "Armour";
//                }
//                if (GUI.Button(new Rect(7.25f * scr.x, 0, scr.x, 0.25f * scr.y), "Weapon"))
//                {
//                    sortType = "Weapon";
//                }
//                if (GUI.Button(new Rect(4.25f * scr.x, 0, scr.x, 0.25f * scr.y), "Ingredients"))
//                {
//                    sortType = "Ingredients";
//                }


//                Display();

//                if (selectedItem != null)
//                {
//                    GUI.Box(new Rect(5.25f * scr.x, 0.25f * scr.y, scr.x, 0.25f * scr.y), selectedItem.Name, boxStyle); // Name
//                    GUI.skin = skin;
//                    //GUI.DrawTexture(new Rect(4.25f * scr.x, 0.5f * scr.y, 2 * scr.x, 2 * scr.y), selectedItem.Icon); // Icon
//                    GUI.Box(new Rect(4.25f * scr.x, 3 * scr.y, 3 * scr.x, 1 * scr.y), selectedItem.Desciption); // Description
//                    GUI.Box(new Rect(4.25f * scr.x, 4.25f * scr.y, scr.x, 0.25f * scr.y), "Value: " + selectedItem.Value); // Value
//                    GUI.Box(new Rect(4.25f * scr.x, 4.5f * scr.y, scr.x, 0.25f * scr.y), "Damage: " + selectedItem.Damage); // Damage
//                    GUI.Box(new Rect(4.25f * scr.x, 4.75f * scr.y, scr.x, 0.25f * scr.y), "Armour: " + selectedItem.Armour); // Armour
//                    GUI.Box(new Rect(4.25f * scr.x, 5 * scr.y, scr.x, 0.25f * scr.y), "Heal: " + selectedItem.Heal); // Heal
//                    GUI.skin = null;
//                    ItemUse();
//                }
//                else
//                {
//                    return;
//                }
//                GUI.skin = null;
//            }
//        }
//        void Display()
//        {

//            if (!(sortType == "All" || sortType == ""))
//            {
//                ItemType type = (ItemType)System.Enum.Parse(typeof(ItemType), sortType);
//                int a = 0; // amount of that type
//                int s = 0; // slot position
//                for (int i = 0; i < inv.Count; i++)
//                {
//                    if (inv[i].Type == type)
//                    {
//                        a++;
//                    }
//                }
//                if (a <= 34)
//                {
//                    for (int i = 0; i < inv.Count; i++)
//                    {
//                        if (inv[i].Type == type)
//                        {
//                            if (GUI.Button(new Rect(0.5f * scr.x, 0.25f * scr.y + s * (0.25f * scr.y), 3 * scr.x, 0.25f * scr.y), inv[i].Name))
//                            {
//                                selectedItem = inv[i];
//                            }
//                            s++;
//                        }
//                    }
//                }
//                else
//                {
//                    scrollPos = GUI.BeginScrollView(new Rect(0, 0.25f * scr.y, 3.75f * scr.x, 8.5f * scr.y), scrollPos, new Rect(0, 0, 0, 8.5f * scr.y + ((inv.Count - 34) * (0.25f * scr.y))), false, true);
//                    for (int i = 0; i < inv.Count; i++)
//                    {
//                        if (GUI.Button(new Rect(0.5f * scr.x, scr.y + i * (0.25f * scr.y), 3 * scr.x, 0.25f * scr.y), inv[i].Name))
//                        {
//                            selectedItem = inv[i];
//                        }
//                        s++;
//                    }
//                    GUI.EndScrollView();
//                }
//            }
//            else
//            {
//                if (inv.Count <= 35) // if we have 35 or less
//                {
//                    for (int i = 0; i < inv.Count; i++)
//                    {
//                        if (GUI.Button(new Rect(0.5f * scr.x, 0.25f * scr.y + i * (0.25f * scr.y), 3 * scr.x, 0.25f * scr.y), inv[i].Name))
//                        {
//                            selectedItem = inv[i];
//                        }
//                    }
//                }
//                else // more than 35
//                {
//                    // our movable scroll position
//                    scrollPos =
//                        // the statrt of our viewable area
//                        GUI.BeginScrollView(
//                            //our view window
//                            new Rect(0, 0.25f * scr.y, 3.75f * scr.x, 8.5f * scr.y),
//                            //our current scroll position
//                            scrollPos,
//                            //scroll zone (extra space)
//                            new Rect(0, 0, 0, 8.5f * scr.y + ((inv.Count - 34) * (0.25f * scr.y))),
//                            //can we see the horizontal bar?
//                            false,
//                            //can we see vertical scroll
//                            true);
//                    for (int i = 0; i < inv.Count; i++)
//                    {
//                        if (GUI.Button(new Rect(0.5f * scr.x, 0.25f * scr.y + i * (0.25f * scr.y), 3 * scr.x, 0.25f * scr.y), inv[i].Name))
//                        {
//                            selectedItem = inv[i];
//                        }
//                    }

//                    //end the scroll space
//                    GUI.EndScrollView();
//                }
//            }
//        }
//        void ItemUse()
//        {
//            switch (selectedItem.Type)
//            {
//                case ItemType.Ingredient:
//                    break;
//                case ItemType.Potion:
//                    break;
//                case ItemType.Scroll:
//                    break;
//                case ItemType.Food:
//                    break;
//                case ItemType.Armour:
//                    break;
//                case ItemType.Weapon:
//                    break;
//                case ItemType.Craftable:
//                    break;
//                case ItemType.Quest:
//                    break;
//                case ItemType.Misc:
//                    break;
//            }
//            if (GUI.Button(new Rect(6.5f * scr.x, 4.5f * scr.y, 0.75f * scr.x, 0.5f * scr.y), "Discard"))
//            {
//                for (int i = 0; i < equipmentSlots.Length; i++)
//                {
//                    // check equipped items
//                    if (equipmentSlots[i].curItem != null && selectedItem.ObjectMesh.name == equipmentSlots[i].curItem.name)
//                    {
//                        //if yes, delete
//                        Destroy(equipmentSlots[i].curItem);
//                    }
//                }
//                GameObject droppedItem = Instantiate(selectedItem.ObjectMesh, dropLocation.position, Quaternion.identity);
//                droppedItem.name = selectedItem.Name;
//                droppedItem.AddComponent<Rigidbody>().useGravity = true;
//                //reduce or delete
//                if (selectedItem.Amount > 1)
//                {
//                    selectedItem.Amount--;
//                }
//                else
//                {
//                    inv.Remove(selectedItem);
//                    selectedItem = null;
//                }
//                return;
//            }
//        }
//    }
//}
