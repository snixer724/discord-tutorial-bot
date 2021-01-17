using Discord.Commands;
using System.Threading.Tasks;

public class HiJeremyModule : ModuleBase<SocketCommandContext>
{
    [Command("jeremy")]
    [Summary("Tell Jeremy a joke")]
    public async Task HiJeremyAsync()
    {
        await ReplyAsync("Jeremy is that dude!");
    }
}
