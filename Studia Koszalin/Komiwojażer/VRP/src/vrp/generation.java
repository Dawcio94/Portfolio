/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vrp;

import java.util.ArrayList;
import java.util.Random;

public class generation {
    
    private ArrayList<route> pokolenie = new ArrayList<route>();
    public ArrayList<route> subpokolenie = new ArrayList<route>();
    public ArrayList<route> rodzice = new ArrayList<route>();
    private double max=Double.NEGATIVE_INFINITY;
    private double all;
    public generation()
    {
        
    }
    
    public int getSize()
    {
        return pokolenie.size();
    }
    
    public route getRoute(int x)
    {
       return pokolenie.get(x);
    }
    
    public void addRoute(route buff)
    {
        pokolenie.add(buff);
        if (pokolenie.get(pokolenie.size()-1).getFC()>max)
        {
            max=pokolenie.get(pokolenie.size()-1).getFC();
        }
    }
    
    public void skalowanieFC()
    {
       for (int x=0;x<pokolenie.size();x++)
       { 
           pokolenie.get(x).skalowanie(max);
       }
       
       for (int x=0;x<pokolenie.size();x++)
       { 
           all+=pokolenie.get(x).getFC();
       }
        for (int x=0;x<pokolenie.size();x++)
       { 
            pokolenie.get(x).skalowanie(pokolenie.size(),all);
       }
    }
    
    public route getBest()
    {
        int indeks=0;
        max=Double.NEGATIVE_INFINITY;
        for (int x=0;x<pokolenie.size();x++)
       { 
           if (pokolenie.get(x).getFC()>max)
           {
                max=pokolenie.get(x).getFC();
           }
       }
        for (int x=0;x<pokolenie.size();x++)
       { 
           if (pokolenie.get(x).getFC()==max)
           {
               indeks=x;
           }
       }
         return pokolenie.get(indeks);
    }
   
    
    public int getBestID()
    {
        int indeks=0;
        max=Double.NEGATIVE_INFINITY;
        for (int x=0;x<pokolenie.size();x++)
       { 
           if (pokolenie.get(x).getFC()>max)
           {
                max=pokolenie.get(x).getFC();
           }
       }
        for (int x=0;x<pokolenie.size();x++)
       { 
           if (pokolenie.get(x).getFC()==max)
           {
               indeks=x;
           }
       }
         return indeks;
    }
    
