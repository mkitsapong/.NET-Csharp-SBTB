using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    internal class Class1
    {
        public Class1(double latte_Coff, double espresso, double IcedLatte, double vale_Coff, double Afri,
                        double amer, double Capp_Coff, double iCapp_Coff, double c_Cakes, double v_Cakes, double cF_Cakes, double cB_Cakes,
                        double cL_Cakes, double cK_Cakes, double cC_Cakes, double cQ_Cakes)
        {
            newlatte_Coff = latte_Coff;
            newespresso = espresso;
            newIcedLatte = IcedLatte;
            newvale_Coff = vale_Coff;
            newAfri = Afri;
            newamer = amer;
            newCapp_Coff = Capp_Coff;
            newiCapp_Coff = iCapp_Coff;

            newc_Cakes = c_Cakes;
            newv_Cakes = v_Cakes;
            newF_Cakes = cF_Cakes;
            newB_Cakes = cB_Cakes;
            newL_Cakes = cL_Cakes;
            newK_Cakes = cK_Cakes;
            newC_Cakes = cC_Cakes;
            newQ_Cakes = cQ_Cakes;  
        }

        public Class1()
        {
            newlatte_Coff = 0.0;
            newespresso = 0.0;
            newIcedLatte = 0.0;
            newvale_Coff = 0.0;
            newAfri = 0.0;
            newamer = 0.0;
            newCapp_Coff = 0.0;
            newiCapp_Coff = 0.0;

            newc_Cakes = 0.0;
            newv_Cakes = 0.0;
            newF_Cakes = 0.0;
            newB_Cakes= 0.0;
            newL_Cakes = 0.0;
            newK_Cakes = 0.0;
            newC_Cakes = 0.0;
            newQ_Cakes = 0.0;
        }

        public double getlatee_Coff()
        {
            return newlatte_Coff;
        }

        public double getespresso()
        {
            return newespresso;
        }
        public double getIcedlatte()
        {
            return newIcedLatte;
        }
        public double getvale_Coff()
        {
            return newvale_Coff;
        }
        public double getAfri()
        {
            return newAfri;
        }
        public double getamer()
        {
            return newamer;
        }
        public double getCapp_Coff()
        {
            return newCapp_Coff;
        }
        public double getiCapp_Coff()
        {
            return newiCapp_Coff;
        }
        public double getc_Cakes()
        {
            return newc_Cakes;
        }
        public double getv_Cakes()
        {
            return newv_Cakes;
        }
        public double getcF_Cakes()
        {
            return newF_Cakes;
        }
        public double getcB_Cakes()
        {
            return newB_Cakes;
        }
        public double getcL_Cakes()
        {
            return newL_Cakes;
        }
        public double getcK_Cakes()
        {
            return newK_Cakes;
        }
        public double getcC_Cakes()
        {
            return newC_Cakes;
        }
        public double getcQ_Cakes()
        {
            return newQ_Cakes;
        }

        private double newlatte_Coff;
        private double newespresso;
        private double newIcedLatte;
        private double newvale_Coff;
        private double newAfri;
        private double newamer;
        private double newCapp_Coff;
        private double newiCapp_Coff;

        private double newc_Cakes;
        private double newv_Cakes;
        private double newF_Cakes;
        private double newB_Cakes;
        private double newL_Cakes;
        private double newK_Cakes;
        private double newC_Cakes;
        private double newQ_Cakes;
    }
}
