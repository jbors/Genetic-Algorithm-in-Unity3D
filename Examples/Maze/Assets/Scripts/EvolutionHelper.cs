using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EvolutionHelper {
    
    public static List<Vector2> CrossoverVec2(List<Vector2> VecA, List<Vector2> VecB)
    {
        //We combine the 2 vectors into 1 (randomly)
        int maxRange = Mathf.Min(VecA.Count, VecB.Count);
        List<Vector2> combinedVector = new List<Vector2>();

        for (int i = 0; i < maxRange; i++)
        {
            
            //TODO: randomly add either the move from VecA or from VecB
            if (Random.value > 0.5f)
            {
                combinedVector.Add(VecA[i]);
            } else
            {
                combinedVector.Add(VecB[i]);
            }
        }

        return combinedVector;
    }
    
    public static List<Vector2> MutateMoveset(List<Vector2> moveset, float MutationRate)
    {
        for (int i = 0; i < moveset.Count; i++)
        {
            //TODO: with a possibility of MutationRate, replace this move with a random one
            if(Random.value < MutationRate)
            {
                moveset[i] = RandomVector2();
            }
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
