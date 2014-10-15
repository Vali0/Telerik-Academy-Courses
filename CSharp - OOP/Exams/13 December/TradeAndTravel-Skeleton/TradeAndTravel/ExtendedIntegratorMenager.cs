using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class ExtendedIntegratorMenager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch(itemTypeString)
            {
                case "weapon":
                    {
                        item = new Weapon(itemNameString, itemLocation);
                        break;
                    }
                case "wood":
                    {
                        item = new Wood(itemNameString, itemLocation);
                        break;
                    }
                case "iron":
                    {
                        item = new Iron(itemNameString, itemLocation);
                        break;
                    }
                default:
                    {
                        return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    }
            }
            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "forest":
                    {
                        location = new Forest(locationName);
                        break;
                    }
                case "mine":
                    {
                        location = new Mine(locationName);
                        break;
                    }
                default:
                    {
                        return base.CreateLocation(locationTypeString, locationName);
                    }
            }
            return location;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    {
                        person = new Merchant(personNameString, personLocation);
                        break;
                    }
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
            return person;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch(commandWords[1])
            {
                case "gather":
                    {
                        HandleGathering(actor, commandWords);
                        break;
                    }
                case "craft":
                    {
                        HandleCraftering(actor, commandWords);
                        break;
                    }
                default:
                    {
                        base.HandlePersonCommand(commandWords, actor);
                        break;
                    }
            }
        }

        private void HandleCraftering(Person actor, string[] commandWords)
        {
            var inventory = actor.ListInventory();
            if (inventory.Count > 0)
            {
                if (commandWords[2] == "armor")
                {
                    foreach (var item in inventory)
                    {
                        if (item.ItemType == ItemType.Iron)
                        {
                            var armorItem = new Armor(commandWords[3]);
                            this.AddToPerson(actor, armorItem);
                            armorItem.UpdateWithInteraction("craft");
                        }
                    }
                }
                else if (commandWords[2] == "weapon")
                {
                    bool haveIron = false;
                    bool haveWood = false;
                    foreach (var item in inventory)
                    {
                        if (item.ItemType == ItemType.Iron)
                        {
                            haveIron = true;
                        }
                        if (item.ItemType == ItemType.Wood)
                        {
                            haveWood = true;
                        }
                    }
                    if ((haveIron == true) && (haveWood == true))
                    {
                        var weaponItem = new Weapon(commandWords[3]);
                        this.AddToPerson(actor, weaponItem);
                        weaponItem.UpdateWithInteraction("craft");
                    }
                }
            }
        }
        
        private void HandleGathering(Person actor, string[] commandWords)
        {
            if (actor.Location.LocationType == LocationType.Mine)
            {
                foreach (var item in actor.ListInventory())
                {
                    if (item.ItemType == ItemType.Armor)
                    {
                        var ironItem = new Iron(commandWords[2]);
                        this.AddToPerson(actor, ironItem);
                        ironItem.UpdateWithInteraction("gather");
                        break; // same as up
                    }
                }
            }
            if (actor.Location.LocationType == LocationType.Forest)
            {
                foreach (var item in actor.ListInventory())
                {
                    if (item.ItemType == ItemType.Weapon)
                    {
                        var woodItem = new Wood(commandWords[2]);
                        this.AddToPerson(actor, woodItem);
                        woodItem.UpdateWithInteraction("gather");
                        break; // Maybe without it
                    }
                }
            }
        }
    }
}