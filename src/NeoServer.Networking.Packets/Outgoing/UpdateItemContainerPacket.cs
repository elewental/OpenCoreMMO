﻿using NeoServer.Game.Contracts.Items;
using NeoServer.Game.Contracts.Items.Types;
using NeoServer.Server.Contracts.Network;
using NeoServer.Server.Model.Players.Contracts;
using System;

namespace NeoServer.Networking.Packets.Outgoing
{
    public class UpdateItemContainerPacket : OutgoingPacket
    {
        private readonly byte containerId;
        public readonly byte slot;
        private readonly IItem item;
        public UpdateItemContainerPacket(byte containerId, byte slot, IItem item)
        {
            this.containerId = containerId;
            this.item = item;
            this.slot = slot;
        }

        public override void WriteToMessage(INetworkMessage message)
        {
            message.AddByte((byte)GameOutgoingPacketType.ContainerUpdateItem);

            message.AddByte(containerId);
            message.AddByte(slot);
            message.AddItem(item);
        }
    }
}
