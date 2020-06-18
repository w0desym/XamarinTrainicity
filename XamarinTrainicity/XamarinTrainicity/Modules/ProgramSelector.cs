using System;

namespace XamarinTrainicity.Modules
{
    public class ProgramSelector
    {
        int weight;
        int height;
        int maxPushUps;
        int maxSquats;
        int maxPullUps;
        int bmi;
        double level;

        public ProgramSelector(int weight, int height, int maxPushUps, int maxSquats, int maxPullUps)
        {
            this.weight = weight;
            this.height = height;
            this.maxPushUps = maxPushUps;
            this.maxSquats = maxSquats;
            this.maxPullUps = maxPullUps;
            bmi = CalculateBmi(this.height, this.weight);
            level = CalculateLevel(this.maxPushUps, this.maxSquats, this.maxPullUps);
        }

        public ProgramSelector()
        {

        }

        public int CalculateBmi(int height, int weight)
        {
            bmi = Convert.ToInt32(weight / Math.Pow(height / 100.0, 2));
            return bmi;
        }

        public double CalculateLevel(int maxPushUps, int maxSquats, int maxPullUps)
        {
            level = (0.85 * maxPushUps + 0.25 * maxSquats + 2.5 * maxPullUps) / 3;
            return level;
        }

        public int SelectProgram()
        {
            if (bmi < 19)
            {
                if (level < 25)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if (bmi < 27)
            {
                if (level < 25)
                { 
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                if (level < 25)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
