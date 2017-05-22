﻿using SrpTask.Game;

namespace SrpTask
{
    public class ItemBuilder
    {
        private int _id = 10;
        private string _name = "Item";
        private int _heal = 0;
        private int _armour = 0;
        private int _weight = 0;
        private bool _unique = false;
        private bool _rare = false;

        public static ItemBuilder Build => new ItemBuilder();

        public Item AnItem()
        {
            return new Item(_id, _name, _heal, _armour, _weight, _unique, _rare);
        }

        private ItemBuilder()
        {
        }

        public ItemBuilder WithHeal(int heal)
        {
            _heal = heal;
            return this;
        }


        public ItemBuilder IsRare(bool isRare)
        {
            _rare = isRare;
            return this;
        }

        public ItemBuilder IsUnique(bool isUnique)
        {
            _unique = isUnique;
            return this;
        }

        public ItemBuilder WithId(int id)
        {
            _id = id;
            return this;
        }

        public ItemBuilder WithArmour(int armour)
        {
            _armour = armour;
            return this;
        }

        public ItemBuilder WithWeight(int weight)
        {
            _weight = weight;
            return this;
        }
    }
}