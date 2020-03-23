using NeoServer.Server.Model.Creatures;
using NeoServer.Server.Model.Creatures.Contracts;
using NeoServer.Server.Model.Items.Contracts;
using NeoServer.Server.Model.World.Structs;
using NeoServer.Server.World;
using System;
using System.Collections.Generic;
namespace NeoServer.Server.Model.Players
{
    public class PlayerModel
    {
        public int Id { get; }
        public string CharacterName { get; set; }

        public AccountModel Account { get; set; }
        public ChaseMode ChaseMode { get; set; }
        public ushort Capacity { get; set; }
        public ushort Level { get; set; }
        public ushort HealthPoints { get; set; }
        public ushort MaxHealthPoints { get; set; }
        public VocationType Vocation { get; set; }
        public Gender Gender { get; set; }
        public bool Online { get; set; }
        public ushort Mana { get; set; }
        public ushort MaxMana { get; set; }
        public FightMode FightMode { get; }
        public byte SoulPoints { get; set; }
        public byte MaxSoulPoints { get; set; }
        public IDictionary<SkillType, ISkill> Skills { get; set; }

        public Outfit Outfit { get; set; }

        public ushort StaminaMinutes { get; set; }

        public Dictionary<Slot, ushort> Inventory { get; set; }
       // public Location Location { get; set; }

        public bool IsMounted()
        {
            return false;
        }

        // public string GetDescription(bool isYourself)
        // {
        //     if(isYourself){
        //         return $"You are {Vocation}"
        //     }
        // }

    }
}