
package vrp;

import java.sql.Time;
import java.util.ArrayList;
import java.util.Collections;



public class route 
{
   private String startstop;
   private ArrayList<point> trasa = new ArrayList<point>();
   private double fc=0;
   private double ile= 0;
   private double ile2=0;
   private double ile3=0;
   private int czas(String miasto1,String miasto2)
   {
    switch (miasto1)
    {
        case "BIALOGARD": 
            switch (miasto2)
            {
               case "BIALOGARD":
               {
                   return 10;
               }
               
               case "KOSZALIN":
               {
                   return 38;
               }
               
               case "MIELNO":
               {
                   return 56;
               }
               
               case "KOLOBRZEG":
               {
                   return 54;
               }
               
               case "SLUPSK":
               {
                   return 95;
               }
               
               case "SZCZECINEK":
               {
                   return 67;
               }
            }
            break;
        case "KOSZALIN": 
            switch (miasto2)
            {
               case "BIALOGARD":
               {
                  return 38;
               }
               
               case "KOSZALIN":
               {
                  return 10;
               }
               
               case "MIELNO":
               {
                   return 19;
               }
               
               case "KOLOBRZEG":
               {
                   return 42;
               }
               
               case "SLUPSK":
               {
                   return 65;
               }
               
               case "SZCZECINEK":
               {
                   return 64;
               }                  
            }
            break;
        case "KOLOBRZEG": 
            switch (miasto2)
            {
               case "BIALOGARD":
               {
                  return 54;
               }
               
               case "KOSZALIN":
               {
                   return 42;
               }
               
               case "MIELNO":
               {
                   return 40;
               }
               
               case "KOLOBRZEG":
               {
                   return 10;
               }
               
               case "SLUPSK":
               {
                   return 105;
               }
               
               case "SZCZECINEK":
               {
                   return 99;
               }
                
            }
        break;   
        case "SLUPSK": 
            switch (miasto2)
            {
               case "BIALOGARD":
               {
                  return 95;
               }
               
               case "KOSZALIN":
               {
                   return 65;
               }
               
               case "MIELNO":
               {
                   return 81;
               }
               
               case "KOLOBRZEG":
               {
                  return 105;
               }
               
               case "SLUPSK":
               {
                   return 10;
               }
               
               case "SZCZECINEK":
               {
                   return 101;
               }
                
            }
        break;
        case "MIELNO": 
            switch (miasto2)
            {
               case "BIALOGARD":
               {
                  return 56;
               }
               
               case "KOSZALIN":
               {
                   return 19;
               }
               
               case "MIELNO":
               {
                   return 10;
               }
               
               case "KOLOBRZEG":
               {
                   return 40;
               }
               
               case "SLUPSK":
               {
                   return 81;
               }
               
               case "SZCZECINEK":
               {
                   return 83;
               }
                
            }
            break;
            
        case "SZCZECINEK": 
            switch (miasto2)
            {
               case "BIALOGARD":
               {
                  return 67;
               }
               
               case "KOSZALIN":
               {
                   return 64;
               }
               
               case "MIELNO":
               {
                   return 83;
               }
               
               case "KOLOBRZEG":
               {
                   return 99;
               }
               
               case "SLUPSK":
               {
                   return 101;
               }
               
               case "SZCZECINEK":
               {
                   return 10;
               }
                
            }
            break;
        default:
            return 0;
    }
    return 0;
}
   
   public route()
           {
               
           }
   
   public void setFC(double x)
   {
       fc=x;
   }
   
   public void setStartStop(String nazwa)
   {
       startstop=nazwa;
   }
   
     public String getStartStop()
   {
       return startstop;
   } 
   
   public void addPoint(point y)
   {
       trasa.add(y);
      
       if (trasa.size()==1)
       {
           ile= czas(startstop,trasa.get(0).getMiasto())+360;
           ile2=trasa.get(0).getTimeMinH()*60+trasa.get(0).getTimeMinM();
           ile3=trasa.get(0).getTimeMaxH()*60+trasa.get(0).getTimeMaxM();
           
           if(ile>ile2 && ile<ile3)
           {
                fc+=0; 
           }
           else if (ile<ile2)
           {
                fc+=(((ile-ile2)*-1)*0.01);
                ile=trasa.get(0).getTimeMinH()*60+trasa.get(0).getTimeMinM();
           }
           else if (ile>ile3)
           {
                fc=fc+((ile-ile2)*5);
           }
       }
       else if (trasa.size()>1)
       {
           ile= ile+czas(trasa.get(trasa.size()-2).getMiasto(),trasa.get(trasa.size()-1).getMiasto());
           ile2=trasa.get(trasa.size()-1).getTimeMinH()*60+trasa.get(trasa.size()-1).getTimeMinM();
           ile3=trasa.get(trasa.size()-1).getTimeMaxH()*60+trasa.get(trasa.size()-1).getTimeMaxM();
           
           if(ile>ile2 && ile<ile3)
           {
                fc+=0; 
           }
           else if (ile<ile2)
           {
                fc+=(((ile-ile2)*-1)*0.01);
                ile=trasa.get(trasa.size()-1).getTimeMinH()*60+trasa.get(trasa.size()-1).getTimeMinM();
           }
           else if (ile>ile3)
           {
                fc=fc+((ile-ile2)*5);
           }
         }

   }
    
   
   public route random()
   {
        route trasabuff = new route();
        Collections.shuffle(trasa);
        trasabuff.startstop=startstop;
        for (int y=0; y<trasa.size();y++)
         {
            
              point buff = new point (trasa.get(y).getId(),trasa.get(y).getMiasto(),trasa.get(y).getTimeMinH(),trasa.get(y).getTimeMinM(),trasa.get(y).getTimeMaxH(),trasa.get(y).getTimeMaxM());
              trasabuff.addPoint(buff);
         }      
        return trasabuff;
   }
   
   
   public int getSize()
   {
       return trasa.size();
   }
   
   public point getPoint(int x)
   {
       return trasa.get(x);
   }
   
   public double getFC()
   {
       return fc;
   }
   
   public void skalowanie(double max)
   {
    fc=(fc*-1)+max;   
   }
   public void skalowanie(int sizeoflista, double all)
   {
    fc=(fc*sizeoflista)/all;  
   }
   
   
           
}
