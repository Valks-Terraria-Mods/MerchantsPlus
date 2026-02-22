namespace MerchantsPlus.Commands;

public class ShowAllShopsCommand : ModCommand
{
    public override string Command => "showallshops";
    public override CommandType Type => CommandType.Chat;
    public override string Usage => "/showallshops";
    public override string Description => "Opens an admin-only UI for browsing all merchant shops.";

    public override void Action(CommandCaller caller, string input, string[] args)
    {
        if (!CanUseCommand(caller))
        {
            caller.Reply("Only the host/admin can use this command.", Color.OrangeRed);
            return;
        }

        if (Main.dedServ)
        {
            caller.Reply("This command is only available in-game.", Color.OrangeRed);
            return;
        }

        ModContent.GetInstance<AddCustomShopUI>().ToggleShowAllShopsUI();
    }

    private static bool CanUseCommand(CommandCaller caller)
    {
        if (Main.netMode == NetmodeID.SinglePlayer)
        {
            return true;
        }

        if (Main.netMode == NetmodeID.MultiplayerClient)
        {
            // In host-and-play multiplayer the host is player index 0.
            if (Main.myPlayer == 0)
            {
                return true;
            }

            if (HasAdminLikeFlag(caller.Player))
            {
                return true;
            }

            if (TryHasAdminLikeRemoteClient(Main.myPlayer))
            {
                return true;
            }
        }

        return false;
    }

    private static bool HasAdminLikeFlag(object instance)
    {
        if (instance is null)
        {
            return false;
        }

        return TryGetBoolMember(instance, "IsAdmin")
            || TryGetBoolMember(instance, "isAdmin")
            || TryGetBoolMember(instance, "IsOp")
            || TryGetBoolMember(instance, "isOp")
            || TryGetBoolMember(instance, "IsOperator")
            || TryGetBoolMember(instance, "isOperator")
            || TryGetBoolMember(instance, "IsHost")
            || TryGetBoolMember(instance, "isHost")
            || TryGetBoolMember(instance, "IsServerHost")
            || TryGetBoolMember(instance, "isServerHost");
    }

    private static bool TryHasAdminLikeRemoteClient(int whoAmI)
    {
        try
        {
            Type netplayType = typeof(Main).Assembly.GetType("Terraria.Netplay");
            System.Reflection.FieldInfo clientsField = netplayType?.GetField(
                "Clients",
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
            if (clientsField?.GetValue(null) is not Array clients)
            {
                return false;
            }

            if (whoAmI < 0 || whoAmI >= clients.Length)
            {
                return false;
            }

            object remoteClient = clients.GetValue(whoAmI);
            return HasAdminLikeFlag(remoteClient);
        }
        catch
        {
            return false;
        }
    }

    private static bool TryGetBoolMember(object instance, string memberName)
    {
        Type type = instance.GetType();
        const System.Reflection.BindingFlags flags =
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.Public |
            System.Reflection.BindingFlags.NonPublic;

        System.Reflection.PropertyInfo property = type.GetProperty(memberName, flags);
        if (property?.PropertyType == typeof(bool))
        {
            object value = property.GetValue(instance);
            return value is bool b && b;
        }

        System.Reflection.FieldInfo field = type.GetField(memberName, flags);
        if (field?.FieldType == typeof(bool))
        {
            object value = field.GetValue(instance);
            return value is bool b && b;
        }

        return false;
    }
}