    public void ewoluuj()
    {
        //SUBPOKOLENIE ZLOZONE Z LEPSZYCH OSOBNIKOW
        while(subpokolenie.size()<pokolenie.size())
        {
            if (getBest().getFC()>=1)
            {
                for (int x=0;x<Math.floor(getBest().getFC());x++)
                {
                   route nowa=new route();
                   nowa.setStartStop(pokolenie.get(0).getStartStop());
                    for (int y=0;y<getBest().getSize();y++)
                    {
                        nowa.addPoint(getBest().getPoint(y));
                    }
                        
                    subpokolenie.add(nowa);
                }
                pokolenie.get(getBestID()).setFC(getBest().getFC()-Math.floor(getBest().getFC()));
                
            }
            if (getBest().getFC()<1)
            {
                route nowa=new route();
                nowa.setStartStop(pokolenie.get(0).getStartStop());
                 for (int y=0;y<getBest().getSize();y++)
                    {
                        nowa.addPoint(getBest().getPoint(y));
                    }
                    subpokolenie.add(nowa);
                    pokolenie.get(getBestID()).setFC(0);
            }   
        }
       
        
        
        //KRZYZOWANIE
   
       Random ran = new Random();
        int random;
        int random2;
        int random3;
        route nowa;
        int dousuniecia=0;
        
        for (int x=0;x<subpokolenie.size();x++)
        {
            nowa=new route();
            nowa.setStartStop(subpokolenie.get(x).getStartStop());
            random =ran.nextInt(100);
            if(random<=40)
            {
                 for (int y=0;y<subpokolenie.get(x).getSize();y++)
                    {
                        nowa.addPoint(subpokolenie.get(x).getPoint(y));
                        dousuniecia=y;
                    }
                    rodzice.add(nowa);
                    subpokolenie.remove(dousuniecia);
            }
        }
        
         
            int przedzial1=(int)Math.round((double)rodzice.get(0).getSize()/3.0);
            int przedzial2=(int)Math.ceil((double)rodzice.get(0).getSize()/3.0);
            boolean rozne =true;
            
            
            while(subpokolenie.size()<pokolenie.size())
            {
                random2 =ran.nextInt(rodzice.size());
               random3 =ran.nextInt(rodzice.size());
               if(random2==random3)
               {
                   random3 =ran.nextInt(rodzice.size());
                }
                         
                //pierwsze dziecko
                
                nowa=new route();
                nowa.setStartStop(rodzice.get(random2).getStartStop()); 
                for (int y=0;y<przedzial1;y++)
                {
                    rozne=true;
                    //pierwsza 1/3
                    for (int z=przedzial1;z<przedzial1+przedzial2;z++)
                    {
                        if(rodzice.get(random2).getPoint(y).getID().equals(rodzice.get(random3).getPoint(z).getID()))
                        {
                             nowa.addPoint(rodzice.get(random2).getPoint(z));
                             rozne=false;
                        }                               
                    }
                    
                    if(rozne==true)
                    {
                        nowa.addPoint(rodzice.get(random2).getPoint(y)); 
                    }
                   
                }
                
                //srodek
                for (int y=przedzial1;y<przedzial1+przedzial2;y++)
                    {
                        nowa.addPoint(rodzice.get(random3).getPoint(y));        
                    }
                
                //koncowka
                for (int y=przedzial1+przedzial2;y<rodzice.get(0).getSize();y++)
                {
                    rozne=true;
                    for (int z=przedzial1;z<przedzial1+przedzial2;z++)
                    {
                        if(rodzice.get(random2).getPoint(y).getID().equals(rodzice.get(random3).getPoint(z).getID()))
                        {
                            nowa.addPoint(rodzice.get(random2).getPoint(z));
                            rozne=false;
                        }
                    }
                    if(rozne==true)
                    {
                        nowa.addPoint(rodzice.get(random2).getPoint(y)); 
                    } 
                }
                subpokolenie.add(nowa);
                
                boolean dousuniecia1=false;
                for(int x=0;x<subpokolenie.get(subpokolenie.size()-1).getSize();x++)
                {
                    for (int y=x+1;y<subpokolenie.get(subpokolenie.size()-1).getSize();y++)
                    {
                        if (nowa.getPoint(x).getID().equals(nowa.getPoint(y).getID()))
                        {
                            dousuniecia1=true;
                        }
                    }
                 
                }
                if(dousuniecia1==true)
                {
                subpokolenie.remove(subpokolenie.size()-1);
                dousuniecia1=false;
                }
               
              
            }
        
     
        //MUTACJA
   
        
        for (int x=0;x<subpokolenie.size();x++)
        {
            random=ran.nextInt(100) + 1;
            
            if (random==1)
            {
                nowa=new route();
                nowa.setStartStop(subpokolenie.get(x).getStartStop());
                random2 =ran.nextInt(subpokolenie.get(x).getSize());
                random3 =ran.nextInt(subpokolenie.get(x).getSize());
                
                for (int y=0;y<subpokolenie.get(x).getSize();y++)
                    {
                        nowa.addPoint(subpokolenie.get(x).getPoint(y));
                        if (x==random2)
                        {
                            nowa.addPoint(subpokolenie.get(x).getPoint(random3));
                        }
                        if (x==random3)
                        {
                            nowa.addPoint(subpokolenie.get(x).getPoint(random2));
                        }
                        
                    }
                    subpokolenie.remove(x);
                    subpokolenie.add(nowa);
             
            }
        }
        
        //przepisanie
        pokolenie.clear();
        all=0;
        max=Double.NEGATIVE_INFINITY;
        for(int x=0;x<subpokolenie.size();x++)
        {
            nowa=new route();
            nowa.setStartStop(subpokolenie.get(0).getStartStop());
            for (int y=0;y<subpokolenie.get(0).getSize();y++)
            {
                nowa.addPoint(subpokolenie.get(x).getPoint(y));
            }      
            addRoute(nowa);
        }
      
        
        rodzice.clear();
    }
    
}
