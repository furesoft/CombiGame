using System.Collections.Generic;

namespace CombiGame.Models;

public record CombinationItem(Item first, Item? second = default)
{
    private static readonly Dictionary<CombinationItem, Item> map = new()
    {
        [ItemDefinitions.WATER + ItemDefinitions.WATER] = ItemDefinitions.OCEAN,
        [ItemDefinitions.PLANT + ItemDefinitions.WATER] = ItemDefinitions.PLANET,
        [ItemDefinitions.TREE + ItemDefinitions.TREE] = ItemDefinitions.FOREST,
        [ItemDefinitions.SOIL + ItemDefinitions.WATER] = ItemDefinitions.FLOWER,
        [ItemDefinitions.FLOWER + ItemDefinitions.WATER] = ItemDefinitions.TREE,
        [ItemDefinitions.SUN + ItemDefinitions.WATER] = ItemDefinitions.STEAM
    };

    public static implicit operator CombinationItem(Item f)
    {
        return new(f);
    }

    public static CombinationItem operator +(CombinationItem first, Item second)
    {
        return first with {second = second};
    }

    public Item Resolve()
    {
        if (map.ContainsKey(this)) return map[this];

        var reversed = new CombinationItem(second, first);

        if (map.ContainsKey(reversed)) return map[reversed];

        return first;
    }
}