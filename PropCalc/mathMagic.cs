using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropCalc
{
    class mathMagic
    {
        private const float effCoef = 0.85F;
        private float S; 
        private float traction; // P
        private float loadCoefB; // B stick
        public int power;  // N
        
        private float freq;
        private float maxRadius;
        private float radius;
        private int speed;
        private int maxTipSpeed;
        private float tipSpeed;
        private float density;
        private float eff;
        private float effStep;
        private float effAxis; // 
        private int blades; // i
        private float relativeR = 0.35F; // r stick

        public float PowerSum { get; set; } // contains summed power from prop parts N
        public float TractionSum { get; set; } // contains summed traction from prop parts P


        public mathMagic(int power, int freq, float radius, int speed, int tipSpeed, float density, float eff, float effStep, int blades)
        {
            this.power = power * 735;
            this.freq = (float)freq * (float)0.1047;
            this.maxRadius = radius;
            this.speed = speed;
            this.blades = blades;
            if (tipSpeed > 260)
            {
                this.maxTipSpeed = 260;
            } else
            {
                this.maxTipSpeed = tipSpeed;
            }
            
            this.density = density;
            if (eff > 0.75)
            {
                this.Eff = 0.75F;
            } else
            {
                this.Eff = eff;
            }
            
            this.effStep = effStep;

        }

        public float Traction { get => traction; set => traction = value; }
        public float Radius { get => radius; set => radius = value; }
        public float Eff { get => eff; set => eff = value; }

        public void firstStep()
        {
            effAxis = (float)Math.Round(Eff / effCoef, 2, MidpointRounding.AwayFromZero);

            loadCoefB = 4 * ((1 / (effAxis * effAxis)) - (1 / effAxis));
            loadCoefB = (float)Math.Round(loadCoefB, 2, MidpointRounding.AwayFromZero);

            Traction = (float)Math.Round(power * Eff / speed, 0, MidpointRounding.AwayFromZero);

            S = 2 * Traction / (loadCoefB * density * (speed * speed));
            S = (float)Math.Round(S, 2, MidpointRounding.AwayFromZero);
            
            Radius = (float)Math.Round((float)Math.Sqrt(S / 3.14), 2, MidpointRounding.AwayFromZero);

            if (Radius > maxRadius)
            {
                Eff -= effStep;
                this.firstStep();
                return;
            }

            tipSpeed = (float)Math.Round(freq * Radius, 0, MidpointRounding.AwayFromZero);

            if (tipSpeed > maxTipSpeed)
            {
                Eff -= effStep;
                this.firstStep();
            }

        }

        public List<PropPart> secondStep(int alfa, float relativeB)
        {
            relativeR = 0.35F;
            float V1 = (speed + (float)Math.Sqrt(Math.Pow(speed, 2) + ((4 * traction) / (density * S)))) / 2;
            List<PropPart> propParts = new List<PropPart>();

            for (int i = 0; i < 7; i++)
            {

                float stepR = Radius * relativeR;

                

                float relativeThic = 0.1F + (0.44F * (float)Math.Pow((1 - relativeR), 2));

                float Cy = 0.264F + (0.084F * alfa) + (2.32F * (relativeThic - 0.12F));




                float Kb = 60 - (2200 * (float)Math.Pow((relativeThic - 0.18F), 2));

                float AlfaB = 4.6F + 25 * (relativeThic - 0.09F);
       
                float K1 = 0.72F - 1500 * (float)Math.Pow((relativeThic - 0.18F), 3);

                float K = Kb - (K1 * (float)Math.Pow((alfa - AlfaB), 2));


                float torrent = 1 / K;
                


                float U = freq * stepR;

                float B = 4 * relativeB * (float)Math.Sqrt(stepR * (Radius - stepR));


                
                

                float W1 = (float)Math.Sqrt((U * U) + (V1 * V1));

                float beta = (float)Math.Atan(V1 / U);
                beta = beta * (float)(180 / Math.PI);

                float dS = B * 0.1F *  Radius;

                float dF = Cy * density * (W1 * W1) * dS / 2;

                float gh = beta + (57.3F * torrent); // gamma

                float ph = beta + alfa;

                gh = gh * (float)(Math.PI / 180);
                float dTraction = 2 * dF * (float)Math.Cos(gh);

                float dPower = 2 * dF * U * (float)Math.Sin(gh);


                PropPart part = new PropPart();

                part.realtiveR = relativeR;
                part.R = stepR;
                part.chord = B;
                part.thickness = relativeThic;
                part.anglePh = ph;
                part.deltaTraction = dTraction;
                part.deltaPower = dPower;

                PowerSum += dPower;
                TractionSum += dTraction;


                propParts.Add(part);

                relativeR += 0.1F;
            }

            return propParts;

        }

    }
}
