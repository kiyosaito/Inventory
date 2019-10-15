
using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemID)
    {
        string _name = "";
        int _amount = 0;
        string _description = "";
        int _value = 0;
        ItemType _type = ItemType.Food;
        string _mesh = "";
        string _icon = "";

        int _damage = 0;
        int _armour = 0;
        int _heal = 0;
        switch (itemID)
        {
            #region Ingredient 0-99
            case 0:
                _name = "Bark";
                _description = "Brown bark from health tree";
                _amount = 1;
                _value = 3;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/0";
                _mesh = "Ingredient/0";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 1:
                _name = "Acorn";
                _description = "squirrel food";
                _amount = 1;
                _value = 2;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/1";
                _mesh = "Ingredient/1";
                _damage = 999;
                _armour = 01;
                _heal = 0;
                break;
            case 2:
                _name = "Peapod";
                _description = "3 peas in a pod";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/2";
                _mesh = "Ingredient/2";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region Potion 100-199
            case 100:
                _name = "Potion of Earth";
                _description = "Boosts earth magic power";
                _amount = 1;
                _value = 30;
                _type = ItemType.Potion;
                _icon = "Potion/100";
                _mesh = "Potion/100";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 101:
                _name = "Potion of Lighting";
                _description = "Boosts lightning magic power";
                _amount = 1;
                _value = 30;
                _type = ItemType.Potion;
                _icon = "Potion/101";
                _mesh = "Potion/101";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 102:
                _name = "potion of Healing";
                _description = "Heals indiviual consuming potion";
                _amount = 1;
                _value = 60;
                _type = ItemType.Potion;
                _icon = "Potion/102";
                _mesh = "Potion/102";
                _damage = 0;
                _armour = 0;
                _heal = 30;
                break;
            #endregion
            #region Scroll 200-299
            case 200:
                _name = "Fireball Scroll";
                _description = "shoots a ball of fire";
                _amount = 1;
                _value = 10;
                _type = ItemType.Scroll;
                _icon = "Scroll/200";
                _mesh = "Scroll/200";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 201:
                _name = "Waterball Scroll";
                _description = "shoots a ball of water";
                _amount = 1;
                _value = 15;
                _type = ItemType.Scroll;
                _icon = "Scroll/201";
                _mesh = "Scroll/201";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 202:
                _name = "Earthball Scroll";
                _description = "shoots a ball of earth";
                _amount = 1;
                _value = 13;
                _type = ItemType.Scroll;
                _icon = "Scroll/202";
                _mesh = "Scroll/202";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region Food 300-399 
            case 300:
                _name = "Cheese";
                _description = "a wheel of hard cheese";
                _amount = 3;
                _value = 10;
                _type = ItemType.Food;
                _icon = "Food/300";
                _mesh = "Food/300";
                _damage = 0;
                _armour = 0;
                _heal = 5;
                break;
            case 301:
                _name = "Meat";
                _description = "a large piece of meat hanging on to bone";
                _amount = 1;
                _value = 5;
                _type = ItemType.Food;
                _icon = "Food/301";
                _mesh = "Food/301";
                _damage = 0;
                _armour = 0;
                _heal = 15;
                break;
            case 302:
                _name = "Pizza";
                _description = "An italian crossed worlds to deliver this gift to this world";
                _amount = 20;
                _value = 13;
                _type = ItemType.Food;
                _icon = "Food/302";
                _mesh = "Food/302";
                _damage = 0;
                _armour = 0;
                _heal = 40;
                break;
            #endregion
            #region Amour 400-499
            case 400:
                _name = "Iron Helmet";
                _description = "Helmet made of basic iron";
                _amount = 1;
                _value = 40;
                _type = ItemType.Armour;
                _icon = "Armour/400";
                _mesh = "Armour/400";
                _damage = 0;
                _armour = 20;
                _heal = 0;
                break;
            case 401:
                _name = "Leather Shirt";
                _description = "a vest made of leather for basic protection";
                _amount = 1;
                _value = 15;
                _type = ItemType.Armour;
                _icon = "Armour/401";
                _mesh = "Armour/401";
                _damage = 0;
                _armour = 10;
                _heal = 0;
                break;
            case 402:
                _name = "Fur Bracer";
                _description = "a bracer made of leather with a fur inside for comfortability and basic protection";
                _amount = 1;
                _value = 13;
                _type = ItemType.Armour;
                _icon = "Armour/402";
                _mesh = "Armour/402";
                _damage = 0;
                _armour = 10;
                _heal = 0;
                break;
            #endregion
            #region Weapon 500-599
            case 500:
                _name = "Handaxe";
                _description = "small axe used with one hand";
                _amount = 1;
                _value = 20;
                _type = ItemType.Weapon;
                _icon = "Weapon/500";
                _mesh = "Weapon/500";
                _damage = 30;
                _armour = 0;
                _heal = 0;
                break;
            case 501:
                _name = "Mithril Dagger";
                _description = "a small blade used with one hand made of mithril";
                _amount = 1;
                _value = 15;
                _type = ItemType.Weapon;
                _icon = "Weapon/501";
                _mesh = "Weapon/501";
                _damage = 200;
                _armour = 0;
                _heal = 0;
                break;
            case 502:
                _name = "Steel Sword";
                _description = "A custom sword made of steel with a drwarvan insignia";
                _amount = 1;
                _value = 13;
                _type = ItemType.Weapon;
                _icon = "Weapon/502";
                _mesh = "Weapon/502";
                _damage = 100;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region Craftable 600-699
            case 600:
                _name = "Ox tail";
                _description = "the tail of an oxe";
                _amount = 1;
                _value = 10;
                _type = ItemType.Craftable;
                _icon = "Craftable/600";
                _mesh = "Craftable/600";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 601:
                _name = "Bat wing";
                _description = "wing of a cat";
                _amount = 1;
                _value = 5;
                _type = ItemType.Craftable;
                _icon = "Craftable/601";
                _mesh = "Craftable/601";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 602:
                _name = "Jaw bone";
                _description = "Jaw bone of animal";
                _amount = 1;
                _value = 13;
                _type = ItemType.Craftable;
                _icon = "Craftable/602";
                _mesh = "Craftable/602";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region Quest 700-799
            case 700:
                _name = "Demon Tail";
                _description = "Defeated demon's tail as proof of completion";
                _amount = 1;
                _value = 10;
                _type = ItemType.Quest;
                _icon = "Quest/700";
                _mesh = "Quest/700";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 701:
                _name = "Book of Armon";
                _description = "Armon's diary depicting all that was stolen";
                _amount = 1;
                _value = 5;
                _type = ItemType.Quest;
                _icon = "Quest/701";
                _mesh = "Quest/701";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 702:
                _name = "Myra's necklace";
                _description = "Myra left the necklace for you to deliver to the husband";
                _amount = 1;
                _value = 13;
                _type = ItemType.Quest;
                _icon = "Quest/702";
                _mesh = "Quest/702";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region Misc 800-899
            case 800:
                _name = "Rope";
                _description = "A 10 metre line of rope";
                _amount = 1;
                _value = 10;
                _type = ItemType.Misc;
                _icon = "Misc/800";
                _mesh = "Misc/800";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 801:
                _name = "Ivory";
                _description = "An old tusk bone of some animal";
                _amount = 1;
                _value = 5;
                _type = ItemType.Misc;
                _icon = "Misc/801";
                _mesh = "Misc/801";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 802:
                _name = "Cogs";
                _description = "cogs of an old clock tower";
                _amount = 1;
                _value = 13;
                _type = ItemType.Misc;
                _icon = "Misc/802";
                _mesh = "Misc/802";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            default:
                itemID = 0;
                _name = "Bark";
                _description = "Brown bark from health tree";
                _amount = 1;
                _value = 3;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/0";
                _mesh = "Ingredient/0";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
        }

        Item temp = new Item
        {
            ID = itemID,
            Name = _name,
            Amount = _amount,
            Desciption = _description,
            Value = _value,
            Type = _type,
            ObjectMesh = Resources.Load("Mesh/" + _mesh) as GameObject,
            Icon = Resources.Load("Icons/" + _icon) as Texture2D,
            Damage = _damage,
            Armour = _armour,
            Heal = _heal
        };
        return temp;
    }
}
