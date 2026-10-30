using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Admin;
using CounterStrikeSharp.API.Modules.Utils;

namespace AdminSpec;

[MinimumApiVersion(80)]
public sealed class AdminSpecPlugin : BasePlugin {
    public override string ModuleName => "AdminSpec";
    public override string ModuleVersion => "1.0.0";
    public override string ModuleAuthor => "Cyrathec";
    public override string ModuleDescription => "Adds !spec for admins with @css/ban.";

    [ConsoleCommand("css_spec", "Move yourself to the Spectator team.")]
    [CommandHelper(whoCanExecute: CommandUsage.CLIENT_ONLY)]
    [RequiresPermissions("@css/ban")]
    public void OnSpecCommand(CCSPlayerController? player, CommandInfo command) {
        if (player is null || !player.IsValid) {
            command.ReplyToCommand("[AdminSpec] Couldn't find the player.");
            return;
        }

        if (player.Team == CsTeam.Spectator)
            return;

        player.ChangeTeam(CsTeam.Spectator);
        command.ReplyToCommand("[AdminSpec] Swapped to spectators.");
    }
}
