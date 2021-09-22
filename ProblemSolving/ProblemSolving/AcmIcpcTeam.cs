using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class AcmIcpcTeam
    {
        public List<int> AcmIcpcTeamSol(List<string> topic)
        {
            List<int> res = new List<int>() {0, 0};

            List<int> knownResult = new List<int>();
             
            int knownTopic = 0; 


            for(int i = 0; i < topic.Count - 1; i++ )
            {
                for(int j = i+1; j < topic.Count; j++)
                {
                    for(int k = 0; k < topic[i].Length; k++)
                    {
                        if(topic[i][k] == '1' || topic[j][k] == '1')
                        {
                            knownTopic++;
                        }
                    } 
                    knownResult.Add(knownTopic);
                    knownTopic = 0;
                }
            }

            knownResult.Sort();
            knownResult.Reverse();


            res[0] = knownResult[0];

            for (int i = 0; i < knownResult.Count; i++)
            {
                if (knownResult[i] == knownResult[0])
                    res[1]++;
            }

            return res;

        } 
    }
}
