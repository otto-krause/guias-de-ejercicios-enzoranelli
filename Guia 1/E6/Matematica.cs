namespace E6
{
    public class Matematica
    {
        int ini =0;
        int ini2=1;
        int fibo=0;
      public int Fibonacci()
      {      
         fibo=ini+ini2;
         ini=ini2;
         ini2=fibo;
         return fibo;
      } 
      public int Factorial(int num1)
      {
        int fact=1;
        for (int i=1;i<=num1;i++)
        {
          fact=fact*i;
        }
        return fact;
      }
      public int Menor(int num, int num1)
      {
        int menor=0;
        if(num<num1)
        {
          menor=num;
        }
        else{
          menor=num1;
        }
        return menor;
      }
      public int Mayor (int num, int num1)
      {
        int mayor=0;
        if(num>num1)
        {
          mayor=num;
        }
        else{
          mayor=num1;
        }
        return mayor;
      }
    

    }
    
}