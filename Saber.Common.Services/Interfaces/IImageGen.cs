using Discord;

namespace Saber.Common.Services.Interfaces;

public interface IImageGen
{
    public Task<IEnumerable<string>?> ImageGen(string prompt, int count = 1, IUser? user = null);
}