// ReSharper disable InconsistentNaming

using KSP.OAB;
using Premonition.Core.Attributes;

namespace SpringCleaning.Utilities;

[PremonitionAssembly("Assembly-CSharp")]
[PremonitionType("KSP.OAB.AssemblyPartsPicker")]
public class Patches
{
    internal static readonly HashSet<string> PartsToHide = [];

    [PremonitionMethod("ApplyPartsFilter")]
    [PremonitionPostfix]
    public static List<IObjectAssemblyAvailablePart> ApplyPartsFilter(List<IObjectAssemblyAvailablePart> __retVal)
    {
        return __retVal.FindAll(p => !PartsToHide.Contains(p.Name));
    }
}