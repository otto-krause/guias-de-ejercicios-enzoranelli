using System.Collections.Generic;
namespace E3
{
    public class Album
    {
        List<Figuritas> albun = new List<Figuritas>();
        public Album()
        {
            albun.Add(new Figuritas("Messi","Delantero","Argentina",1));
            albun.Add(new Figuritas("Aguero","Delantero","Argentina",2));
            //albun.Add(new Figuritas("Paredes","Mediocampista","Argentina",3));
            albun.Add(new Figuritas("Neymar","Delantero","Brasil",4));
            albun.Add(new Figuritas("Alvez","Defensor","Brasil",5));
            albun.Add(new Figuritas("Firmihno","Mediocampista","Brasil",6));
        }
        public bool EquipoLleno(string ps)
        {
            int cont=0;
            foreach (var i in albun)
            {
                if (i.pais==ps)
                {
                    cont++;
                }
            }
            return cont==11;
        }
        public bool AlbumLleno()
        {
            int cont=0;
            foreach( var i in albun)
            {
                if (this.EquipoLleno(i.pais))
                {
                    cont++;
                }
            }
            return cont==352;
        }
        public int CuantosJugardores(string posi)
        {
            int cont=0;
            foreach(var i in albun)
            {
                if (i.posicion==posi)
                {
                    cont++;
                }
            }
            return cont;
        }
        public int CuantosDelanteros()
        {
            string posi="Delantero";
            return this.CuantosJugardores(posi);
        }
        public int CuantosMediocampista()
        {
            string posi="Mediocampista";
            return this.CuantosJugardores(posi);
        }
        public bool FiguritaRepetida(int num)
        {
            int cont=0;
            foreach(var i in albun)
            {
                if(i.numDeFigu!=num) 
                {
                    cont++;
                }
            }
            return albun.Count==cont;
        }
        public void setFigurita(string nombre,string posi,string ps,int num)
        {
            albun.Add(new Figuritas(nombre,posi,ps,num));
        }
    }
}