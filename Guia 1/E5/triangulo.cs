namespace E5
{
    public class triangulo
    {
        double ladoA=0;
        double ladoB=0;
        double ladoC=0;

        public triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA= ladoA;
            this.ladoB= ladoB;
            this.ladoC= ladoC;
        }
        public bool EsEquilatero()
        {
            return ladoA == ladoB && ladoB==ladoC;
        }
        public bool EsIsoceles()
        {
           if(ladoA==ladoB)
            {
                return ladoB!=ladoC;
            }
            if (ladoA==ladoB)
            {
                return ladoB!=ladoC;
            }
            if(ladoB==ladoC)
            {
                return ladoC!=ladoA;
            }
            else
            {
                return false;
            }
        

           
        }
        public bool EsEscaleno()
        {
            return ladoA != ladoB && ladoA != ladoC && ladoB != ladoC;
        }
        public bool EsTrianguloRectangulo()
        {
            double mayor=ladoA;
            double cat1=0;
            double cat2=0;
            if (mayor<ladoB)
            {
                mayor=ladoB;
                cat1=ladoA;
                if (mayor<ladoC)
                {
                    mayor= ladoC;
                    cat2=ladoB;
                }
            }
            else
            {
                cat1=ladoB;
                if (mayor<ladoC)
                {
                    cat2=ladoA;
                    mayor= ladoC;
                }
                else
                {
                    cat2=ladoC;
                }

            }
            return mayor*mayor == ladoA*ladoA+ladoB*ladoB;
        }
    }
}