using TerrariaApi.Server;
using Terraria;
using TShockAPI;

namespace PluginTemplate;

/// <summary>
/// The main plugin class should always be decorated with an ApiVersion attribute. The current API Version is 2.1
/// </summary>
[ApiVersion(2, 1)]
public class TaterlandTShockUtils : TerrariaPlugin
{
    /// <summary>
    /// The name of the plugin.
    /// </summary>
    public override string Name => "TaterlandTShockUtils";

    /// <summary>
    /// The version of the plugin in its current state.
    /// </summary>
    public override Version Version => new Version(0, 1, 0);

    /// <summary>
    /// The author(s) of the plugin.
    /// </summary>
    public override string Author => "p0t4t0sandwich";

    /// <summary>
    /// A short, one-line, description of the plugin's purpose.
    /// </summary>
    public override string Description => "General utils for Taterland's TShock servers";

    /// <summary>
    /// The plugin's constructor
    /// Set your plugin's order (optional) and any other constructor logic here
    /// </summary>
    public TaterlandTShockUtils(Main game) : base(game)
    {

    }

    /// <summary>
    /// Performs plugin initialization logic.
    /// Add your hooks, config file read/writes, etc here
    /// </summary>
    public override void Initialize()
    {
        Commands.ChatCommands.Add(new Command("taterland.admin.seed", SeedCommand, "seed")
        {
            HelpText = "Gets the world's seed"
        });
    }

    /// <summary>
    /// Performs plugin cleanup logic
    /// Remove your hooks and perform general cleanup here
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            //unhook
            //dispose child objects
            //set large objects to null
        }
        base.Dispose(disposing);
    }

    void SeedCommand(CommandArgs args)
    {
        args.Player.SendSuccessMessage($"The world's seed is: {WorldGen.currentWorldSeed}");
    }
}
