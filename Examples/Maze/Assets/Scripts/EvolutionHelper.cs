using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EvolutionHelper {
    
    public static List<Vector2> CrossoverVec2(List<Vector2> Godzilla, List<Vector2> KingKong)
    {
        //We combine the 2 vectors into 1 (randomly)
        int maxRange = Mathf.Min(Godzilla.Count, KingKong.Count);
        List<Vector2> combinedCreature = new List<Vector2>();

        for (int i = 0; i < maxRange; i++)
        {
            //TODO: randomly add either the gene from Godzilla or from KingKong
            combinedCreature.Add(Godzilla[i]);
        }

        return combinedCreature;
    }
    
    public static List<Vector2> MutateMoveset(List<Vector2> moveset, float MutationRate)
    {
        for (int i = 0; i < moveset.Count; i++)
        {
            //TODO: with a possibility of MutationRate, replace this move with a random one
        }

        return moveset;
    }

    public static Vector3 RandomVector3(int extraSeed = 0)
    {
        Vector3[] possibleVectors = {
            Vector3.back,
            Vector3.forward,
            Vector3.left,
            Vector3.right,
            Vector3.up,
            Vector3.down
        };

        return possibleVectors[Random.Range(0, possibleVectors.Length)];
    }


    public static Vector2 RandomVector2(int extraSeed = 0)
    {
        Vector2[] possibleVectors = {
            Vector2.down,
            Vector2.up,
            Vector2.left,
            Vector2.right
        };

        return possibleVectors[Random.Range(0, possibleVectors.Length)];
    }
}
