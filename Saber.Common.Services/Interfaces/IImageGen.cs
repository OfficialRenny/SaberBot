using NetCord;

namespace Saber.Common.Services.Interfaces;

public interface IImageGen
{
    public Task<IEnumerable<string>?> ImageGen(string prompt, int count = 1, User? user = null);
}